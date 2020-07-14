import React, { useState, useEffect, Fragment } from 'react';
import Axios from 'axios';


const HistorialUsuario = () => {
    const [resultado, setResultado] = useState('');
    // carga inicial
    useEffect(async () => {
        const response = await Axios.get('https://swapi.dev/api/people/1/');
        setResultado(response.data);
    }, []);

    return (
        <Fragment>
            <h3>Historial del usuario </h3>
            <h4>{resultado.name} , {resultado.mass} , {resultado.hair_color}</h4>
        </Fragment>
    );
}


export default HistorialUsuario;
