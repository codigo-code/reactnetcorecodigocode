import React, { useEffect, useState, Fragment, useRef } from 'react';
import axios from 'axios';

const Usuario = () => {

    const [obj, setObj] = useState('');
    const [inpNom, setInpNom] = useState('');
    const [inpPass, setInpPass] = useState('');
    useEffect(async () => {
        const res = await axios.get('https://localhost:5001/Usuario');
        setObj(res.data);
        console.log(res.data);
    }, []);

    const img = useRef(null);

    return (
        <Fragment>
            <h3>Ingrese al sitio! loggeese!</h3>

            <input type="text" onChange={(e) => {
                setInpNom(e.target.value);
            }} placeholder="ingrese su nombre de usuario " /> <br />

            <input type="password"
                onChange={(e) => {
                    setInpPass(e.target.value);
                }} placeholder="ingrese su password" />
            <br />

            <button onClick={() => {
                if (obj.nombre === inpNom && obj.password === inpPass) {
                    console.log('entro!');
                    img.current.src = obj.imagenUsuario;
                    
                } else {
                    img.current.src = 'https://thumbs.dreamstime.com/z/rectangular-sign-board-text-access-denied-white-red-grunge-letters-respectively-white-background-access-denied-107177865.jpg';
                    console.log('usuario o contraseña invalida')
                }

            }}>Validar</button>
            <br />
            <button onClick={() => {                         // body 
                axios.post('https://localhost:5001/Usuario', { nombre: inpNom, password: inpPass })
                    .then(ok => { console.log(ok); })
                    .catch(err => {
                        console.error(err);
                    });
            }}>Guardar </button>
            <br /> <img ref={img} alt="" />
        </Fragment>
    );
}

export default Usuario;