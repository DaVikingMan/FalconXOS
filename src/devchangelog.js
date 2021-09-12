const { stdin, stdout } = require('process');
const readline = require('readline');

Main();
function Main()
{
    console.log("Falcon version : -.19.2\nExternal version : /4\nOverall version : .19.4.9");

    console.log('\nversion.16.2');
    console.log('\nversion.19.4');
    var r = readline.createInterface({
         input : stdin,
         output : stdout
    });
    r.question('$ ', (response) =>
    {
        if(response == ".16.2")
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

            

        }else if(response == ".19.4")
	    {
		    console.log('Added components:');
		    console.log('Zero-One of the most important parts of FalconXOS, handles all signals and interactions between all parts of FalconXOS');
		    console.log('Shiro - The error-handler of FalconXOS.\nHandles all errors which occur in FalconXOS');
		    console.log('Gray - Used to interact between all components of FalconXOS to Shiro.This is the most important component of FalconXOS');
		    console.log('Fixed many errors');
		    console.log("Fixed error where running '/Exit' didn't exit FalconXOS");
		    console.log('Added comments for most of the files');
		    console.log('Added "Exit!" and many other signals in ZeroSignal.cs');
		    console.log('Added SignalVerifier for verifying if signals are signed or unsinged');
		    console.log('Added Crow, a sub-component of Zero\nAdded "Crowned" a sub-component of Shiro');
		    console.log('\n\nNote : This release is not complete and will be completed in the next release, .19.8');
		    console.log('After .20 is released, .19.8 will be released to the Eagle-Eye branch');
		    console.log('Exit?');
		    
		    r.question('$', (answer) =>
			    {
				    process.exit(0);
			    })
	    }

    })
}
