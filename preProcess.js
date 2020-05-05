fs = require('fs')
const path = "../javascript/index.js";
let text = fs.readFileSync(path, 'utf-8');
if (text.includes('Ignore this line do not change!'))
    return;

const subText = text.substring(text.indexOf("Leetcode")).split('\n');

let functionName = '';
for (const t of subText) {
    if (t.includes('function')) {
        const imp = t.split(' ');
        functionName = imp[1];
    }
}

if (functionName) {
    const functionCall = functionName + ';// Ignore this line do not change!\n';
    const idx = text.indexOf('console', text.indexOf("tests"));

    const finalTxt = text.substring(0, idx) + functionCall + text.substring(idx);
    fs.writeFileSync(path, finalTxt);
}
else {
    console.log('FAILED TO PREPROCESS FUNCTION NAME');
}