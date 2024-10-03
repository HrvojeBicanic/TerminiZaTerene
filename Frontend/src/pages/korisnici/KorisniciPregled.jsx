
import { useEffect } from "react"
import KorisnikService from "../../services/KorisnikService"



export default function KorisniciPregled() {

    async function dohvatiKorisnike(){
        await KorisnikService.get()
    }
    
    useEffect(()=>{
        dohvatiKorisnike()

    }, [])

    return(
        <>
        Ovdje će doći pregled korsnika
        </>
    )
    
}