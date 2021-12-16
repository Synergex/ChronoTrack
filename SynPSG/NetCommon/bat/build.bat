@echo off
rem
rem Build the .NET wrappers
rem

set CONFIGURATION=%1
set NSPACE=%2

set SRCDEV=C

rem *************************************************************
rem This sets the root folder
rem *************************************************************

set ROOTFOLDER=Development\SynPSG
set COMMONFOLDER=%SRCDEV%:\%ROOTFOLDER%\NetCommon
set LIBDIR=%COMMONFOLDER%\lib
set EXEDIR=%COMMONFOLDER%\exe
set HDRDIR=%COMMONFOLDER%\genhdr
set SYNIMPDIR=%COMMONFOLDER%\genhdr
set CORESRCDIR=%COMMONFOLDER%\src\Core

rem *************************************************************
rem Clean everyting up
rem *************************************************************

if EXIST %HDRDIR%\*.dbh del /F /Q %HDRDIR%\*.dbh

rem *************************************************************
rem Build the SynPSGNetCore code
rem *************************************************************

if "%NSPACE%" == "ChronoTrackNetUI" goto infragistics
if "%NSPACE%" == "ChronoTrackNetUIDX" goto devexpress
if "%NSPACE%" == "ChronoTrackNetUIMS" goto microsoft
if "%NSPACE%" == "ChronoTrackNetUIDE" goto synergy
if "%NSPACE%" == "ALL" goto library_all

rem *************************************************************
rem Set up and build the ChronoTrack (infragistics) library
rem *************************************************************

:infragistics

set WORKSPACE=ChronoTrack
set PROJECT=ChronoTrackNetUIIN
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%\%WORKSPACE%
set SRCDIR=%COMMONFOLDER%\src\%WORKSPACE%
set OBJDIR=%COMMONFOLDER%\obj\%WORKSPACE%

rem *************************************************************
rem Build the code
rem *************************************************************

@echo Build the ChronoTrackNetUI library in %CONFIGURATION% mode
call %SRCDIR%\ChronoTrackNetUI.bat

goto end

rem *************************************************************
rem Set up and build the ChronoTrack (DevExpress) library
rem *************************************************************

:devexpress

set WORKSPACE=ChronoTrack
set PROJECT=ChronoTrackNetUI
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%\%WORKSPACE%
set SRCDIR=%COMMONFOLDER%\src\%WORKSPACE%
set OBJDIR=%COMMONFOLDER%\obj\%WORKSPACE%

rem *************************************************************
rem Build the code
rem *************************************************************

@echo Build the ChronoTrackNetUIDX library in %CONFIGURATION% mode
call %SRCDIR%\ChronoTrackNetUIDX.bat

goto end

rem *************************************************************
rem Set up and build the ChronoTrack (Microsoft) library
rem *************************************************************

:microsoft

set WORKSPACE=ChronoTrack
set PROJECT=ChronoTrackNetUI
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%\%WORKSPACE%
set SRCDIR=%COMMONFOLDER%\src\%WORKSPACE%
set OBJDIR=%COMMONFOLDER%\obj\%WORKSPACE%

rem *************************************************************
rem Build the code
rem *************************************************************

@echo Build the ChronoTrackNetUIMS library in %CONFIGURATION% mode
call %SRCDIR%\ChronoTrackNetUIMS.bat

goto end

rem *************************************************************
rem Set up and build the ChronoTrack (synergy) library
rem *************************************************************

:synergy

set WORKSPACE=ChronoTrack
set PROJECT=ChronoTrackNetUI
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%\%WORKSPACE%
set SRCDIR=%COMMONFOLDER%\src\%WORKSPACE%
set OBJDIR=%COMMONFOLDER%\obj\%WORKSPACE%

rem *************************************************************
rem Build the code
rem *************************************************************

@echo Build the ChronoTrackNetUIDE library in %CONFIGURATION% mode
call %SRCDIR%\ChronoTrackNetUIDE.bat

goto end

:library_all

set WORKSPACE=ChronoTrack
set PROJECT=SynPSGNetCore
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%\%WORKSPACE%
set SRCDIR=%COMMONFOLDER%\src\%WORKSPACE%
set OBJDIR=%COMMONFOLDER%\obj\%WORKSPACE%

@echo Building the core library in %CONFIGURATION% mode
call %SRCDIR%\SynPSGNetCore.bat

:end
