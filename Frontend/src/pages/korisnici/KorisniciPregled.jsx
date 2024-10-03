
import { useEffect, useState } from "react"
import KorisnikService from "../../services/KorisnikService"
import { Table } from "react-bootstrap"



export default function KorisniciPregled() {

    const[korisnici, setKorisnici] = useState()

    async function dohvatiKorisnike(){
        const odogovr = await KorisnikService.get()
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
    }
    setKorisnici(odogovr.poruka)
}
    //hook
    useEffect(()=>{
        dohvatiKorisnike()

    }, [])

    return(
        <>
        <Table striped border hover responsive>
            <thead>
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
                            {korisnik.brojMob}
                        </td>
                        <td>
                            {korisnik.email}
                        </td>
                        <td>
                            {korisnik.lozinka}
                        </td>
                        <td>Akcija</td>

                    </tr>
                ))}
            </tbody>

        </Table>
        </>
    )
    
}