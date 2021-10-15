#!/bin/bash

echo "FalconXOS-GNU/Linux :: version.21.19" # Print this text
echo "Developement number : std::<<<<1.9>>>>"
echo "Dotnet version  $(dotnet --version)"
echo "Nodejs version $(node --version)"
echo "Java version :  $(java --version)"
sleep 3
dotnet run --project ..
