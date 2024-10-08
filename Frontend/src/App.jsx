import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarTermini from './components/NavBarTermini';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constant';
import Pocetna from './pages/Pocetna';
import KorisniciPregled from './pages/korisnici/KorisniciPregled';
import KorisniciDodaj from './pages/korisnici/KorisniciDodaj';


function App(){


  return (

    


    <>
    <Container>
      <NavBarTermini/>
    
        <Routes>
          <Route path={RouteNames.HOME} element={<Pocetna/>} />

          <Route path={RouteNames.KORISNIK_PREGLED} element={<KorisniciPregled/>} />

          <Route path={RouteNames.KORISNIK_NOVI} element={<KorisniciDodaj/>} />

        </Routes>
        <hr/>

        &copy; cholakEEs
        </Container>

     
    </>
  )
}

export default App
