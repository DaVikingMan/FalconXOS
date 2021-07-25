const { stdin, stdout } = require('process');
const read = require('readline');

var r = read.createInterface({
    input : stdin,
    output : stdout
});

console.log("Release v.14\n\n");
console.log("The changelog is as follows : ");

console.log("Added QuickRun and removed Run");
console.log(
    "Added changelog"
);
console.log("Added Debug.js\n\n");

console.log("About QuickRun : ");
console.log(
    "QuickRun is a replacement to 'Run' command which existed before in FalconXOS"
);
console.log("You can run any runnable files with QuickRun\nIt can be accessed by typing 'run' in the menu");
console.log("\nAbout Debug.js\nDebug.js is used to run javascript programs");
console.log("It is the same as Test.cs but can run js projects");
console.log("\n\nAbout Changelog : ");
console.log("It is used to view the changelog of the versions of FalconXOS");
console.log("\n\nKnown issues : ");
console.log("js files can only be exited by ctrl+c\n\n");
console.log("\n\nEnd of file, Type 'ctrl+c' to exit");
r.question('', (answer) =>
{
    
})

