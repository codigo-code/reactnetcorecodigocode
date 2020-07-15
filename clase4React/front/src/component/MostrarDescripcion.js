import React, { Fragment, useState } from 'react';
import './../App';

const MostrarDescripcion = ({ callback },props) => {



    return (
        <Fragment>
            <button onClick={() => {
                callback();
            }}>Apretame</button>
            
        </Fragment>
    );
}

export default MostrarDescripcion;

