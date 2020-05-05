fs = require('fs')
const clipboardy = require('clipboardy');

let text = fs.readFileSync("../javascript/index.js", 'utf-8');

const idx = text.indexOf("tests")
if(idx === -1)
throw 'BADDD idx';

text = text.substring(0, idx);
    // console.log(text);


clipboardy.writeSync(text);
console.log("FILE COPIED");

