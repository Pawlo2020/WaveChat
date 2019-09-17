$(document).ready(function () {

    $("#searchBox").keyup(function () {
        if($("#searchBox").val()){
            var searchtext = $(this).val();
            document.getElementById("searchBar").innerHTML ='';

            $.ajax({
                type: "Post",
                url: "/Home/SearchContainer?Person=" + searchtext,
                contentType: "html",
                success: function (response) {
                    console.log(response);
                    document.getElementById("searchBar").innerHTML = response;
                },
                error: function (err) {
                    alert(err.responseText);
                }
            })
        }else{
            document.getElementById("searchBar").innerHTML ='';
    }
})

    $(document).on('click', '.perItem', function() {
        var newitem = $(this).attr("id");
        var person = $(this).children('#choosedPerson').text();
        debugger
        if(item!=newitem){
            item = newitem
            msgdiv.innerHTML = '';
            $.ajax({
                type: "Post",
                url: "/Home/SelectConf?ID=" + item,
                contentType: "html",
                success: function(e){
                    document.getElementById("convHeader").innerText = person;
                    document.getElementById("#searchBox").innerText = '';
                }
            })
        }
    })
})
var item;