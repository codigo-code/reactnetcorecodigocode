import React, { Fragment, useState, useEffect } from 'react';
import { Button, Checkbox, Form } from 'semantic-ui-react';
import axios from 'axios';


const Registrar = () => {

    const guardar = (e)  => {
        e.preventDefault();

        axios.post('http://localhost:5000/Usuario', {
            nombre: nombre_inp,
            password: password_inp,
            mail:mail_inp
        }).then(data => {
            console.log(data);
        });
    };

    const [nombre_inp, setNombre] = useState(); // <---
    const [password_inp, setPass] = useState();    // <---
    const [mail_inp, setMail] = useState();    // <---


    return (
        <Fragment>
            <Form onSubmit={guardar}>
                <Form.Field>
                    <label>Nombre Usuario</label>
                    <input onChange={(e) => {
                        setNombre(e.target.value);
                    }} placeholder='First Name' />
                </Form.Field>
                <Form.Field>
                    <label>Password</label>
                    <input type="password" onChange={(e) => {
                        setPass(e.target.value);
                    }} placeholder='Last Name' />
                </Form.Field>
                <Form.Field>
                    <label>mail</label>
                    <input type="mail" onChange={(e) => {
                        setMail(e.target.value);
                    }} placeholder='Emai' />
                </Form.Field>
                <Form.Field>
                    <Checkbox label='I agree to the Terms and Conditions' />
                </Form.Field>
                <Button type="submit">Submit</Button>
            </Form>

        </Fragment>
    );
}

export default Registrar;