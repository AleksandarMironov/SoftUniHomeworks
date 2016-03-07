function CalcArea(r) {
    var area = r * r * Math.PI;
    return area;
}

var r = 7;
var area = CalcArea(r);
document.write("<p>r = " + r + "; area = " + area + "</p>");

r = 1.5;
area = CalcArea(r);
document.write("<p>r = " + r + "; area = " + area + "</p>");

r = 20;
area = CalcArea(r);
document.write("<p>r = " + r + "; area = " + area + "</p>");
