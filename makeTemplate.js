fs = require('fs')
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});



let text = fs.readFileSync("../javascript/helpers/cc.js", 'utf-8');
text += "//--------------------------------Leetcode below";

text += '\n'.repeat(10);
text += "//--------------------------------tests";
text += '\n'.repeat(4);
text += 'console.log();';

const path = __dirname + '/../javascript/' + 'index.js';
console.log(path);

if (fs.existsSync(path)) {
    rl.question("Do you want to overwrite?????????????????????????????? (y/n)", (answer) => {
        if (answer == 'y')
            fs.writeFileSync(path, text);

        rl.close();
    });
}
else {
    fs.writeFileSync(path, text);
    rl.close();
}