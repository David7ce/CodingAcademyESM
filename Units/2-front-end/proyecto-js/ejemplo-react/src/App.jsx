import './App.css'
import Header from './Header'
import Contador from './Contador'
import BarraMenu from './BarraMenu'
import {QRCodeSVG} from 'qrcode.react'
import datos from 'data/cosas.json'

function App() {
  const texto1 = "Botón 1"
  return (
    <div>
      <Header />
      <QRCodeSVG value="https://reactjs.org/" />
      <Contador />
      <BarraMenu
        nombre="hola"
        elementos={[1, 2, 3, 4, 5]} />
      <BarraMenu
        nombre="hola"
        elementos={["cosa", "otra cosa"]} />
    </div>
  )
}

export default App
