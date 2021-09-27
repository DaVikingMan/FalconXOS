const { stdin, stdout, env } = require('process');
const rl = require('readline');
const rh = require('readline');



function MainMethod14()
{
console.clear();

var read = rl.createInterface({
    input : stdin,
    output : stdout,
    terminal : false
});



console.log("Release v.14");
console.log("");
console.log("");
console.log("The changelog is as follows : ");

console.log("Added QuickRun and removed Run");
console.log("Added changelog");
console.log("Added Debug.js");
console.log("");
console.log("");

console.log("About QuickRun : ");
console.log("QuickRun is a replacement to 'Run' command which existed before in FalconXOS");
console.log("You can run any runnable files with QuickRun\nIt can be accessed by typing 'run' in the menu");
console.log("\nAbout Debug.js\nDebug.js is used to run javascript programs");
console.log("It is the same as Test.cs but can run js projects");
console.log("\n\nAbout Changelog : ");
console.log("It is used to view the changelog of the versions of FalconXOS");
console.log("\n\nKnown issues : ");
console.log("js files can only be exited by ctrl+c(this issue has been fixed in .15)\n");
console.log("End of file, Type 'Exit' to exit");

read.question(':', (ghanswer) =>
{
    if(ghanswer == "Exit")
    {
        Method1();
    }else
    {
        MainMethod14();
    }
    
});

}

function MainMethod16()
{
	console.clear();
        console.log(".16 fixed the following:\n\nFixed Changelog");
	console.log("Fixed some errors in documentations");
	console.log("\n\n.16 added the following:");
	console.log("Added VersionOverview to give an overview of the current version");
	console.log("Removed '--access ch' and add RunChangelog.sh to run changelog.js");
	console.log("Added versions on top of start.sh");
	console.log("Made a new branch for different versions :: The Linux-Alpha.15 branch contains Eagle-Eye versions which are stable and Linux-Alpha branch contains Falcon versions which are less stable but gets updates quicker");
	console.log("Added Documentation about update systems 'Every commit:push' and 'Complete:push'");
        console.log("End of Changelog(For version .16.1)");
        var vquestion = rh.createInterface({
              input : stdin,
	      output : stdout,
	      terminal : false
	})
        vquestion.question('Exit?', (answer) =>
		{
			if(answer == "Exit")
			{
                                 Method1();
			}else
			{
				MainMethod16();
			}


		}
	);
}




function MainMethod15()
{
    console.clear();
    var tquestion = rh.createInterface({
        input : stdin,
        output : stdout,
        terminal : false
        
    })
    console.log("v.15 fixed the following : ");
    console.log("It fixed issue 1 where you had to type 'ctrl+c' to exit js files");
    console.log("Now you can type 'Exit'");
    console.log("\n\nThese are some features which were added in this version");
    console.log("Now all version changelogs will be saved in changelog.js in different functions");
    console.log("'--access ch' can now be accessed from the start menu of the UFT");
    console.log("In changelog.js, '>' is replaced with ':'");
    tquestion.question(':', (hjanswer)=>
    {
        if(hjanswer == "Exit")
        {
             Method1();
        }else
        {
            MainMethod14();
        }
        
    });
    
}

function Method1()
{

console.clear();
console.log("The following changelogs are available : ");
console.log("releasev.14");
console.log("releasev.15");
console.log("releasev.16");
console.log("Type the number of the release");
console.log("");

var rkquestion = rl.createInterface({
    input : stdin,
    output : stdout,
    terminal : false
    
});


rkquestion.question(':', (answer) =>
{
  
    if(answer == 14)
    {
	console.clear();    
        MainMethod14();
        
        
    }else if(answer == 15)
    {
	console.clear();
        MainMethod15();
        

    }else if(answer == 16)
	{
		MainMethod16();
	}

    else if(answer == "Exit")
    {
             process.exit(0);      
    }
    else
    {
        Method1();
    }
    
});



}
Method1();
