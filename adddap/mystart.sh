#!/bin/bash
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions -v=2.0
dotnet add package MySql.Data -v=8.0.9-dmr
dotnet add package Dapper
cp -r /home/eric/programming/C#/adddap/templates/* ./
dotnet restore