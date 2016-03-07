function calc(expression) {
    if (expression !== null && expression !== undefined && expression.toString().length>0) {
        expression = expression.replace(/[^0-9\-+*/()%|&^><!~]/g, '');
        document.getElementById('result').innerHTML = eval(expression);
    } else {
        document.getElementById('result').innerHTML = 'There is no expression.';
    }

}

calc("7+8*5");