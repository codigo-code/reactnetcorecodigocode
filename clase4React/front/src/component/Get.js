import React, { useEffect, useState, Fragment } from 'react';
import Axios from 'axios';

const GetInfo = () => {
    const [res, setRes] = useState('');
    useEffect(async () => {
        const response = await Axios.get('https://swapi.dev/api/people/1/');
        setRes(response.data);
    }, []);


    return (
        <Fragment>
            {res.name}
        </Fragment>
    );
}



export default GetInfo;