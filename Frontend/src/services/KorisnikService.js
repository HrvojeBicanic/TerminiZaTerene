import { HttpService } from "./HttpService";


async function get () {

    return await HttpService.get('/Korisnik')
    .then ((odgovor)=>{
        //console.log(odgovor.data)
        //console.table(odgovor.data)
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{

    //console.log(e)
    return {greska: true, poruka: 'Problem kod dohvaćanja korisnika'}
    })

}

async function brisanje (id) {

    return await HttpService.delete('/Korisnik/' + id)
    .then ((odgovor)=>{
        //console.log(odgovor.data)
        //console.table(odgovor.data)
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch((e)=>{

    //console.log(e)
    return {greska: true, poruka: 'Problem kod brisanja korisnika'}
    })

}

async function dodaj (korisnik) {

    return await HttpService.post('/Korisnik', korisnik)
    .then ((odgovor)=>{
        return {greska: false, poruka: 'Korisnik dodan'}
    })
    .catch((e)=>{

    //console.log(e)
    return {greska: true, poruka: 'Problem kod dodavanja korisnika'}
    })

}

async function getBySifra (id) {

    return await HttpService.get('/Korisnik/' + id) 
    .then ((odgovor)=>{

        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{

    //console.log(e)
    return {greska: true, poruka: 'Problem kod dohvaćanja korisnka. ID: ' + id}
    })
}



export default {
    get,
    brisanje,
    dodaj,
    getBySifra
}