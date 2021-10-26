@Echo off
echo Starting installer : chocolatey is the default package manager for installing packages, if you want to use another package manager like winget specify it in this file before running it
echo Installing packages which are required to run FalconXOS
choco install dotnet
choco install openjdk
choco install nodejs
echo "Complete!"
