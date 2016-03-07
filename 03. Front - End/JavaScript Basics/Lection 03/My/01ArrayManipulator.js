'use strict';

function ArrManipulator (theArray){
        var processedArray = theArray.filter(function(element){
            if(typeof element === 'number' ){
                return true;
            }
        });
    processedArray = processedArray.sort(function(a,b) {
        return a > b;
    });
    console.log('Min number: ' + processedArray[0]);
    console.log('Max number: ' + processedArray[processedArray.length-1]);
    Array.prototype.frequentElement = function(){
        if(this.length == 0){
            return null;
        }
        var tempMap = {};
        var maxElement = this[0];
        var maxCount = 1;
        for(var i = 0; i < this.length; i++)
        {
            var tempElement = this[i];

            if(tempMap[tempElement] == null){
                tempMap[tempElement] = 1;
            }

            else{
                tempMap[tempElement]++;
            }

            if(tempMap[tempElement] > maxCount)
            {
                maxElement = tempElement;
                maxCount = tempMap[tempElement];
            }
        }
        return maxElement;
    }

    console.log("Most frequent number: " + processedArray.frequentElement());
    console.log(processedArray);





}

ArrManipulator (["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]);


