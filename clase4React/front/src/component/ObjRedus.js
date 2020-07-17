import React, { useReducer, Fragment, useState } from 'react';
import CardExampleCard from './CardExampleCard';




const ObjRedus = () => {

    const initialCount = { count: 0 };

    const [valor, setValor] = React.useState('');

    const reducer = (state, action) => {

        switch (action.type) {

            case 'ver':
                alert("hola te estoy viendo!");
                setValor('pepe');
                break;
            case 'registrar':

                const vectorCarta = [];
                for (var i = 0; i < 3; i++) {
                    vectorCarta.push(<CardExampleCard nombre={'soy pepe ' + (i+1) } desc={i} descmagia="hola mundo!" />);
                }
                setValor(vectorCarta);

                break;

            default:
                console.log('no paso x estas funciones');
                break;

        }

    }


    const [state, dispatcher] = useReducer(reducer,
        { count: initialCount });


    return (
        <Fragment>

            <button onClick={() => dispatcher({ type: 'ver' })}>Ver</button>
            <button onClick={() => dispatcher({ type: 'registrar' })}>Registrar</button>
            {valor}

        </Fragment>
    );

}


export default ObjRedus;

