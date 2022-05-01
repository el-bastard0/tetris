#!/bin/bash

project='./src/app/ElBastard0.Tetris.csproj'

dotnet restore $project
dotnet msbuild -t:PublishAllRids $project