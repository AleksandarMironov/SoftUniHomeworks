'use strict';

function replaceATag (str){

    str = str.replace(/<\/a>/g, "[/URL]");
    str = str.replace(/<a href=/g, "[URL href=");
    str = str.replace(/>(?=.+\[\/URL\])/g,  "]");

    console.log(str);
}

replaceATag("<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>");
replaceATag("<ul> <li> <a href=http://softuni.bg>SoftUni including numbers 555555 and whitespaces</a> </li> </ul>");