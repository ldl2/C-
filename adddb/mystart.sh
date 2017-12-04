#!/bin/bash
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions -v=2.0
dotnet add package MySql.Data -v=8.0.9-dmr

cp -r /home/eric/programming/C#/adddb/templates/* ./
dotnet restore