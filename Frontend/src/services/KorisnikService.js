import { HttpService } from "./HttpService";


async function get () {

    return await HttpService.get('/Korisnik')
    .then ((odgovor)=>{
        console.log(odgovor)
    })
    .catch((e)=>console.log(e))

}

export default {
    get
}