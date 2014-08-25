
@echo off
set MSBUILD=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe
%MSBUILD% MonoDevelop.DocFood.FSharp\MonoDevelop.DocFood.FSharp.windows.fsproj /p:Configuration=Release
set MDROOT="C:\Program Files (x86)\Xamarin Studio"
rmdir /s /q pack
mkdir pack\windows\Release
%MDROOT%\bin\mdtool.exe setup pack bin\windows\Release\MonoDevelop.DocFood.FSharp -d:pack\windows\Release
%MDROOT%\bin\mdtool.exe setup install -y pack\windows\Release\MonoDevelop.DocFood.FSharp_0.0.1.mpack 
