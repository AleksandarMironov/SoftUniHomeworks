function myFunction(statement) {
    if (statement != null && statement.toString().length>0) {
        var output = "";
        var input = Number(statement);
        var converted = input /3.6*1.94384449244;
        output = input + " km/h = " + parseFloat(Math.round(converted * 100) / 100).toFixed(2) + " knots";

        document.getElementById('result').innerHTML = output ;
    } else {
        document.getElementById('result').innerHTML = 'There is no values.';
    }

}