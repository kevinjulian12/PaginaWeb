// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.webshims.polyfill();

$(document).ready(function () {
    $("form").submit(function () {
        alert("Formulario Validado...");
        return false;
    });
});

function validarForma(forma) {

    var nombre = forma.nombre;
    if (nombre.values == "" || nombre.value == "Escribir nombre") {
        alert("debes ingresar un nombre");
        nombre.focus();
        nombre.select();
        return false;
    }

    var apellido = forma.apellido;
    if (apellido.values == "" || apellido.value == "Escribir apellido") {
        alert("debes ingresar un apellido");
        nombre.focus();
        nombre.select();
        return false;
    }

    var usuario = forma.usuario;
    if (usuario.value == "" || usuario.value == "Escribir usuario") {
        alert("Debe proporcionar un nombre de usuario");
        usuario.focus();
        usuario.select();
        return false;
    }

    //Validamos el password
    var password = forma.password;
    if (password.value == "" || password.value.length < 3) {
        alert("Debe proporcionar un password al menos de 3 caracteres");
        password.focus();
        password.select();
        return false;
    }
    var generos = forma.genero;
    var radioSeleccionado = false;

    for (i = 0; i < generos.length; i++) {
        if (generos[i].checked) {
            radioSeleccionado = true;
        }
    }
    if (!radioSeleccionado) {
        alert("Debe seleccionar el Genero");
        return false;
    }

    var dia = forma.dia;
    var mes = forma.mes;
    var año = forma.año;
    if (dia.value == "" || mes.value == "" || año.value == "") {
        alert("Debe seleccionar una fecha de nacimiento");
        return false;
    }
}