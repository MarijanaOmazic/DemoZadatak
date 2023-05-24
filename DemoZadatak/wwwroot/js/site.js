// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    var PopUpModal = $('#popUp');
    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url);

        $.get(decodedUrl).done(function (data) {
            PopUpModal.html(data);
            PopUpModal.find('.modal').modal('show');
        })
    })
})
function CloseModalPopUp() {
    $("#popUp").modal('hide');
}