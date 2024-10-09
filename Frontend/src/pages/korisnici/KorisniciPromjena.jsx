import { Link, useNavigate, useParams } from "react-router-dom"
import KorisnikService from "../../services/KorisnikService"
import { Button, Row, Col, Form} from "react-bootstrap"
import { RouteNames } from "../../constant"
import { useEffect, useState } from "react"



export default function KorisniciPromjena() {

    const [korisnik, setKorisnik] = useState({})
    const navigate = useNavigate() 
    const routeParams = useParams()

    async function dohvatiKorisnika(){
      const odgovor = await KorisnikService.getBySifra(routeParams.id)
      if(odgovor.greska){
          alert(odgovor.poruka)
          return
  }
  setKorisnik(odgovor.poruka)
}

    //hook
    useEffect(()=>{
      dohvatiKorisnika()

  }, [])

  async function promjena(korisnik){
    const odgovor = await KorisnikService.promjena(routeParams.id,korisnik);
    if(odgovor.greska){
        alert(odgovor.poruka);
        return;
    }
    navigate(RouteNames.KORISNIK_PREGLED)
    
}
    
    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
        let podaci = new FormData(e.target)
        promjena({
          ime: podaci.get('ime'),
          prezime: podaci.get('prezime'),
          brojMob: podaci.get('brojMob'),
          email: podaci.get('email'),
          lozinka: podaci.get('lozinka')


      })
  }  

  




    return(
        <>
        <h2 className="naslov roboto-light">Promjeni korisnika</h2>
        <Form onSubmit={obradiSubmit}>

      <Form.Group className="mb-3" controlId="ime">
        <Form.Label>Unesite ime korisnika:</Form.Label>
        <Form.Control type="text" minLength={2} maxLength={20} name="ime"  placeholder="Pero"  required
        defaultValue={korisnik.ime}  />
      </Form.Group>

      <Form.Group className="mb-3" controlId="prezime">
        <Form.Label>Unesite prezime korisnika:</Form.Label>
        <Form.Control type="text" minLength={2} maxLength={20} name="prezime" placeholder="Perić" required
        defaultValue={korisnik.prezime}/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="brojMob">
        <Form.Label>Unesite kontakt broj korisnika:</Form.Label>
        <Form.Control type="text" name="brojMob" placeholder="+38596258741" required
        defaultValue={korisnik.brojMob}/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="email">
        <Form.Label>Unesite email korisnika:</Form.Label>
        <Form.Control type="text" name="email" placeholder="mail@example.com"
        defaultValue={korisnik.mail}/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="lozinka">
        <Form.Label>Unesite lozinku:</Form.Label>
        <Form.Control type="password" name="lozinka" placeholder="******" required
        defaultValue={korisnik.lozinka}/>
      </Form.Group>


      
        <Row>
            <Col>
            <Link to={RouteNames.KORISNIK_PREGLED}
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col>
            <Button variant="success"
            type="submit"
            className="siroko">Promjeni korisnika</Button>
            </Col>

        </Row>
        </Form>
        </>
    )
    
}