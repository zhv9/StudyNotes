function addLoadEvent(func){
    var oldonload = window.onload; // 把现在的onload(可能有绑函数的)赋给oldonload
    if(typeof window.onload != 'function'){
        window.onload = func; // 在没有绑函数的情况下，就用当前传递进来的函数。
    }else{
        oldonload(); // 执行现在的onload(里面可能已经绑了很多个了)
        func(); // 添加传递进来的函数
    }
}