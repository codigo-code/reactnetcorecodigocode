
function calculoIMC() {
    console.log("estoy calculando su imc....");


    // javascript identificamos en el doumento los elementos altura y peso
    /*
        Para identificarlo lo hacemos con el objeto document .  getElementById
    */

    let altura = document.getElementById("altura").value;
    let peso = document.getElementById("peso").value;
    let res = peso / (altura * altura);
    let img = document.getElementById("imagenResultado");

    // condicional del para saber en que estado esta la persona
    console.log("resultado del IMC " + res);
    if (res < 18.5) {
        img.src = "img/skinny.jpg";
    } else if (res >= 18.5 && res <= 24.99) {
        img.src = "img/normal.jpg";
    } else {
        img.src = "img/fat.jpg";
    }
}


//IFEE