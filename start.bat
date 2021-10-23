@Echo off

dotnet build
echo "FalconXOS-Windows Version - .21.19"
dotnet --version
java --version
node --version
dotnet  bin/Debug/net5.0/TerminalMainV.dll
