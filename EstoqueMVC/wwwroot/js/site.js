// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('.Decremento').click(function () {
    var qtd = $('.QTD').text;

    if (qtd <= 0) {

        alert("Não é possivel decrementar Valor menor que zero");
    }
});

