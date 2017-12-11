/// <reference path="jquery-1.12.4.js" />
$(function () {
    $("#btnSubmit").mouseover(function () {
        $("#btnSubmit").css("backgroundColor", "#A9F5BC");
    });
})

$(function () {
    $("#btnSubmit").mouseout(function () {
        $("#btnSubmit").css("backgroundColor", "#ffffff");
    });
})