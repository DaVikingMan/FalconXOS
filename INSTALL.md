### This file tells how to install FalconXOS

There is currently no installer available for FalconXOS

You will have to clone the repostiory by

`git clone https://github.com/DaVikingMan/FalconXOS.git`

And either run,

`dotnet run`

or if you have git bash(or any other bash port)
`./start.sh`(in the 'Shell' folder)

Note : There is currently an issue that running FalconXOS in git bash gives an error.
For Windows users, it is recommended to run FalconXOS with powershell or cmd

to run FalconXOS

Installers for FalconXOS will be available between version .70 and 1.0

Note : 'dotnet run' will only work when you are in the main(FalconXOS) folder.
If you are in FalconXOS/src or in other folders, it will not work

If you are in any other folders which is in FalconXOS, you will need to run
'dotnet run --project path_of_project'
