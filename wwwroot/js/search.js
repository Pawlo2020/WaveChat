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
        if(item!=newitem){
            item = newitem
            msgdiv.innerHTML = '<div class="row" align="center" style="width: inherit;"> <div id="col1" class="col"></div> <div id="col2" class="col"></div></div>';

        
            $.ajax({
                type: "Post",
                url: "/Home/SelectConf?ID=" + item,
                contentType: "html",
                success: function(e){
                    document.getElementById("convHeader").innerText = person;
                }
            })
        }
    })
})
var item;

