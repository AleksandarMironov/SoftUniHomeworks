function countDivs(html) {
    var regex = html.match(/<div/g); //regex is not correct, but I'm not very good with regex....
    var count = regex.length;
    console.log(count);
}


var htmlString = "<!DOCTYPE html> <html> <head lang=\"en\"> <meta charset=\"UTF-8\">" +
    " <title>index</title> <script src=\"/yourScript.js\" " +
    "defer></script> </head> <body> <div id=\"outerDiv\"> <div class=\"first\"> <div><div>hello</div></div> </div>" +
    " <div>hi<div></div></div> <div>I am a div</div> </div> </body> </html>";

countDivs(htmlString);
