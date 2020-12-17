// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Funcion Abrir modal formulario para registrar nuevos usuarios


//Delete
$(".btnDelete").click(function (eve) {
    var xId = $(this).data("id");    

    $(".btnConfir").click(function (eve) {  
        //Se dirije al controlador
        $(".modal-content").load("../User/DeleteUser/" + xId);       

        //Oculta el modal y muestra los usuarios existentes
        $("#DeleteConfirmation").modal("hide");
        
        setTimeout("location.href='/User/RegisteredUsers'", 1000);
    });

});
