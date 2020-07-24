import React, { Fragment, useState } from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';
import axios from 'axios';


const Login = () => {

    const validar = (e) => {
        e.preventDefault();
        // const headers = {
        //     'Content-Type': 'text/json'
        // }; // java

        // para resolverlo con Express ( node)
        // axios.defaults.baseURL = 'http://localhost:3000/';
        // axios.defaults.headers.post['Content-Type'] = 'application/json;charset=utf-8';
        // axios.defaults.headers.post['Access-Control-Allow-Origin'] = '*';

        axios.post('https://localhost:5001/Usuario/checkUser', {
            nombre: nombre_inp,
            password: password_inp

        }).then(data => {
            console.log(data.data);
            let objData = data.data;
            if (objData.token !== null){
                window.location.href = 'http://localhost:3000/productos?token='+objData.token;
            }

        });
    }
    const [nombre_inp, setNombre] = useState(); // <---
    const [password_inp, setPass] = useState();    // <---

    return (
        <Fragment>
            <Segment inverted>
                <Form inverted onSubmit={validar}>
                    <Form.Group widths='equal'>
                        <Form.Input onChange={(e) => {
                            setNombre(e.target.value);
                        }} fluid label='First name' placeholder='First name' />
                        <Form.Input onChange={(e) => {
                            setPass(e.target.value);
                        }} fluid label='Last name' placeholder='Last name' />
                    </Form.Group>
                    <Form.Checkbox label='I agree to the Terms and Conditions' />
                    <Button type='submit'>Submit</Button>
                </Form>
            </Segment>
        </Fragment>
    );
}

export default Login;