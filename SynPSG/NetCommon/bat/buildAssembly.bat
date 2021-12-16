@echo off
setlocal
rem
rem load the Core and ChronoTrack assemblies
rem

if "%LIBPATH%" NEQ "" goto loaded
if EXIST "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86
if EXIST "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86

:loaded

set CONFIGURATION=%1
set NSPACE=%2

rem clean and rebuild the core library
echo Rebuilding SynPSGNetCore assembly
call devenv C:\Development\SynPSG\Core\VSSolutions\SynPSGNetCore\SynPSGNetCore.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\Core\VSSolutions\SynPSGNetCore\SynPSGNetCore.sln /build "%CONFIGURATION%|Any CPU"
rem add to gac
@echo Adding SynPSGNetCore to the GAC
call gacutil /i C:\Development\SynPSG\Core\VSSolutions\SynPSGNetCore\bin\%CONFIGURATION%\SynPSGNetCore.dll

rem clean and rebuild the UI Common library
echo Rebuilding SynPSGNetUICommon assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUICommon\ChronoTrackNetUICommon.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUICommon\ChronoTrackNetUICommon.sln /build "%CONFIGURATION%|Any CPU"
rem add to gac
@echo Adding ChronoTrackNetUICommon to the GAC
gacutil /i C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUICommon\bin\%CONFIGURATION%\ChronoTrackNetUICommon.dll

rem clean and rebuild the ChronoTrack library

if "%NSPACE%" == "ChronoTrackNetUI" goto infragistics
if "%NSPACE%" == "ChronoTrackNetUIDX" goto devexpress
if "%NSPACE%" == "ChronoTrackNetUIMS" goto microsoft
if "%NSPACE%" == "ChronoTrackNetUIDE" goto synergy
if "%NSPACE%" == "ALL" goto infragistics

:infragistics
echo Rebuilding ChronoTrackNetUI assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUI\ChronoTrackNetUI.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUI\ChronoTrackNetUI.sln /build "%CONFIGURATION%|Any CPU"
if "%NSPACE%" == "ALL" goto devexpress
goto final

:devexpress
echo Rebuilding ChronoTrackNetUIDX assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDX\ChronoTrackNetUIDX.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDX\ChronoTrackNetUIDX.sln /build "%CONFIGURATION%|Any CPU"
if "%NSPACE%" == "ALL" goto microsoft
goto final

:microsoft
echo Rebuilding ChronoTrackNetUIMS assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIMS\ChronoTrackNetUIMS.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIMS\ChronoTrackNetUIMS.sln /build "%CONFIGURATION%|Any CPU"
goto final

:synergy
echo Rebuilding ChronoTrackNetUIDE assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDE\ChronoTrackNetUIDE.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackNetUIDE\ChronoTrackNetUIDE.sln /build "%CONFIGURATION%|Any CPU"
goto final

:final
endlocal
