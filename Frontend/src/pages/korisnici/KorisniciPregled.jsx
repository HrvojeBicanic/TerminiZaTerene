
import { useEffect, useState } from "react"
import KorisnikService from "../../services/KorisnikService"
import { Button, Table } from "react-bootstrap"
import { Link } from "react-router-dom"
import { RouteNames } from "../../constant"



export default function KorisniciPregled() {

    const[korisnici, setKorisnici] = useState()

    async function dohvatiKorisnike(){
        const odgovor = await KorisnikService.get()
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
    }
    
    setKorisnici(odgovor.poruka)
}
    //hook
    useEffect(()=>{
        dohvatiKorisnike()

    }, [])

    function nijeDefinirano(kontakt) {
        if (kontakt==null) {
            return 'Nije definirano'
        }
        return kontakt

    }

    function obrisi(id) {
    if (!confirm('Sigurno obrisati?')){
            return
    }
        brisanjeKorisnika(id)
    }

    async function brisanjeKorisnika (id) { 

    const odgovor = await KorisnikService.brisanje(id)
    if (odgovor.greska) {
        alert(odgovor.poruka)
        return
    }
    dohvatiKorisnike()
}



    

    return(
        <>
        
        <Link to={RouteNames.KORISNIK_NOVI}
        className="btn btn-success siroko"
        >Dodaj novog korisnika</Link>
        <Table striped border hover responsive>
            
            <thead >
                <tr>
                    <th>Ime</th>
                    <th>Prezime</th>
                    <th>Broj mobitela</th>
                    <th>Email</th>
                    <th>Lozinka</th>
                    <th>Akcija</th>
                </tr>
            </thead>
            <tbody>
                {korisnici && korisnici.map((korisnik, index)=>(
                    <tr key={index}>
                        <td>
                            {korisnik.ime}
                        </td>
                        <td>
                            {korisnik.prezime}
                        </td>
                        <td>
                            {nijeDefinirano(korisnik.brojMob)}
                        </td>
                        <td>
                            {korisnik.email}
                        </td>
                        <td>
                            {korisnik.lozinka}
                        </td>
                        <td>
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(korisnik.id)}>

                                Ukloni
                            </Button>
                        </td>

                    </tr>
                ))}
            </tbody>

        </Table>
        
        </>
    )
    
}