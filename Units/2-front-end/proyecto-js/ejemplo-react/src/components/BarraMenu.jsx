import './components/BarraMenu.css'

function BarraMenu(props) {

    return(
        <div className="BarraMenu">
            <h2>{props.nombre}</h2>
            <ul>
                {props.elementos.map(
                    elemento => <li> {elemento} </li>
                )}
            </ul>
        </div>
    )
}

export default BarraMenu