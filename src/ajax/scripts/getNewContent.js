function getNewContent() {
    var request = getHTTPObject();
    if(request){
        request.open("GET", "example.txt", true);
        request.onreadystatechange = function(){
            if(request.readyStage == 4){
                var para = document.createElement("p");
                var text = document.createTextNode(request.responseText);
                para.appendChild(text);
                document.getElementById('new').appendChild(para);
            }
        };
        request.send(null);
    }else{
        alert('浏览器不支持XMLHttpRequest');
    }
}
addLoadEvent(getNewContent);