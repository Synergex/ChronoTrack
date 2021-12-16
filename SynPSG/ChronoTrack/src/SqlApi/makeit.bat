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
set PROJECT=SqlApi
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

set NAMESPACE=SynPSG-ChronoTrack-SqlApi
set SYNDEFNS=SynPSG.ChronoTrack.SqlApi

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\def

set PRJEXPDIR=%DEVROOT%\hdr
set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%COREHDR%,%DEVROOT%\hdr

set CODEGEN_EXE=%SRCDEV%:\Development\SynPSG\Builder\exe
set PATH=%PATH%;%CODEGEN_EXE%
set CODEGEN_TPLDIR=%DEVROOT%\templates
set CODEGEN_AUTHOR=CodeGen
set CODEGEN_COMPANY=Synergex

rem *************************************************************
rem runtime settings
rem *************************************************************

set DAT=%DEVROOT%\dat
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
if EXIST C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackSqlApi.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\ChronoTrackSqlApi.olb
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackSqlApi.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackSqlApi.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackReplicator.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackReplicator.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackBulkLoad.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackBulkLoad.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\channel_cache.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\channel_cache.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\replicate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\replicate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\consultant_fee_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\consultant_fee_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\consultant_fee_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\consultant_fee_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\country_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\country_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\country_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\country_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contact_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contact_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contact_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contact_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contract_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contract_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contract_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_contract_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_location_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_location_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_location_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\customer_location_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\expense_type_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\expense_type_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\expense_type_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\expense_type_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\task_type_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\task_type_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\fee_type_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\fee_type_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\fee_type_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\fee_type_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_activity_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_activity_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_activity_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_activity_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_attachment_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_attachment_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_attachment_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_attachment_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_consultant_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_consultant_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_consultant_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_consultant_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_expense_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_expense_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_expense_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_expense_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_note_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_note_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_note_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_note_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_task_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_task_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_task_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\project_task_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\request_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\request_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\request_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\request_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\state_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\state_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\state_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\state_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\user_io.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\user_io.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\user_sqlio.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\user_sqlio.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\SqlApi\IsNumeric.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\SqlApi\IsNumeric.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-channel_cache.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-channel_cache.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-replicate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-replicate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-consultant_fee_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-consultant_fee_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-consultant_fee_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-consultant_fee_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-country_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-country_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-country_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-country_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contact_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contact_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contact_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contact_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contract_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contract_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contract_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_contract_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_location_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_location_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_location_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-customer_location_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-expense_type_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-expense_type_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-expense_type_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-expense_type_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-task_type_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-task_type_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-fee_type_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-fee_type_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-fee_type_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-fee_type_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_activity_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_activity_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_activity_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_activity_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_attachment_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_attachment_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_attachment_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_attachment_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_consultant_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_consultant_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_consultant_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_consultant_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_expense_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_expense_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_expense_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_expense_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_note_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_note_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_note_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_note_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_task_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_task_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_task_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-project_task_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-request_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-request_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-request_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-request_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-state_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-state_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-state_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-state_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-user_io.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-user_io.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-user_sqlio.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-user_sqlio.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-IsNumeric.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-IsNumeric.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto  %VARIANT_FLAGS%  SRC:channel_cache.dbl SRC:replicate.dbl SRC:consultant_fee_io.dbl SRC:consultant_fee_sqlio.dbl SRC:country_io.dbl SRC:country_sqlio.dbl SRC:customer_contact_io.dbl SRC:customer_contact_sqlio.dbl SRC:customer_contract_io.dbl SRC:customer_contract_sqlio.dbl SRC:customer_io.dbl SRC:customer_sqlio.dbl SRC:customer_location_io.dbl SRC:customer_location_sqlio.dbl SRC:expense_type_io.dbl SRC:expense_type_sqlio.dbl SRC:task_type_sqlio.dbl SRC:fee_type_io.dbl SRC:fee_type_sqlio.dbl SRC:project_activity_io.dbl SRC:project_activity_sqlio.dbl SRC:project_attachment_io.dbl SRC:project_attachment_sqlio.dbl SRC:project_consultant_io.dbl SRC:project_consultant_sqlio.dbl SRC:project_expense_io.dbl SRC:project_expense_sqlio.dbl SRC:project_io.dbl SRC:project_sqlio.dbl SRC:project_note_io.dbl SRC:project_note_sqlio.dbl SRC:project_task_io.dbl SRC:project_task_sqlio.dbl SRC:request_io.dbl SRC:request_sqlio.dbl SRC:state_io.dbl SRC:state_sqlio.dbl SRC:user_io.dbl SRC:user_sqlio.dbl SRC:IsNumeric.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS% -o OBJ:ChronoTrackSqlApi.dbo  SRC:channel_cache.dbl SRC:replicate.dbl SRC:consultant_fee_io.dbl SRC:consultant_fee_sqlio.dbl SRC:country_io.dbl SRC:country_sqlio.dbl SRC:customer_contact_io.dbl SRC:customer_contact_sqlio.dbl SRC:customer_contract_io.dbl SRC:customer_contract_sqlio.dbl SRC:customer_io.dbl SRC:customer_sqlio.dbl SRC:customer_location_io.dbl SRC:customer_location_sqlio.dbl SRC:expense_type_io.dbl SRC:expense_type_sqlio.dbl SRC:task_type_sqlio.dbl SRC:fee_type_io.dbl SRC:fee_type_sqlio.dbl SRC:project_activity_io.dbl SRC:project_activity_sqlio.dbl SRC:project_attachment_io.dbl SRC:project_attachment_sqlio.dbl SRC:project_consultant_io.dbl SRC:project_consultant_sqlio.dbl SRC:project_expense_io.dbl SRC:project_expense_sqlio.dbl SRC:project_io.dbl SRC:project_sqlio.dbl SRC:project_note_io.dbl SRC:project_note_sqlio.dbl SRC:project_task_io.dbl SRC:project_task_sqlio.dbl SRC:request_io.dbl SRC:request_sqlio.dbl SRC:state_io.dbl SRC:state_sqlio.dbl SRC:user_io.dbl SRC:user_sqlio.dbl SRC:IsNumeric.dbl
dblibr -ca OLIB:ChronoTrackSqlApi.olb OBJ:ChronoTrackSqlApi.dbo
dblink %LINKERFLAGS% -l EXE:ChronoTrackSqlApi.elb OLIB:ChronoTrackSqlApi.olb
dblproto %VARIANT_FLAGS% SRC:ChronoTrackReplicator.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ChronoTrackReplicator.dbo SRC:ChronoTrackReplicator.dbl
dblink %LINKERFLAGS% -o EXE:ChronoTrackReplicator.dbr C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackReplicator.dbo  EXE:ChronoTrackSqlApi.elb
dblproto %VARIANT_FLAGS% SRC:ChronoTrackBulkLoad.dbl
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ChronoTrackBulkLoad.dbo SRC:ChronoTrackBulkLoad.dbl
dblink %LINKERFLAGS% -o EXE:ChronoTrackBulkLoad.dbr C:\Development\SynPSG\ChronoTrack\obj\SqlApi\ChronoTrackBulkLoad.dbo  EXE:ChronoTrackSqlApi.elb
endlocal
