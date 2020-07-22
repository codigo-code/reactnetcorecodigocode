import React, { Fragment, useState } from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';
import axios from 'axios';


const Login = () => {

    const validar =(e)=>{
        e.preventDefault();

        axios.post('http://localhost:5000/Usuario/checkUser', {
            nombre: nombre_inp,
            password: password_inp
           
        }).then(data => {
            console.log(data);
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