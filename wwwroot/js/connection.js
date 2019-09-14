var textbox = document.getElementById("inlineFormInputName");
//var textarea = document.getElementById("exampleFormControlTextarea1");
var msgdiv = document.getElementById("msglist");
var webSocket = new WebSocket('ws://192.168.0.100:90/ws');


var month = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

//msgs.on('child_added',function(snapshot){
//    updateChat(snapshot.val());
//})


function Load() {
    $.ajax({
        url: "/Home/LoadMessages",
        method: 'GET'
    });


}



function instantiateToast(msg, name, last){
    //Legacy code
    //textarea.value += msg.msg + "\n";
    //textarea.scrollTop = textarea.scrollHeight;
    //Confidential Legacy
    //var content = msg.msg.split(":", 2);

    newDiv = document.createElement("div");

    newDiv.setAttribute("class", "toast");
    newDiv.setAttribute("role", "alert");
    newDiv.setAttribute("aria-live", "assertive");
    newDiv.setAttribute("aria-atomic", "true");
    newDiv.setAttribute("data-autohide", "false");
    //newDiv.setAttribute("style", "width: " + length + "px;");   
    newDiv.innerHTML = '<div class="toast-header" style="background-image: linear-gradient(40deg,#ff6ec4,#7873f5);"><i class="fas fa-user"></i><span style="width: 5px;"></span> <strong style="color: white;" class="mr-auto">' + name + " " + last + '</strong><small style="color: white">' + msg.Timestamp + '</small></div><div class="toast-body" style="background-color: #786fa6;"><span style="color: white; word-wrap: break-word;">' + msg.Message + '</span></div>';
    
    msgdiv.appendChild(newDiv);
    $(newDiv).toast('show');
    msgdiv.scrollTop = msgdiv.scrollHeight;
    textbox.value = '';
}


function instantiateFAKEToast(content) {

    var msg = JSON.parse(content);

    newDiv = document.createElement("div");

    newDiv.setAttribute("class", "toast");
    newDiv.setAttribute("role", "alert");
    newDiv.setAttribute("aria-live", "assertive");
    newDiv.setAttribute("aria-atomic", "true");
    newDiv.setAttribute("data-autohide", "false");
    //newDiv.setAttribute("style", "width: " + length + "px;");   
    newDiv.innerHTML = '<div class="toast-header" style="background-image: linear-gradient(40deg,#ff6ec4,#7873f5);"><i class="fas fa-user"></i><span style="width: 5px;"></span> <strong style="color: white;" class="mr-auto">' + msg.FirstName + " " + msg.LastName + '</strong><small style="color: white">' + msg.Timestamp + '</small></div><div class="toast-body" style="background-color: #786fa6;"><span style="color: white; word-wrap: break-word;">' + msg.Message + '</span></div>';

    msgdiv.appendChild(newDiv);
    $(newDiv).toast('show');
    msgdiv.scrollTop = msgdiv.scrollHeight;
    textbox.value = '';
}

function updateChat(msg){
    var ref = firebase.database().ref("users/" + msg.GUID).limitToFirst(1);

    ref.on("value", function(snapshot) {
        var childData = snapshot.val();
        var name=childData[Object.keys(childData)[0]].FirstName;
        var last = childData[Object.keys(childData)[0]].LastName;

        instantiateToast(msg, name, last);
    }); 
}

webSocket.onopen = function(event){
    console.log(getId());
    webSocket.send(getId());


}

webSocket.onmessage = function (event) {
    console.log(event.data);
    instantiateFAKEToast(event.data);
  }

  webSocket.onerror = function(event){
      console.log('Socket Error');
  }


// function sendMessage(message) {
//     console.log("Sending: " + message);

//     $.ajax({
//         url: "/Home/sendmessage?message=" + message,
//         method: 'GET'
//     });
// }

  // setInterval(() => {
  //   if (webSocket.bufferedAmount == 0) {
  //     webSocket.send('Hello');
  //   }
  // }, 100);

//Legacy mode
// function SendMessage() {
//     var time = new Date();
//     var message = textbox.value;
//     var usr = getFirstnLastName();
//     var timestamp = time.getDate() + " " + month[time.getMonth()] + " " + time.getFullYear() + " " + time.getHours() + ":" + time.getMinutes();

//     if (/^ *$/.test(textbox.value)) {
//         return;
//     }

//     msgs.push().set({
//         msg: message,
//         usr: usr,
//         timestamp: timestamp 
//     })
//     textbox.value = '';
//   }

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

