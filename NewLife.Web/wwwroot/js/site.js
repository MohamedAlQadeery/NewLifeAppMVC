// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Shared variables
var table;
var datatable;


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



///Start Loading Indicator for buttons

function AddLoadingIndicatorButton(id) {
    //Submit button
    const submitBtn = document.querySelector(`#${id}`);

    // Handle button click event
    submitBtn.addEventListener("click", function () {
        // Activate indicator
        submitBtn.setAttribute("data-kt-indicator", "on");

    });
}

/// End Loading Indicator for buttons


//Datatable
// Class definition
var KTDatatable = function () {


    // Private functions
    var initDatatable = function () {
        // Set date data order
        const tableRows = table.querySelectorAll('tbody tr');

        tableRows.forEach(row => {
            const dateRow = row.querySelectorAll('td');
            const realDate = moment(dateRow[3].innerHTML, "DD MMM YYYY, LT").format(); // select date from 4th column in table
            dateRow[3].setAttribute('data-order', realDate);
        });

        // Init datatable --- more info on datatables: https://datatables.net/manual/
        datatable = $(table).DataTable({
            "info": false,
            'order': [],
            'pageLength': 10,
            language: {
                url: '//cdn.datatables.net/plug-ins/1.13.3/i18n/ar.json'
            }
        });
    }

    // Hook export buttons
    var exportButtons = () => {
        const documentTitle = 'Customer Orders Report';
        var buttons = new $.fn.dataTable.Buttons(table, {
            buttons: [
                {
                    extend: 'copyHtml5',
                    title: documentTitle
                },
                {
                    extend: 'excelHtml5',
                    title: documentTitle
                },
                {
                    extend: 'csvHtml5',
                    title: documentTitle
                },
                {
                    extend: 'pdfHtml5',
                    title: documentTitle
                }
            ]
        }).container().appendTo($('#kt_datatable_example_buttons'));

        // Hook dropdown menu click event to datatable export buttons
        const exportButtons = document.querySelectorAll('#kt_datatable_example_export_menu [data-kt-export]');
        exportButtons.forEach(exportButton => {
            exportButton.addEventListener('click', e => {
                e.preventDefault();

                // Get clicked export value
                const exportValue = e.target.getAttribute('data-kt-export');
                const target = document.querySelector('.dt-buttons .buttons-' + exportValue);

                // Trigger click event on hidden datatable export buttons
                target.click();
            });
        });
    }

    // Search Datatable --- official docs reference: https://datatables.net/reference/api/search()
    var handleSearchDatatable = () => {
        const filterSearch = document.querySelector('[data-kt-filter="search"]');
        filterSearch.addEventListener('keyup', function (e) {
            datatable.search(e.target.value).draw();
        });
    }

    // Public methods
    return {
        init: function () {
            table = document.querySelector('#kt_datatable_example');

            if (!table) {
                return;
            }

            initDatatable();
            exportButtons();
            handleSearchDatatable();
        }
    };
}();




//start of animation functions
function ApplyRowAnimation(row) {
    row.classList.add('animate__animated', 'animate__bounceInLeft');
    row.addEventListener('animationend', () => {
        row.classList.remove('animate__animated', 'animate__bounceInLeft');

    });
}


//end of animation functions


$(document).ready(function () {
    KTUtil.onDOMContentLoaded(function () {
        KTDatatable.init();
    });



   
});


