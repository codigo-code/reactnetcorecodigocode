const tmp = document.createElement('template');

tmp.innerHTML = `
    <h1>Elemento desde javascript</h1>
    <input placeholder="ingrese su nombre" />
    <br />
    <button> mostrar </button>
 `;


class SaludoInput extends HTMLElement {

    constructor() {
        super();
        //attachShadow --> la forma de pintar un template recicable en las paginas html
        this._shadowRoot = this.attachShadow({ 'mode': 'open' });

        // appendChile agregamos a la pagina html mediante un tag lo que tengamos en el template
        this._shadowRoot.appendChild(tmp.content.cloneNode(true));

        //querySelector , recorremos todos los elementos y nos fijamos cual sea de tipo input *ATENCION* solo funciona bien si tenemos un solo input , sino hay queusar un getElementById
        var inp = this._shadowRoot.querySelector('input');

        // obtengo el button 
        var btn = this._shadowRoot.querySelector('button');

        // getAttribute ejemplo tag <saludo-input nombre="lucas" > recuperamos el valor del atributo en esta caso nombre
        var nombre = this.getAttribute("nombre");

        // inp --> input le inyectamos el valor nombre , por medio de su value 
        inp.value = nombre;

        // agrego funcionalidad al boton
        btn.addEventListener('click', () => {
            alert(inp.value);
        })

        // console.log --> mostramos por la consola
        console.log('El valor del atributo nombre --> ' + nombre);
    }
}

window.customElements.define('saludo-input', SaludoInput);
