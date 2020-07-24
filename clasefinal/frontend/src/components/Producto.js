import React, { Fragment, useEffect, useState } from 'react';
import axios from 'axios';
import ListaProducto from './Productos/ListaProductos';




const Productos = () => {

    const [prod, setprod] = useState();
    const [token, setToken] = useState();
    const elm = [];

    //es el constructor mas el componentDidMount de un componente
    useEffect(() => {

        const urlParams = new URLSearchParams(window.location.search);
        const tok = urlParams.get('token');
        console.log(tok);
        setToken(tok);

        if (tok === 'abc123') {
            axios.post('https://localhost:5001/producto', { credencial: tok }).then(data => {
                var callback = data.data;
                console.log(callback.listaProducto);
                
                 callback.listaProducto.forEach(item => elm.push(<ListaProducto nombre={item.nombre} precio={item.precio} imagen={item.imagen} />));
                 setprod(elm);    
            });
            
        } else {
            elm.push('Acceso denegado!');
            setprod(elm);
        }


    }, []);



    return (
        <Fragment>
            {prod}
        </Fragment>
    )
}

export default Productos;