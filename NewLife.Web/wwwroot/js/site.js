// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const logoutBtn = document.querySelector('#logout-btn');

logoutBtn.addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('#logout-form').submit();

})

