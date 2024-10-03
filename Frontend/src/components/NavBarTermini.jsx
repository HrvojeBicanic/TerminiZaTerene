import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { useNavigate } from 'react-router-dom';
import { RouteNames } from '../constant';


export default function NavBarTermini() {

    const navigate = useNavigate() 

    return(
        <>
        <Navbar expand="lg" className="bg-body-tertiary">
          
          <Navbar.Brand className='ruka'
          onClick={()=>navigate(RouteNames.HOME)}
          >Termini</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              <Nav.Link href="https://cholakees-001-site1.dtempurl.com/swagger/index.html" 
              target='_blank' >Swagger</Nav.Link>
              
              <NavDropdown title="Programi" id="basic-nav-dropdown">
                <NavDropdown.Item 

                onClick={()=>navigate(RouteNames.KORISNIK_PREGLED)}

                >Korisnici</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.2">
                  Tereni
                </NavDropdown.Item>
                <NavDropdown.Item href="#action/3.3">Termini</NavDropdown.Item>
                
                
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        
      </Navbar>
        
        
        </>
    )

    


}