import React, { useRef, Fragment } from 'react';

const ImagenUsuario = (props) => {

    const refFoto = useRef(null);

    return (
        <Fragment>
            <img ref={refFoto} alt="fotito!"></img>
            <br />
            <button onClick={() => {
                if (props.activo === "activo") {

                    refFoto.current.src = "https://i.pinimg.com/originals/45/bc/2e/45bc2e15216ccebb108abcb7757e6aed.jpg";
                } else {
                    refFoto.current.src = "https://matthewpury.files.wordpress.com/2013/11/7g10_0211.jpg";
                }
            }}>Cargar Foto Usuario </button>

            


        </Fragment>
    );
}

export default ImagenUsuario;