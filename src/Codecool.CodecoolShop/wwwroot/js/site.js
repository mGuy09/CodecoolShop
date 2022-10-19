// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const supplierId = document.querySelector("#supplier-filter");
const productsDiv = document.querySelector("#products").children;
const cartButton = document.querySelector("#cart");

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