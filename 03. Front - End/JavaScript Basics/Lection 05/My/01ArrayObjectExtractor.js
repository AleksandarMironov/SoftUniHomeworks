"use strict";

var inputArr = [
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
    ];

var output = [];
function filtering (element, index, array){
    if(Object.prototype.toString.call(element) === "[object Object]"){
        output.push(element);
    }
}
inputArr.forEach(filtering);

console.log (output);