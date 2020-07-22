import React, { useReducer, Fragment } from 'react';
import Registrar from './registrar';
import Login from './Login';


const Menucito = () => {
    const objInsert = [];
    const reducer = (state, action) => {
        switch (action.type) {
            case 'registrar':

                objInsert.push(<Registrar />);
                break;

            case 'login':
               
                objInsert.push(<Login />);
                break;
        }
    }
    const [state, dispacher] = useReducer(reducer, objInsert);

    return (
        <Fragment>
            <button onClick={() => { dispacher({ type: 'registrar' }) }}>Registrar</button>
            <button onClick={() => { dispacher({ type: 'login' }) }}>Login</button>
            {objInsert}
        </Fragment>
    );
}


export default Menucito;