const { stdin, stdout } = require('process');
const readline = require('readline');

Main();
function Main()
{
    console.log("Falcon version : -.16.2\nExternal version : /4\nOverall version : .16.2.4");

    console.log('\nv/4');
    var r = readline.createInterface({
         input : stdin,
         output : stdout
    });
    r.question('$ ', (response) =>
    {
        if(response == "v/4")
        {
            console.log("The changelog is as follows:");
            console.log('Fixed the error where changelog.js infinitely executed');
            console.log("Moved all files in src to the 'UFT' folder");
            console.log("Moved changelog.js and added devchangelog.js");
            console.log("Added start.sh script for git bash(or other bash ports)");
            console.log('\nDate added : 26/8/2021');

            console.log('\n\nEnd of File');
            console.log('Type /exit');
            r.question('\\ ', (response) =>
            {
                if(response == "/exit")
                {
                    process.exit();
                }
            })

            

        }
    })
}