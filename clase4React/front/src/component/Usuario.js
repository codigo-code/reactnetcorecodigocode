import React, { useState, useContext } from 'react';
import ThemeContext from './../App';
import UContext from './UContext';

// hooks
const Usuario = (props) => {

    const [pass, setPass] = useState('abc123');
    const objContexto = useContext(UContext);
    return (
        <div>

            <h2>Usuario : {props.nombre}</h2>
            <h3>pass: {pass}</h3>
            <button onClick={() => {
                setPass('NuevaPassword123');
            }}>cambiar passowrd!</button>
            <br />
            <h4 >{objContexto.persona.apellido}</h4>

        </div>
    );
}


export default Usuario;


