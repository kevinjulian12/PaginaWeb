// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.webshims.polyfill();

function login(valor) {

    var email = document.getElementById('emailLogin').values;

    var mail = valor.emailLogin;
    var clave = document.getElementById('clave').values;

      //  $email = trim($_POST['email']);
       // $upass = trim($_POST['pass']);
    if (mail.values == "kevin") {
        alert("error de email");
    }


}

