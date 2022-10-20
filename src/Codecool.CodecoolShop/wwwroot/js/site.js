﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const supplierId = document.querySelector("#supplier-filter");
const productsDiv = document.querySelector("#products").children;
const cartButton = document.querySelector("#cart");
const addToCart = document.querySelectorAll(".add-to-cart")

function FilterSuppliers(control) {
    console.log(productsDiv)
        for (var i = 0; i < productsDiv.length; i++) {
        console.log(productsDiv.item(i).dataset.supplierId)
        if (productsDiv.item(i).dataset.supplierId != control.value && control.value != 0) {
            productsDiv.item(i).hidden = true;
        }else
            productsDiv.item(i).hidden = false;
    }
}
function PreviewCart() {
    cartButton.addEventListener("mouse-over", )
}
$('#cart').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var recipient = button.data('whatever') // Extract info from data-* attributes
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    modal.find('.modal-title').text('New message to ' + recipient)
    modal.find('.modal-body input').val(recipient)
})

addToCart.forEach((element) => {
    element.addEventListener("click",(e)=> {
        
    })
})


