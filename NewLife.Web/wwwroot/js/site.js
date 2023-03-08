// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const logoutBtn = document.querySelector('#logout-btn');

logoutBtn.addEventListener('click', function (e) {
    e.preventDefault();
    document.querySelector('#logout-form').submit();

})


//Start of toastr Messages
toastr.options = {
    "progressBar": true,
    "positionClass": "toastr-top-center",
    "preventDuplicates": true,
};

function showToastrInfoMessage(message = 'تم الحفظ بنجاح') {
    toastr.info(message);

}



function showToastrErrorMessage(message = 'حدث خطأ في العملية') {
    toastr.error(message);

}

const tmpMessage = document.querySelector('#msg').textContent;
if (tmpMessage != '') {
    showToastrInfoMessage(tmpMessage);
}

