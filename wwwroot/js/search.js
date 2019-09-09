$(function () {

    $("#searchBox").keyup(function (e) {
        var n = $("#searchBox").val();
        $.get("/Home/SearchContainer?person=" + n, function (r) {
            //update ui with results
            $("#resultsTable").html(r);
        });

    });

});