$(document).ready(function () {

    $("#searchBox").keyup(function () {
        var searchtext = $(this).val();
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

    $(document).on('click', '.perItem', function() {
        var item = $(this).attr("id");

        $.ajax({
            type: "Post",
            url: "/Home/SelectConf?ID=" + item,
            contentType: "html",
            success: function(e){
                msgdiv.innerHTML = '';
            }
        })
    })

})