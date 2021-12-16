@echo off
setlocal
rem
rem This build script is generated from the SynPSG build system
rem It can be used to re-build the complete project
rem
rem
rem
rem *************************************************************
rem Set this to the base folder definition
rem *************************************************************"

set NOVCS=yes
set SRCDEV=C
set DEVAREA=Development\SynPSG
set WORKSPACE=Core
set PROJECT=Utilities
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
set SynPSGNetSRC_CORE=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\ChronoTrack
set SynPSGNetSRC_WINDEMO=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\WinDemo
set SynPSGNetLIB=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\lib\SynPSGNetLibrary.olb

rem *************************************************************
rem These setings are for the base SynPSG core libray routines
rem *************************************************************

set SynPSGROOT=%SRCDEV%:\Development\SynPSG\Core
set SynPSGEXE=%SynPSGROOT%\exe
set SynPSGLIB=%SynPSGROOT%\lib
set SynPSGHDR=%SynPSGROOT%\hdr
set SynPSGGENHDR=%SynPSGROOT%\genhdr
set SynPSGNetCoreDLL=%SynPSGROOT%\VSSolutions\SynPSGNetCore\bin\Release

rem *************************************************************
rem change this depending if it's a development configuration
rem or a release configuration
rem these should be =nothing for release
rem *************************************************************

set DFLAGS=-d -W0
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
set NAMESPACE=SynPSG-Core-Utilities
set SYNDEFNS=SynPSG.Core.Utilities

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\src\Includes

set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%DEVROOT%\hdr,%DEVROOT%\genhdr\

rem *************************************************************
rem runtime settings
rem *************************************************************

set DATA=%DEVROOT%\dat
set NETBIN=%DEVROOT%\VSSolutions\SynPSGNetCore\bin\Release
set CHRONOTRACK_DEBUG_MODE=OFF
rem 
rem Remove the debug build symbols if in Release mode 
rem 
set COMPILEFLAGS=-d -W0 
set LINKERFLAGS=-d 
if "%CONFIG%" == "Debug" goto debug_mode 
set COMPILEFLAGS= 
set LINKERFLAGS= 
:debug_mode 
if EXIST C:\Development\SynPSG\Core\lib\CoreUtilities.olb del /F /Q C:\Development\SynPSG\Core\lib\CoreUtilities.olb 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\CoreUtilities.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\CoreUtilities.dbo 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\Conversion.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\Conversion.dbo 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\Debugger.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\Debugger.dbo 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\Working.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\Working.dbo 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\WindowManager.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\WindowManager.dbo 
if EXIST C:\Development\SynPSG\Core\obj\Utilities\TransactionViewer.dbo del /F /Q C:\Development\SynPSG\Core\obj\Utilities\TransactionViewer.dbo 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Conversion.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Conversion.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Debugger.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Debugger.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Working.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-Working.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-WindowManager.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-WindowManager.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-TransactionViewer.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-TransactionViewer.dbh 
if "%NAMESPACE%" == "*" goto main_line 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-*.dbh 
:main_line 
@echo on 
dblproto  %VARIANT_FLAGS%  SRC:Conversion.dbc SRC:Debugger.dbc SRC:Working.dbc SRC:WindowManager.dbc SRC:TransactionViewer.dbc 
dbl %COMPILEFLAGS% -TX %VARIANT_FLAGS% -o OBJ:CoreUtilities.dbo  SRC:Conversion.dbc SRC:Debugger.dbc SRC:Working.dbc SRC:WindowManager.dbc SRC:TransactionViewer.dbc 
dblibr -ca OLIB:CoreUtilities.olb OBJ:CoreUtilities.dbo 
dblink %LINKERFLAGS% -l EXE:CoreUtilities.elb OLIB:CoreUtilities.olb 
endlocal 
