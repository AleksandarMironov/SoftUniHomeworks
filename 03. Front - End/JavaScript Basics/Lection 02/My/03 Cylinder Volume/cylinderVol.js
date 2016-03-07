function calcCylinderVol(statement) {
    if (statement != null && statement.toString().length>0) {
        statement = statement.replace(/[^0-9\- ]/g, '');
        var input = statement.trim().split(" ");
        var r = Number(input[0]);
        var h = Number(input[1]);
        var volume = Math.PI*r*r*h;
        var output = parseFloat(Math.round(volume * 1000) / 1000).toFixed(3).toString();
        document.getElementById('result').innerHTML = output ;
    } else {
        document.getElementById('result').innerHTML = 'There is no values.';
    }

}