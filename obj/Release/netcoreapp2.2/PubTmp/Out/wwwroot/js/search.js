$(document).ready(function () {

    $("#searchBox").keyup(function () {
        var searchtext = $(this).val();
        document.getElementById("searchBar").innerHTML ='';
        $.ajax({
            type: "Post",
            url: "/Home/SearchContainer?Person=" + searchtext,
            contentType: "html",
            success: function (response) {
                console.log(response);
                document.getElementById("searchBar").innerHTML ='';
                document.getElementById("searchBar").innerHTML = response;

            },
            error: function (err) {
                alert(err.responseText);
            }

        })

    })

    var item;

    $(document).on('click', '.perItem', function() {
        var newitem = $(this).attr("id");
        if(item!=newitem){
            item = newitem
            msgdiv.innerHTML = '';
            $.ajax({
                type: "Post",
                url: "/Home/SelectConf?ID=" + item,
                contentType: "html",
                success: function(e){
                }
            })
        }


        
    })

})