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
set PROJECT=Subroutines
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
set SynPSGNetSRC_CORE=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\src\ChronoTrack
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

set NAMESPACE=SynPSG-ChronoTrack-Subroutines
set SYNDEFNS=SynPSG.ChronoTrack.Subroutines

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\def

set PRJEXPDIR=%DEVROOT%\hdr
set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%COREHDR%,%DEVROOT%\hdr

rem *************************************************************
rem runtime settings
rem *************************************************************

set DATA=%DEVROOT%\dat
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
if EXIST C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackSubs.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackSubs.olb
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Subroutines\ChronoTrackSubs.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Subroutines\ChronoTrackSubs.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Subroutines\GetApplicationUserSettings.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Subroutines\GetApplicationUserSettings.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Subroutines\SetApplicationUserSettings.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Subroutines\SetApplicationUserSettings.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Subroutines\ValidateUser.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Subroutines\ValidateUser.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GetApplicationUserSettings.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GetApplicationUserSettings.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-SetApplicationUserSettings.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-SetApplicationUserSettings.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ValidateUser.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ValidateUser.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto  %VARIANT_FLAGS%  SRC:GetApplicationUserSettings.dbl SRC:SetApplicationUserSettings.dbl SRC:ValidateUser.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS% -o OBJ:ChronoTrackSubs.dbo  SRC:GetApplicationUserSettings.dbl SRC:SetApplicationUserSettings.dbl SRC:ValidateUser.dbl
dblibr -ca OLIB:ChronoTrackSubs.olb OBJ:ChronoTrackSubs.dbo
dblink %LINKERFLAGS% -l EXE:ChronoTrackSubs.elb OLIB:ChronoTrackSubs.olb
endlocal
