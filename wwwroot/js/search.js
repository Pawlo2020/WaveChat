$(document).ready(function () {

    $("#searchBox").keyup(function () {
        var searchtext = $(this).val();
        debugger
        $.ajax({

            type: "Post",
            url: "/Home/SearchContainer?Person=" + searchtext,
            contentType: "html",
            success: function (response) {
                console.log('Correct')
                document.getElementById("searchBar").innerHTML = response;

            },
            error: function (err) {
                alert(err.responseText);
            }

        })

    })

})