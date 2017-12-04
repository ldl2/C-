#!/bin/bash
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Tools -v=2.0
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet -v=2.0
dotnet add package Pomel.EntityFrameworkCore.MySql
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions -v=2.0
cp -r /home/eric/programming/C#/addef/templates/* ./
dotnet restore

