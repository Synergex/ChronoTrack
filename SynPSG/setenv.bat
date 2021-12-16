@echo off
if not "%cd%"=="C:\Development\SynPSG" (
  echo ******************************************************************************
  echo *
  echo *
  echo ChronoTrack development environment must be installed in C:\Development\SynPSG
  echo *
  echo *
  echo ******************************************************************************
  goto final
)
rem
rem This build script is generated from the SynPSG build system
rem It can be used to re-build the complete project
rem
rem
rem
rem *************************************************************
rem Set this to the base folder definition
rem *************************************************************"

set SRCDEV=C
set DEVAREA=Development\SynPSG
set WORKSPACE=ChronoTrack
set PROJECT=Applications
set COMMONAREA=NetCommon

rem *************************************************************
rem If we have a Synergy setup script then call it
rem *************************************************************

if exist %SRCDEV%:\%DEVAREA%\setsyn.bat call %SRCDEV%:\%DEVAREA%\setsyn.bat

rem *************************************************************
rem If we have a Visual Studio setup script then call it
rem *************************************************************

if exist %SRCDEV%:\%DEVAREA%\setvs.bat call %SRCDEV%:\%DEVAREA%\setvs.bat 1> nul

rem *************************************************************
rem This sets the root folder
rem *************************************************************

set ROOTFOLDER=%DEVAREA%\%WORKSPACE%
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%
set SFWINIPATH=%SRCDEV%:\%DEVAREA%\ini

rem *************************************************************
rem These setings are for the base SynPSG NET wrapping core libray
rem *************************************************************

set SynPSGNetHDR=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\genhdr

set SynPSGNetSRC_CORE=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\Core
set SynPSGNetSRC_WINDEMO=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\WinDemo
set SynPSGNetSRC_CHRONOTRACK=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\ChronoTrack

set SynPSGNetLIB=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\lib

rem *************************************************************
rem These setings are for the core library details
rem *************************************************************

set COREEXE=%SRCDEV%:\%DEVAREA%\Core\exe
set CORELIB=%SRCDEV%:\%DEVAREA%\Core\lib
set COREHDR=%SRCDEV%:\%DEVAREA%\Core\hdr
set COREDEF=%SRCDEV%:\%DEVAREA%\Core\inc

set SYSTEMEXE=%SRCDEV%:\%DEVAREA%\System\exe
set SYSTEMHDR=%SRCDEV%:\%DEVAREA%\System\hdr

rem *************************************************************
rem change this depending if it's a development configuration
rem or a release configuration
rem these should be =nothing for release
rem *************************************************************

set DFLAGS=-d
set LDFLAGS=-d
set VARIANT_FLAGS=

rem *************************************************************
rem Define configuration builder settings
rem *************************************************************

set OSTYPE=WINNT
set SYSTEM_TYPE=WindowsNT
set CONF=%SRCDEV%:\Development\SynPSG\Builder\conf\
set DEPSEXE=%SRCDEV%:\Development\SynPSG\Builder\exe\

rem *************************************************************
rem Define here the required environment variables
rem *************************************************************

set SRC=%DEVROOT%\src\%PROJECT%

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\def

set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%COREHDR%,%DEVROOT%\hdr

rem *************************************************************
rem runtime settings
rem *************************************************************

set DAT=%DEVROOT%\dat
set CATALOG=%DEVROOT%\cat
set SODBC_NONULL=4
set CHRONOTRACK_DEBUG_MODE=OFF
:final
