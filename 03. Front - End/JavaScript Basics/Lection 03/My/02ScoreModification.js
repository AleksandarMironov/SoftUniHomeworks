'use strict';

function ScoreModification (arr) {
    var filteredArr = arr.filter(function (element){
        if (element >= 0 && element <= 400){
            return true;
        }
    });
    for (var i = 0; i<filteredArr.length; i++){
        filteredArr[i] = filteredArr[i] - (20.0 / 100) * filteredArr[i];
    }
    filteredArr = filteredArr.sort(function sorting (a,b) {
        return a>b;
    });

    console.log(filteredArr);
}


ScoreModification([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);