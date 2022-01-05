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
set WORKSPACE=System
set PROJECT=Base

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
set SynPSGNetLIB=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\lib\SynPSGNetLibrary.olb

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
set NAMESPACE=SynPSG-System
set SYNDEFNS=SynPSG.System

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\src\Includes

set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%DEVROOT%\hdr

rem *************************************************************
rem runtime settings
rem *************************************************************
rem
rem Remove the debug build symbols if in Release mode
rem
set COMPILEFLAGS=-d
set LINKERFLAGS=-d
if "%CONFIG%" == "Debug" goto debug_mode
set COMPILEFLAGS=
set LINKERFLAGS=
:debug_mode
if EXIST C:\Development\SynPSG\System\lib\SynPSGSystem.olb del /F /Q C:\Development\SynPSG\System\lib\SynPSGSystem.olb
if EXIST C:\Development\SynPSG\System\obj\Base\SynPSGSystem.dbo del /F /Q C:\Development\SynPSG\System\obj\Base\SynPSGSystem.dbo
if EXIST C:\Development\SynPSG\System\obj\Base\Convert.dbo del /F /Q C:\Development\SynPSG\System\obj\Base\Convert.dbo
if EXIST C:\Development\SynPSG\System\obj\Base\Datetime.dbo del /F /Q C:\Development\SynPSG\System\obj\Base\Datetime.dbo
if EXIST C:\Development\SynPSG\System\obj\Base\StringUtil.dbo del /F /Q C:\Development\SynPSG\System\obj\Base\StringUtil.dbo
if EXIST C:\Development\SynPSG\System\obj\Base\TimeUtil.dbo del /F /Q C:\Development\SynPSG\System\obj\Base\TimeUtil.dbo
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-Convert.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-Convert.dbh
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-Datetime.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-Datetime.dbh
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-StringUtil.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-StringUtil.dbh
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-TimeUtil.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-TimeUtil.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto %VARIANT_FLAGS%  SRC:Convert.dbc SRC:Datetime.dbc SRC:StringUtil.dbc SRC:TimeUtil.dbc
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS% -o OBJ:SynPSGSystem.dbo  SRC:Convert.dbc SRC:Datetime.dbc SRC:StringUtil.dbc SRC:TimeUtil.dbc
dblibr -ca OLIB:SynPSGSystem.olb OBJ:SynPSGSystem.dbo
dblink %LINKERFLAGS% -l EXE:SynPSGSystem.elb OLIB:SynPSGSystem.olb
endlocal
