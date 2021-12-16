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
set PROJECT=Server
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

set SRC=%DEVROOT%\src\%PROJECT%

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
if EXIST C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackServer.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackServer.olb 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ChronoTrackServer.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ChronoTrackServer.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\BinaryFileRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\BinaryFileRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CheckLogin.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CheckLogin.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\RemoteLogin.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\RemoteLogin.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ReturnLastError.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ReturnLastError.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ConsultantFeeRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ConsultantFeeRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\UserRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\UserRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\StateRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\StateRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CountryRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CountryRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerContactRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerContactRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerContractRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerContractRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerLocationRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\CustomerLocationRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ExpenseTypeRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ExpenseTypeRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\TaskTypeRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\TaskTypeRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\FeeTypeRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\FeeTypeRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectActivityRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectActivityRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectAttachmentRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectAttachmentRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectConsultantRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectConsultantRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectExpenseRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectExpenseRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectNoteRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectNoteRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectTaskRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ProjectTaskRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\RequestRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\RequestRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\GanttViewRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\GanttViewRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\ScheduleRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\ScheduleRoutines.dbo 
if EXIST C:\Development\SynPSG\ChronoTrack\obj\Server\TemporaryRoutines.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\Server\TemporaryRoutines.dbo 
@echo on 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:BinaryFileRoutines.dbo SRC:BinaryFileRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CheckLogin.dbo SRC:CheckLogin.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:RemoteLogin.dbo SRC:RemoteLogin.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ReturnLastError.dbo SRC:ReturnLastError.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ConsultantFeeRoutines.dbo SRC:ConsultantFeeRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:UserRoutines.dbo SRC:UserRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:StateRoutines.dbo SRC:StateRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CountryRoutines.dbo SRC:CountryRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CustomerContactRoutines.dbo SRC:CustomerContactRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CustomerContractRoutines.dbo SRC:CustomerContractRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CustomerRoutines.dbo SRC:CustomerRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:CustomerLocationRoutines.dbo SRC:CustomerLocationRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ExpenseTypeRoutines.dbo SRC:ExpenseTypeRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:TaskTypeRoutines.dbo SRC:TaskTypeRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:FeeTypeRoutines.dbo SRC:FeeTypeRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectActivityRoutines.dbo SRC:ProjectActivityRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectAttachmentRoutines.dbo SRC:ProjectAttachmentRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectConsultantRoutines.dbo SRC:ProjectConsultantRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectRoutines.dbo SRC:ProjectRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectExpenseRoutines.dbo SRC:ProjectExpenseRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectNoteRoutines.dbo SRC:ProjectNoteRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ProjectTaskRoutines.dbo SRC:ProjectTaskRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:RequestRoutines.dbo SRC:RequestRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:GanttViewRoutines.dbo SRC:GanttViewRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ScheduleRoutines.dbo SRC:ScheduleRoutines.dbl 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:TemporaryRoutines.dbo SRC:TemporaryRoutines.dbl 
dblibr -ca OLIB:ChronoTrackServer.olb 
dblibr -w -r OLIB:ChronoTrackServer.olb  OBJ:BinaryFileRoutines.dbo OBJ:CheckLogin.dbo OBJ:RemoteLogin.dbo OBJ:ReturnLastError.dbo OBJ:ConsultantFeeRoutines.dbo OBJ:UserRoutines.dbo OBJ:StateRoutines.dbo OBJ:CountryRoutines.dbo OBJ:CustomerContactRoutines.dbo OBJ:CustomerContractRoutines.dbo OBJ:CustomerRoutines.dbo OBJ:CustomerLocationRoutines.dbo OBJ:ExpenseTypeRoutines.dbo OBJ:TaskTypeRoutines.dbo OBJ:FeeTypeRoutines.dbo OBJ:ProjectActivityRoutines.dbo OBJ:ProjectAttachmentRoutines.dbo OBJ:ProjectConsultantRoutines.dbo OBJ:ProjectRoutines.dbo OBJ:ProjectExpenseRoutines.dbo OBJ:ProjectNoteRoutines.dbo OBJ:ProjectTaskRoutines.dbo OBJ:RequestRoutines.dbo OBJ:GanttViewRoutines.dbo OBJ:ScheduleRoutines.dbo OBJ:TemporaryRoutines.dbo 
dblink %LINKERFLAGS% -l EXE:ChronoTrackServer.elb OLIB:ChronoTrackServer.olb  
endlocal 
