function DecToHex (decNum){
    var numInHex = decNum.toString(16).toUpperCase();
    alert(numInHex);
}

var inputNum = Number(prompt("Enter a Number"));
DecToHex(inputNum);

