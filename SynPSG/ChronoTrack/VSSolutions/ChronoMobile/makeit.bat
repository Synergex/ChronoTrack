@echo off
setlocal
rem
rem Build the ChronoTrack web site
rem

if "%LIBPATH%" NEQ "" goto loaded
if EXIST "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86
if EXIST "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86

:loaded

set CONFIGURATION=%1

rem clean and rebuild the ChronoTrack web solution
echo Rebuilding ChronoTrack Mobile assembly
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoMobile\ChronoMobile.sln /clean "%CONFIGURATION%|Any CPU"
call devenv C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoMobile\ChronoMobile.sln /build "%CONFIGURATION%|Any CPU"

goto final

:final
endlocal
