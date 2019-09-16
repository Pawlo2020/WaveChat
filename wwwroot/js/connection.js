var textbox = document.getElementById("inlineFormInputName");
//var textarea = document.getElementById("exampleFormControlTextarea1");
var msgdiv = document.getElementById("msglist");
//var webSocket = new WebSocket('ws://192.168.0.100:90/ws');
var webSocket = new WebSocket('wss://localhost:44391/ws');
var monthsArray = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

//Initialize function
function _init(){
    $('.toast').toast('show');
    $("#sendForm").submit(function(e){
        e.preventDefault();

        $.ajax({
            url: "/Home/SendMessageT",
            type: 'POST',
            data: { value: $('#inlineFormInputName').val() },
            success: function () {
                $('#inlineFormInputName').val('')
            },
            error: function () {
                alert("error");
            }
        }); 
        return false;
    });
    //Load();
}

//Load all messages from conversation
function Load() {
    $.ajax({
        url: "/Home/LoadMessages",
        method: 'GET'
    });
}

//Instantiate single toast message
function instantiateToast(content) {

    var msg = JSON.parse(content);   
    console.log(msg[0]["Timestamp"]);
    
    for (let index = 0; index < msg.length; index++) {
        newDiv = document.createElement("div");

        newDiv.setAttribute("class", "toast");
        newDiv.setAttribute("role", "alert");
        newDiv.setAttribute("aria-live", "assertive");
        newDiv.setAttribute("aria-atomic", "true");
        newDiv.setAttribute("data-autohide", "false");

        newDiv.innerHTML = '<div class="toast-header" style="background-image: linear-gradient(40deg,#ff6ec4,#7873f5);"><i class="fas fa-user"></i><span style="width: 5px;"></span> <strong style="color: white;" class="mr-auto">' + msg[index]["FirstName"] + " " + msg[index]["LastName"] + '</strong><small style="color: white">' + msg[index]["Timestamp"] + '</small></div><div class="toast-body" style="background-color: #786fa6;"><span style="color: white; word-wrap: break-word;">' + msg[index]["Message"]  + '</span></div>';
        
        msgdiv.appendChild(newDiv);
        $(newDiv).toast('show');
        msgdiv.scrollTop = msgdiv.scrollHeight;
    };
}

//On open WebSocket event
webSocket.onopen = function(event){
    webSocket.send(getId());
}

//On receive message WebSocket event
webSocket.onmessage = function (event) {
    instantiateToast(event.data);
  }

//On error WebSocket event
webSocket.onerror = function(event){
    console.log('Socket Error');
}