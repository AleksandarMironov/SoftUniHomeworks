"use strict";

function findYoungestPerson(array){
    var output;
    for (var i =0; i<array.length; i++){
        if(array[i].hasSmartphone === true) {
            if (typeof (output) === "undefined"){
                output = array[i];
            }
            if (output.age > array[i].age){
                output = array[i];
            }
        }
    }
    console.log("The youngest person is " + output.firstname + " " + output.lastname);
}


var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }];

findYoungestPerson(people);

///This is not the best code,  but I couldn't figure something better......