const { stdin, stdout } = require('process');
const readline = require('readline');

var read = readline.createInterface({
    input : stdin,
    output : stdout
});
console.log("Running file ::");
read.question('Exit?', (answer) =>
{
     console.log(answer);
     if(answer == "Exit")
     {
         process.exit(0);
     }
})