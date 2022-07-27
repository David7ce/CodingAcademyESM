import {useState} from 'react'

function Contador(props) {
    const [cuenta, setCuenta] = useState(0)  // crea dos variables con el valor useState(0)
    // const [pelicula, setPelicula] = useState(null)
    // const [usuario, setUsuario] = useState({nombre:"Marce"})
    // const [query, setQuery] = useState("vengadores")

    return (
        <div className="Contador">
            <button onClick={() => setCuenta(cuenta + 1)}>
                El número es {cuenta}
            </button>
        </div>
    )
}

export default Contador
