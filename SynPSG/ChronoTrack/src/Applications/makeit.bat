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
set WORKSPACE=ChronoTrack
set PROJECT=Applications
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

set NAMESPACE=*
set SYNDEFNS=

set SRC=%DEVROOT%\src\%PROJECT%

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set IMG=%DEVROOT%\img
set DEF=%DEVROOT%\def

set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%COREHDR%,%DEVROOT%\hdr

rem *************************************************************
rem runtime settings
rem *************************************************************

set DAT=%DEVROOT%\dat
set CHRONOTRACK_DEBUG_MODE=OFF
set SYNNET_DEBUG=1
rem
rem Remove the debug build symbols if in Release mode
rem
set COMPILEFLAGS=-d
set LINKERFLAGS=-d
if "%CONFIG%" == "Debug" goto debug_mode
set COMPILEFLAGS=
set LINKERFLAGS=
:debug_mode
if EXIST C:\Development\SynPSG\ChronoTrack\lib\AppRoutines.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\AppRoutines.olb
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\AppRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\AppRoutines.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ChronoTrackMaint.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ChronoTrackMaint.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ChronoTrack.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ChronoTrack.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\LoginForm.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\LoginForm.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\xfpl_log.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\xfpl_log.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\UserMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\UserMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\UserMaintenance_tab.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\UserMaintenance_tab.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCreator.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCreator.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCreator_tab.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCreator_tab.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\AboutWindow.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\AboutWindow.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ChangePassword.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ChangePassword.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\OptionsMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\OptionsMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\CountryMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\CountryMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\StateMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\StateMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\FeeTypeMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\FeeTypeMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\RequestCreator.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\RequestCreator.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCenter.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectCenter.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectManager_tab.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectManager_tab.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectManager.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\ProjectManager.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerContactMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerContactMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerLocationMaintenance.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Applications\CustomerLocationMaintenance.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-LoginForm.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-LoginForm.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-xfpl_log.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-xfpl_log.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserMaintenance_tab.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserMaintenance_tab.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCreator.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCreator.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCreator_tab.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCreator_tab.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-AboutWindow.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-AboutWindow.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ChangePassword.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ChangePassword.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-OptionsMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-OptionsMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestCreator.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestCreator.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCenter.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCenter.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectManager_tab.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectManager_tab.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectManager.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectManager.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactMaintenance.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationMaintenance.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationMaintenance.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto  %VARIANT_FLAGS%  SRC:LoginForm.dbl SRC:xfpl_log.dbl SRC:UserMaintenance.dbl SRC:UserMaintenance_tab.dbl SRC:ProjectCreator.dbl SRC:ProjectCreator_tab.dbl SRC:AboutWindow.dbl SRC:ChangePassword.dbl SRC:OptionsMaintenance.dbl SRC:CountryMaintenance.dbl SRC:StateMaintenance.dbl SRC:FeeTypeMaintenance.dbl SRC:RequestCreator.dbl SRC:ProjectCenter.dbl SRC:ProjectManager_tab.dbl SRC:ProjectManager.dbl SRC:CustomerMaintenance.dbl SRC:CustomerContactMaintenance.dbl SRC:CustomerLocationMaintenance.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS% -o OBJ:AppRoutines.dbo  SRC:LoginForm.dbl SRC:xfpl_log.dbl SRC:UserMaintenance.dbl SRC:UserMaintenance_tab.dbl SRC:ProjectCreator.dbl SRC:ProjectCreator_tab.dbl SRC:AboutWindow.dbl SRC:ChangePassword.dbl SRC:OptionsMaintenance.dbl SRC:CountryMaintenance.dbl SRC:StateMaintenance.dbl SRC:FeeTypeMaintenance.dbl SRC:RequestCreator.dbl SRC:ProjectCenter.dbl SRC:ProjectManager_tab.dbl SRC:ProjectManager.dbl SRC:CustomerMaintenance.dbl SRC:CustomerContactMaintenance.dbl SRC:CustomerLocationMaintenance.dbl
dblibr -ca OLIB:AppRoutines.olb OBJ:AppRoutines.dbo
dblink %LINKERFLAGS% -l EXE:AppRoutines.elb OLIB:AppRoutines.olb
dblproto %VARIANT_FLAGS% SRC:ChronoTrackMaint.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ChronoTrackMaint.dbo SRC:ChronoTrackMaint.dbl
dblink %LINKERFLAGS% -o EXE:ChronoTrackMaint.dbr OBJ:ChronoTrackMaint.dbo  EXE:AppRoutines.elb  SYSTEMEXE:SynPSGSystem.elb SYSTEMEXE:SynPSGSystemIO.elb SYSTEMEXE:SynPSGSystemNet.elb SYSTEMEXE:SynPSGSystemText.elb COREEXE:CoreUtilities.elb COREEXE:CoreDataEntities.elb EXE:DataEntities.elb EXE:ChronoTrackSubs.elb WND:tklib.elb SynPSGNetLIB:SynPSGNetCore.olb
dblproto %VARIANT_FLAGS% SRC:ChronoTrack.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ChronoTrack.dbo SRC:ChronoTrack.dbl
dblink %LINKERFLAGS% -o EXE:ChronoTrack.dbr OBJ:ChronoTrack.dbo  EXE:AppRoutines.elb  SYSTEMEXE:SynPSGSystem.elb SYSTEMEXE:SynPSGSystemIO.elb SYSTEMEXE:SynPSGSystemNet.elb SYSTEMEXE:SynPSGSystemText.elb COREEXE:CoreUtilities.elb COREEXE:CoreDataEntities.elb EXE:DataEntities.elb EXE:ChronoTrackSubs.elb WND:tklib.elb SynPSGNetLIB:SynPSGNetCore.olb
endlocal
