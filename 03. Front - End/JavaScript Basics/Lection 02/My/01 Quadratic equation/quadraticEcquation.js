function myFunction(statement) {
    if (statement != null && statement.toString().length>0) {
        var inputArr = statement.trim().split(' ');
        var a = Number(inputArr[0]);
        var b = Number(inputArr[1]);
        var c = Number(inputArr[2]);
        var output = "";
        var d = b * b - 4 * a * c;
        var answer1 = 0;
        var answer2 = 0;

        if (d>0) {
            answer1 = (-b + Math.sqrt(d))/(2*a);
            answer2 = (-b - Math.sqrt(d))/(2*a);
            output = 'X1= ' + answer1 + '\nX2= ' + answer2;
        }

        if (d === 0){
            answer1 = (-b /(2*a));
            output = 'X= ' + answer1;
        }

        if (d<0){
            output = 'No real rots';
        }

        document.getElementById('result').innerHTML = output ;
    } else {
        document.getElementById('result').innerHTML = 'There is no values.';
    }

}