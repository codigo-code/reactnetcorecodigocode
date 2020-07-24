import React, { useReducer, Fragment, useState } from 'react';
import Registrar from './registrar';
import Login from './Login';


const Menucito = () => {
    var objInsert = [];
    const [elemento, setElemento] = useState();
    const reducer = (state, action) => {
        switch (action.type) {
            case 'registrar':
                console.log(state);
                objInsert.push(<Registrar />);
                setElemento(objInsert);
                break;

            case 'login':
               
                objInsert.push(<Login />);
                setElemento(objInsert);
                break;
        }

        
    }
    const [state, dispacher] = useReducer(reducer, objInsert);

    return (
        <Fragment>
            <button onClick={() => { dispacher({ type: 'registrar' }) }}>Registrar</button>
            <button onClick={() => { dispacher({ type: 'login' }) }}>Login</button>
            {elemento}
        </Fragment>
    );
}


export default Menucito;