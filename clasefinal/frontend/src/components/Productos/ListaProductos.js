import React, { Fragment } from 'react';



const ListaProducto = (props) => {

    return (
        <Fragment>
            {props.nombre}<br />
            {props.precio}<br />
            <img src={props.imagen} /><br />

        </Fragment>
    );
}

export default ListaProducto;