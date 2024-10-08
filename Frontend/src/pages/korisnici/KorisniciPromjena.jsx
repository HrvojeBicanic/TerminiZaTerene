import { Link, useNavigate } from "react-router-dom"
import KorisnikService from "../../services/KorisnikService"
import { Button, Row, Col, Form} from "react-bootstrap"
import { RouteNames } from "../../constant"
import { useState } from "react"



export default function KorisniciPromjena() {

    const Navigate = useNavigate() 

    
    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
    }  




    return(
        <>
        <h2 className="naslov roboto-light">Dodaj korisnika</h2>
        <Form onSubmit={obradiSubmit}>

      <Form.Group className="mb-3" controlId="ime">
        <Form.Label>Unesite ime korisnika:</Form.Label>
        <Form.Control type="text" minLength={2} maxLength={20} ime="naziv"  placeholder="Pero"  required  />
      </Form.Group>

      <Form.Group className="mb-3" controlId="prezime">
        <Form.Label>Unesite prezime korisnika:</Form.Label>
        <Form.Control type="text" minLength={2} maxLength={20} name="prezime" placeholder="Perić" required/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="brojMob">
        <Form.Label>Unesite kontakt broj korisnika:</Form.Label>
        <Form.Control type="text" name="brojMob" placeholder="+38596258741" required/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="email">
        <Form.Label>Unesite email korisnika:</Form.Label>
        <Form.Control type="text" name="email" placeholder="mail@example.com"/>
      </Form.Group>

      <Form.Group className="mb-3" controlId="lozinka">
        <Form.Label>Unesite lozinku:</Form.Label>
        <Form.Control type="password" name="lozinka" placeholder="******" required/>
      </Form.Group>


      
        <Row>
            <Col>
            <Link to={RouteNames.KORISNIK_PREGLED}
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col>
            <Button variant="success"
            type="submit"
            className="siroko">Dodaj korisnika</Button>
            </Col>

        </Row>
        </Form>
        </>
    )
    
}