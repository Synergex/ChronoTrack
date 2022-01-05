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
set PROJECT=IO

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
set NAMESPACE=SynPSG-System-IO
set SYNDEFNS=SynPSG.System.IO

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
if EXIST C:\Development\SynPSG\System\lib\SynPSGSystemIO.olb del /F /Q C:\Development\SynPSG\System\lib\SynPSGSystemIO.olb
if EXIST C:\Development\SynPSG\System\obj\IO\SynPSGSystemIO.dbo del /F /Q C:\Development\SynPSG\System\obj\IO\SynPSGSystemIO.dbo
if EXIST C:\Development\SynPSG\System\obj\IO\Stream.dbo del /F /Q C:\Development\SynPSG\System\obj\IO\Stream.dbo
if EXIST C:\Development\SynPSG\System\obj\IO\MemoryStream.dbo del /F /Q C:\Development\SynPSG\System\obj\IO\MemoryStream.dbo
if EXIST C:\Development\SynPSG\System\obj\IO\FileStream.dbo del /F /Q C:\Development\SynPSG\System\obj\IO\FileStream.dbo
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-Stream.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-Stream.dbh
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-MemoryStream.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-MemoryStream.dbh
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-FileStream.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-FileStream.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto %VARIANT_FLAGS% SRC:Stream.dbc
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:Stream.dbo SRC:Stream.dbc
dblproto %VARIANT_FLAGS% SRC:MemoryStream.dbc
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:MemoryStream.dbo SRC:MemoryStream.dbc
dblproto %VARIANT_FLAGS% SRC:FileStream.dbc
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:FileStream.dbo SRC:FileStream.dbc
dblibr -ca OLIB:SynPSGSystemIO.olb
dblibr -w -r OLIB:SynPSGSystemIO.olb  OBJ:Stream.dbo OBJ:MemoryStream.dbo OBJ:FileStream.dbo
dblink %LINKERFLAGS% -l EXE:SynPSGSystemIO.elb OLIB:SynPSGSystemIO.olb
endlocal
