@echo off
setlocal
rem
rem This build script is generated from the SynPSG build system
rem It can be used to re-build the complete project
rem
set NOVCS=yes

rem
rem *************************************************************
rem Set this to the base folder definition
rem *************************************************************"

set NOVCS=yes
set SRCDEV=C
set DEVAREA=Development\SynPSG
set WORKSPACE=ChronoTrack
set PROJECT=Toolkit
set COMMONAREA=NetCommon

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
set COREDEF=%SRCDEV%:\%DEVAREA%\Core\src\Includes

rem *************************************************************
rem These setings are for the System library details
rem *************************************************************

set SYSTEMEXE=%SRCDEV%:\%DEVAREA%\System\exe
set SYSTEMHDR=%SRCDEV%:\%DEVAREA%\System\hdr

rem *************************************************************
rem change this depending if it's a development configuration
rem or a release configuration
rem these should be =nothing for release
rem *************************************************************

set DFLAGS=-d
set LDFLAGS=-d

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
set WSC=%DEVROOT%\src\%PROJECT%

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set NAMESPACE=SynPSG-ChronoTrack-Server
set SYNDEFNS=SynPSG.ChronoTrack.Server

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\def

set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%COREHDR%,%DEVROOT%\hdr

set XFPL_SMCPATH=%DEVROOT%\smc

rem *************************************************************
rem runtime settings
rem *************************************************************

set DATA=%DEVROOT%\dat

set WSCTMP=%DEVROOT%\wsctmp

set CHRONOTRACK_DEBUG_MODE=OFF
rem
rem Remove the debug build symbols if in Release mode
rem
set COMPILEFLAGS=-d
set LINKERFLAGS=-d
if "%CONFIG%" == "Debug" goto debug_mode
set COMPILEFLAGS=
set LINKERFLAGS=
:debug_mode
if EXIST C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackToolkit.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackToolkit.olb
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Toolkit\ChronoTrackToolkit.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Toolkit\ChronoTrackToolkit.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Toolkit\ChronoTrack.wsi del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Toolkit\ChronoTrack.wsi
if EXIST C:\Development\SynPSG\ChronoTrack\exe\ChronoTrack.ism del /F /Q C:\Development\SynPSG\ChronoTrack\exe\ChronoTrack.is*
@echo on
set XSHOW=HIDE
if EXIST C:\Development\SynPSG\ChronoTrack\src\Toolkit\ChronoTrack.log del /F /Q C:\Development\SynPSG\ChronoTrack\src\Toolkit\ChronoTrack.log
if EXIST C:\Development\SynPSG\ChronoTrack\exe\ChronoTrack.ism (set SCRIPTOPT=-l) ELSE (set SCRIPTOPT=-c)
dbr WND:script %SCRIPTOPT% C:\Development\SynPSG\ChronoTrack\exe\ChronoTrack.ism -i C:\Development\SynPSG\ChronoTrack\src\Toolkit\ChronoTrack.wsc -o C:\Development\SynPSG\ChronoTrack\src\Toolkit\ChronoTrack.log
set XSHOW=
endlocal
