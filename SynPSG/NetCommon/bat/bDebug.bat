@echo off
setlocal
rem
rem Bukld the Debug version of the .NET wrappers
rem

rem *************************************************************
rem We want to build te released version
rem *************************************************************

set CONFIGURATION=Debug

call C:\Development\SynPSG\NetCommon\bat\build
endlocal
