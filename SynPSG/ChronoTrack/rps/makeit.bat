@echo off
setlocal
rem
rem This build script is generated from the SynPSG build system
rem It can be used to re-build the complete project
rem
rem
rem *************************************************************
rem Set this to the base folder definition
rem *************************************************************"

set NOVCS=yes
set SRCDEV=C
set DEVAREA=Development\SynPSG
set WORKSPACE=ChronoTrack
set PROJECT=Repository
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
set SynPSGNetLIB_CORE=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\lib
set SynPSGNetSRC_CORE=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\Core
set SynPSGNetSRC_WINDEMO=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\WinDemo
set SynPSGNetSRC_CHRONOTRACK=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\ChronoTrack

rem *************************************************************
rem These setings are for the core library details
rem *************************************************************

set COREEXE=%SRCDEV%:\%DEVAREA%\Core\exe
set CORELIB=%SRCDEV%:\%DEVAREA%\Core\lib
set COREHDR=%SRCDEV%:\%DEVAREA%\Core\hdr
set COREDEF=%SRCDEV%:\%DEVAREA%\Core\src\Includes

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

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism
set DAT=%DEVROOT%\dat
set XDL=%DEVROOT%\xdl

set CODEGEN_EXE=%SRCDEV%:\Development\SynPSG\Builder\exe
set PATH=%PATH%;%CODEGEN_EXE%
set NAMESPACE=*
rem 
rem Remove the debug build symbols if in Release mode 
rem 
set COMPILEFLAGS=-d 
set LINKERFLAGS=-d 
if "%CONFIG%" == "Debug" goto debug_mode 
set COMPILEFLAGS= 
set LINKERFLAGS= 
:debug_mode 
if EXIST %RPSPTH%\rpsmain.is* del /F /Q %RPSPTH%\rpsmain.is* 
if EXIST %RPSPTH%\rpstext.is* del /F /Q %RPSPTH%\rpstext.is* 
@echo on 
set XSHOW=HIDE 
dbs RPS:rpsutl -i C:\Development\SynPSG\ChronoTrack\rps\rpsschema.sch -ir 
isutl -r -o 0 -p 100 C:\Development\SynPSG\ChronoTrack\rps\rpsmain.ism 
isutl -r -o 0 -p 100 C:\Development\SynPSG\ChronoTrack\rps\rpstext.ism 
if EXIST C:\Development\SynPSG\Builder\exe\\scandbldeps.dbr dbs DEPSEXE:scandbldeps -r -rs -s C:\Development\SynPSG\ChronoTrack\rpssch 
set XSHOW= 
endlocal 
