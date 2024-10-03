import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarTermini from './components/NavBarTermini';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constant';
import Pocetna from './pages/Pocetna';
import KorisniciPregled from './pages/korisnici/KorisniciPregled';


function App(){


  return (

    


    <>
    <Container>
      <NavBarTermini/>
    
        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna/>} />

          <Route path={RouteNames.KORISNIK_PREGLED} element={<KorisniciPregled/>} />

        </Routes>
        <hr/>

        &copy; cholakEEs
        </Container>

     
    </>
  )
}

export default App
