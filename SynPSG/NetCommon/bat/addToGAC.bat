@echo off
setlocal
rem
rem put known assemblies into the GAC
rem

if "%1" == "" goto showError
if "%2" == "" goto showError

if "%LIBPATH%" NEQ "" goto loaded
if EXIST "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86
if EXIST "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86

:loaded

set CONFIGURATION=

if "%1" == "final" goto final
if "%1" == "debug" set CONFIGURATION=Debug
if "%1" == "Debug" set CONFIGURATION=Debug
if "%1" == "DEBUG" set CONFIGURATION=Debug

if "%1" == "release" set CONFIGURATION=Release
if "%1" == "Release" set CONFIGURATION=Release
if "%1" == "RELEASE" set CONFIGURATION=Release

if "%CONFIGURATION%" == "" goto showError

set NSPACE=%2

if "%2" == "in" set NSPACE=ChronoTrackNetUI
if "%2" == "IN" set NSPACE=ChronoTrackNetUI

if "%2" == "dx" set NSPACE=ChronoTrackNetUIDX
if "%2" == "DX" set NSPACE=ChronoTrackNetUIDX

if "%2" == "ms" set NSPACE=ChronoTrackNetUIMS
if "%2" == "MS" set NSPACE=ChronoTrackNetUIMS

if "%2" == "de" set NSPACE=ChronoTrackNetUIDE
if "%2" == "DE" set NSPACE=ChronoTrackNetUIDE

if "%2" == "all" set NSPACE=ALL
if "%2" == "ALL" set NSPACE=ALL

@echo Adding SynPSGNetCore to the GAC
call gacutil /i C:\Development\SynPSG\Core\VSSolutions\SynPSGNetCore\bin\%CONFIGURATION%\SynPSGNetCore.dll

@echo Adding ChronoTrackNetUICommon to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUICommon\bin\%CONFIGURATION%\ChronoTrackNetUICommon.dll

if "%NSPACE%" == "ChronoTrackNetUI" goto infragistics
if "%NSPACE%" == "ChronoTrackNetUIDX" goto devexpress
if "%NSPACE%" == "ChronoTrackNetUIMS" goto microsoft
if "%NSPACE%" == "ChronoTrackNetUIDE" goto synergy
if "%NSPACE%" == "ALL" goto infragistics

goto showError

:infragistics
@echo Adding ChronoTrackNetUI to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUI\bin\%CONFIGURATION%\ChronoTrackNetUI.dll
if "%NSPACE%" == "ALL" goto devexpress
goto final

:devexpress
@echo Adding ChronoTrackNetUIDX to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDX\bin\%CONFIGURATION%\ChronoTrackNetUIDX.dll
if "%NSPACE%" == "ALL" goto microsoft
goto final

:microsoft
@echo Adding ChronoTrackNetUIMS to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIMS\bin\%CONFIGURATION%\ChronoTrackNetUIMS.dll
goto final

:synergy
@echo Adding ChronoTrackNetUIDE to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDE\bin\%CONFIGURATION%\ChronoTrackNetUIDE.dll
goto final

:final
@echo Adding ChronoTrack to the GAC
call gacutil /i C:\Development\SynPSG\ChronoTrack\src\Assembly\ChronoTrack\ChronoTrack.dll
goto end

:ShowError

@echo ****************************
@echo * "AddToGac Debug|Release IN|DX|MS"
@echo ****************************

goto end

:end
endlocal

