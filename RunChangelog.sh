#!/bin/bash

echo "Note : point builds(such as 15.2)will not be added to changelog";
echo "Opening changelog.js";
sleep 3
node ./Changelog/changelog.js
