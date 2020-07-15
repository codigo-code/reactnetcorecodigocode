import React from 'react';
import './App.css';
import Usuario from './component/Usuario';
import ImagenUsuario from './component/ImagenUsuario';
import UContext from './component/UContext';
import MostrarDescripcion from './component/MostrarDescripcion';
import Get from './component/Get';

const themes = {
  light: {
    foreground: "#000000",
    background: "#eeeeee"
  },
  dark: {
    foreground: "#ffffff",
    background: "#222222"
  }
};

const objMagico = {
  persona: {
    nombre: 'dante',
    apellido: 'panella'
  },
  deporte: 'hockey'
}


function App() {
  return (
    <UContext.Provider value={objMagico}>
      <div className="App">
        <Usuario nombre="lucas"></Usuario>
        <br />
        <ImagenUsuario activo="activo"></ImagenUsuario>
        <br />
        <MostrarDescripcion callback={() => {
          console.log('valor');
        }}></MostrarDescripcion>
        <br />
        <Get></Get>
      </div>
    </UContext.Provider>
  );
}

export default App;
