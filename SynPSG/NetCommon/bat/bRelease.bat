@echo off
setlocal
rem
rem Bukld the Release version of the .NET wrappers
rem

rem *************************************************************
rem We want to build te released version
rem *************************************************************

set CONFIGURATION=Release

call C:\Development\SynPSG\NetCommon\bat\build.bat
endlocal
