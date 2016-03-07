function calcSupply(statement) {
    if (statement != null && statement.toString().length>0) {
        var input = statement.trim().split(" ");
        var age = Number(input[0]);
        var maxAge = Number(input[1]);
        var foodPerDay = Number(input[input.length-1]);
        var food = input[2].toString();
        if (input.length > 4) {
            for (var i = 3; i < input.length - 1; i++) {
                food = food + " " + input[i];
            }
        }
        var amount  = (maxAge - age) * 365 * foodPerDay ;
        var output = amount + " kg of " + food + " would be enough until I am " + maxAge + " years old.";


        document.getElementById('result').innerHTML = output ;
    } else {
        document.getElementById('result').innerHTML = 'There is no values.';
    }

}