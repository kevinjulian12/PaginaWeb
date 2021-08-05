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

    alert("Formulario Validado...");
}