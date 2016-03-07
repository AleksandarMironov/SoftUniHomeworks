"use strict";

function sortLetters(stringInput, booleanInput) {
    var sortedString = stringInput.split('');
    if (booleanInput) {
        sortedString = sortedString.sort(function (s1, s2) {
            var l = s1.toLowerCase(), m = s2.toLowerCase();
            return l === m ? 0 : l > m ? 1 : -1;
        });
    } else {
        sortedString = sortedString.sort(function (s1, s2) {
            var l = s1.toLowerCase(), m = s2.toLowerCase();
            return l === m ? 0 : l < m ? 1 : -1;
        });
    }
    console.log(sortedString);
}

sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);
