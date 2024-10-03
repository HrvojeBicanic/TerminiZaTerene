import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';


export default function NavBarTermini() {

    return(
        <>
        <Navbar expand="lg" className="bg-body-tertiary">
          
          <Navbar.Brand href="#home">Termini</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              <Nav.Link href="https://cholakees-001-site1.dtempurl.com/swagger/index.html" 
              target='_blank' >Swagger</Nav.Link>
              
              <NavDropdown title="Programi" id="basic-nav-dropdown">
                <NavDropdown.Item href="#action/3.1">Korisnici</NavDropdown.Item>
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