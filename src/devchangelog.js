const { Console } = require('console');
const { stdin, stdout, mainModule } = require('process');
const readline = require('readline');

Main();
function Main()
{

    console.clear();
    console.log("Falcon version : -.21.19\nExternal version : /4\nOverall version : .21.19.9");

    console.log('\nversion.16.2');
    console.log('\nversion.19.4');
    console.log("\nversion.21.19");
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
                    if(answer == "Exit")
								{
									Main();
								}else
								{
									console.log("Wrong command : default action is exit");
									Main();
								}

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

					if(answer == "Exit")
					{
						Main();
					}else
					{
						console.log("Wrong command : default action is exit");
						Main();
					}

			    })
	    }else if(response == ".21.19" || response == "-ch=v+21.19")
	    {
		    console.log("This was a big release and many features were added");
		    console.log("Some of them were : ");
		    console.log("Added TermLib, the custom library which will used by FalconXOS's UFT");
		    console.log("Added Inputstream");
		    console.log("Added Devconsole\n     Added commands : view news\n    Added write::input for manually writing to inputstream");
		    console.log("Plan the format of .config files");
		    console.log("Added Inputstream components");
		    console.log("Added new errors");
		    console.log("Added Devconsole errors");
		    console.log("Enhance the error system");
		    console.log("Simplify code");
		    console.log("Fixed many bugs\n     FalconXOS unable to start");
		    console.log("Fix Documentation\n    Make the README more better\n    Update the security policy\n    Add a code of conduct and contributing guidelines\n    Removed unused documenation");
		    console.log("Added new commands\n    /Exit\n    /Start and --dev");
		    console.log("Implement the error system in more parts of FalconXOS's UFT");
		    console.log("Added -sh commands for almost all commands");
		    console.log("Make UFT more user-friendly");
		    console.log("Remove unused workflows");
		    console.log("Update the system requirements");
		    console.log("Added config console");
		    console.log("Start developement of config console and .config files");
		    console.log("Started developement of permanent input streams");
		    
		     r.question('Exit?', (answer) =>
                            {
								if(answer == "Exit")
								{
									Main();
								}else
								{
									console.log("Wrong command : default action is exit");
									Main();
								}

                                    

                            })

	    }
	    else if(response == "Exit" || response == "exit")
        {
            process.exit(0);
        }else
		{
			Main();
		}

    })
}
