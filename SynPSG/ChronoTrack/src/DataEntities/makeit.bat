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
set PROJECT=DataEntities
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

set NAMESPACE=SynPSG-ChronoTrack-DataEntities
set SYNDEFNS=SynPSG.ChronoTrack.DataEntities

set RPSMFIL=%DEVROOT%\rps\rpsmain.ism
set RPSTFIL=%DEVROOT%\rps\rpstext.ism

set OLIB=%DEVROOT%\lib
set OBJ=%DEVROOT%\obj\%PROJECT%

set EXE=%DEVROOT%\exe
set DEF=%DEVROOT%\def

set PRJEXPDIR=%DEVROOT%\hdr
set SYNEXPDIR=%DEVROOT%\hdr
set SYNIMPDIR=%SynPSGNetHDR%,%SYSTEMHDR%,%COREHDR%,%DEVROOT%\hdr

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
if EXIST C:\Development\SynPSG\ChronoTrack\lib\DataEntities.olb del /F /Q C:\Development\SynPSG\ChronoTrack\lib\DataEntities.olb
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\DataEntities.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\DataEntities.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserCollectionLoad.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\UserCollectionLoad.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StatePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StatePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StatePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StatePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateFormatTrans.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\StateFormatTrans.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CountryPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeeUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ConsultantFeePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContactPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerContractPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerFormatTrans.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerFormatTrans.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerOnDelete.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerOnDelete.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\CustomerLocationPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypeUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ExpenseTypePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypeUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\TaskTypePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypeUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\FeeTypePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectActivityPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectAttachmentPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectConsultantPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpenseUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpensePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpensePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpensePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectExpensePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNoteUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNotePreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNotePreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNotePreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectNotePreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskOnDelete.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectTaskOnDelete.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectOnDelete.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectOnDelete.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectFormatTrans.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectFormatTrans.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPostStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectPostStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectCollectionLoad.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\ProjectCollectionLoad.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestUpdateFields.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestUpdateFields.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestPreStore.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestPreStore.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestPreUpdate.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\RequestPreUpdate.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDataEntity.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDataEntity.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDefineTable.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDefineTable.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewCollectionLoad.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewCollectionLoad.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDataIO.dbo del /F /Q C:\Development\SynPSG\ChronoTrack\obj\DataEntities\GanttViewDataIO.dbo
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserCollectionLoad.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-UserCollectionLoad.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StatePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StatePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StatePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StatePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateFormatTrans.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-StateFormatTrans.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CountryPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeeUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ConsultantFeePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContactPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerContractPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerFormatTrans.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerFormatTrans.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerOnDelete.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerOnDelete.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-CustomerLocationPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypeUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ExpenseTypePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypeUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-TaskTypePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypeUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-FeeTypePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectActivityPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectAttachmentPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectConsultantPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpenseUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpensePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpensePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpensePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectExpensePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNoteUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNotePreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNotePreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNotePreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectNotePreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskOnDelete.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectTaskOnDelete.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectOnDelete.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectOnDelete.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectFormatTrans.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectFormatTrans.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPostStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectPostStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCollectionLoad.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-ProjectCollectionLoad.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestUpdateFields.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestUpdateFields.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestPreStore.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestPreStore.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestPreUpdate.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-RequestPreUpdate.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDataEntity.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDataEntity.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDefineTable.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDefineTable.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewCollectionLoad.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewCollectionLoad.dbh
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDataIO.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-GanttViewDataIO.dbh
if "%NAMESPACE%" == "*" goto main_line
if EXIST C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\ChronoTrack\hdr\%NAMESPACE%-*.dbh
:main_line
@echo on
dblproto  %VARIANT_FLAGS%  SRC:UserDataEntity.dbc SRC:UserDefineTable.dbc SRC:UserUpdateFields.dbc SRC:UserPreStore.dbc SRC:UserPreUpdate.dbc SRC:UserCollectionLoad.dbc SRC:StateDataEntity.dbc SRC:StateDefineTable.dbc SRC:StateUpdateFields.dbc SRC:StatePreStore.dbc SRC:StatePreUpdate.dbc SRC:StateFormatTrans.dbc SRC:CountryDataEntity.dbc SRC:CountryDefineTable.dbc SRC:CountryUpdateFields.dbc SRC:CountryPreStore.dbc SRC:CountryPreUpdate.dbc SRC:ConsultantFeeDataEntity.dbc SRC:ConsultantFeeDefineTable.dbc SRC:ConsultantFeeUpdateFields.dbc SRC:ConsultantFeePreStore.dbc SRC:ConsultantFeePreUpdate.dbc SRC:CustomerContactDataEntity.dbc SRC:CustomerContactDefineTable.dbc SRC:CustomerContactUpdateFields.dbc SRC:CustomerContactPreStore.dbc SRC:CustomerContactPreUpdate.dbc SRC:CustomerContractDataEntity.dbc SRC:CustomerContractDefineTable.dbc SRC:CustomerContractUpdateFields.dbc SRC:CustomerContractPreStore.dbc SRC:CustomerContractPreUpdate.dbc SRC:CustomerDataEntity.dbc SRC:CustomerDefineTable.dbc SRC:CustomerUpdateFields.dbc SRC:CustomerFormatTrans.dbc SRC:CustomerOnDelete.dbc SRC:CustomerPreStore.dbc SRC:CustomerPreUpdate.dbc SRC:CustomerLocationDataEntity.dbc SRC:CustomerLocationDefineTable.dbc SRC:CustomerLocationUpdateFields.dbc SRC:CustomerLocationPreStore.dbc SRC:CustomerLocationPreUpdate.dbc SRC:ExpenseTypeDataEntity.dbc SRC:ExpenseTypeDefineTable.dbc SRC:ExpenseTypeUpdateFields.dbc SRC:ExpenseTypePreStore.dbc SRC:ExpenseTypePreUpdate.dbc SRC:TaskTypeDataEntity.dbc SRC:TaskTypeDefineTable.dbc SRC:TaskTypeUpdateFields.dbc SRC:TaskTypePreStore.dbc SRC:TaskTypePreUpdate.dbc SRC:FeeTypeDataEntity.dbc SRC:FeeTypeDefineTable.dbc SRC:FeeTypeUpdateFields.dbc SRC:FeeTypePreStore.dbc SRC:ProjectActivityDataEntity.dbc SRC:ProjectActivityDefineTable.dbc SRC:ProjectActivityUpdateFields.dbc SRC:ProjectActivityPreStore.dbc SRC:ProjectActivityPreUpdate.dbc SRC:ProjectAttachmentDataEntity.dbc SRC:ProjectAttachmentDefineTable.dbc SRC:ProjectAttachmentUpdateFields.dbc SRC:ProjectAttachmentPreStore.dbc SRC:ProjectConsultantDataEntity.dbc SRC:ProjectConsultantDefineTable.dbc SRC:ProjectConsultantUpdateFields.dbc SRC:ProjectConsultantPreStore.dbc SRC:ProjectConsultantPreUpdate.dbc SRC:ProjectExpenseDataEntity.dbc SRC:ProjectExpenseDefineTable.dbc SRC:ProjectExpenseUpdateFields.dbc SRC:ProjectExpensePreStore.dbc SRC:ProjectExpensePreUpdate.dbc SRC:ProjectNoteDataEntity.dbc SRC:ProjectNoteDefineTable.dbc SRC:ProjectNoteUpdateFields.dbc SRC:ProjectNotePreStore.dbc SRC:ProjectNotePreUpdate.dbc SRC:ProjectTaskDataEntity.dbc SRC:ProjectTaskDefineTable.dbc SRC:ProjectTaskUpdateFields.dbc SRC:ProjectTaskPreStore.dbc SRC:ProjectTaskPreUpdate.dbc SRC:ProjectTaskOnDelete.dbc SRC:ProjectDataEntity.dbc SRC:ProjectDefineTable.dbc SRC:ProjectUpdateFields.dbc SRC:ProjectOnDelete.dbc SRC:ProjectFormatTrans.dbc SRC:ProjectPreStore.dbc SRC:ProjectPreUpdate.dbc SRC:ProjectPostStore.dbc SRC:ProjectCollectionLoad.dbc SRC:RequestDataEntity.dbc SRC:RequestDefineTable.dbc SRC:RequestUpdateFields.dbc SRC:RequestPreStore.dbc SRC:RequestPreUpdate.dbc SRC:GanttViewDataEntity.dbc SRC:GanttViewDefineTable.dbc SRC:GanttViewCollectionLoad.dbc SRC:GanttViewDataIO.dbc
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS% -o OBJ:DataEntities.dbo  SRC:UserDataEntity.dbc SRC:UserDefineTable.dbc SRC:UserUpdateFields.dbc SRC:UserPreStore.dbc SRC:UserPreUpdate.dbc SRC:UserCollectionLoad.dbc SRC:StateDataEntity.dbc SRC:StateDefineTable.dbc SRC:StateUpdateFields.dbc SRC:StatePreStore.dbc SRC:StatePreUpdate.dbc SRC:StateFormatTrans.dbc SRC:CountryDataEntity.dbc SRC:CountryDefineTable.dbc SRC:CountryUpdateFields.dbc SRC:CountryPreStore.dbc SRC:CountryPreUpdate.dbc SRC:ConsultantFeeDataEntity.dbc SRC:ConsultantFeeDefineTable.dbc SRC:ConsultantFeeUpdateFields.dbc SRC:ConsultantFeePreStore.dbc SRC:ConsultantFeePreUpdate.dbc SRC:CustomerContactDataEntity.dbc SRC:CustomerContactDefineTable.dbc SRC:CustomerContactUpdateFields.dbc SRC:CustomerContactPreStore.dbc SRC:CustomerContactPreUpdate.dbc SRC:CustomerContractDataEntity.dbc SRC:CustomerContractDefineTable.dbc SRC:CustomerContractUpdateFields.dbc SRC:CustomerContractPreStore.dbc SRC:CustomerContractPreUpdate.dbc SRC:CustomerDataEntity.dbc SRC:CustomerDefineTable.dbc SRC:CustomerUpdateFields.dbc SRC:CustomerFormatTrans.dbc SRC:CustomerOnDelete.dbc SRC:CustomerPreStore.dbc SRC:CustomerPreUpdate.dbc SRC:CustomerLocationDataEntity.dbc SRC:CustomerLocationDefineTable.dbc SRC:CustomerLocationUpdateFields.dbc SRC:CustomerLocationPreStore.dbc SRC:CustomerLocationPreUpdate.dbc SRC:ExpenseTypeDataEntity.dbc SRC:ExpenseTypeDefineTable.dbc SRC:ExpenseTypeUpdateFields.dbc SRC:ExpenseTypePreStore.dbc SRC:ExpenseTypePreUpdate.dbc SRC:TaskTypeDataEntity.dbc SRC:TaskTypeDefineTable.dbc SRC:TaskTypeUpdateFields.dbc SRC:TaskTypePreStore.dbc SRC:TaskTypePreUpdate.dbc SRC:FeeTypeDataEntity.dbc SRC:FeeTypeDefineTable.dbc SRC:FeeTypeUpdateFields.dbc SRC:FeeTypePreStore.dbc SRC:ProjectActivityDataEntity.dbc SRC:ProjectActivityDefineTable.dbc SRC:ProjectActivityUpdateFields.dbc SRC:ProjectActivityPreStore.dbc SRC:ProjectActivityPreUpdate.dbc SRC:ProjectAttachmentDataEntity.dbc SRC:ProjectAttachmentDefineTable.dbc SRC:ProjectAttachmentUpdateFields.dbc SRC:ProjectAttachmentPreStore.dbc SRC:ProjectConsultantDataEntity.dbc SRC:ProjectConsultantDefineTable.dbc SRC:ProjectConsultantUpdateFields.dbc SRC:ProjectConsultantPreStore.dbc SRC:ProjectConsultantPreUpdate.dbc SRC:ProjectExpenseDataEntity.dbc SRC:ProjectExpenseDefineTable.dbc SRC:ProjectExpenseUpdateFields.dbc SRC:ProjectExpensePreStore.dbc SRC:ProjectExpensePreUpdate.dbc SRC:ProjectNoteDataEntity.dbc SRC:ProjectNoteDefineTable.dbc SRC:ProjectNoteUpdateFields.dbc SRC:ProjectNotePreStore.dbc SRC:ProjectNotePreUpdate.dbc SRC:ProjectTaskDataEntity.dbc SRC:ProjectTaskDefineTable.dbc SRC:ProjectTaskUpdateFields.dbc SRC:ProjectTaskPreStore.dbc SRC:ProjectTaskPreUpdate.dbc SRC:ProjectTaskOnDelete.dbc SRC:ProjectDataEntity.dbc SRC:ProjectDefineTable.dbc SRC:ProjectUpdateFields.dbc SRC:ProjectOnDelete.dbc SRC:ProjectFormatTrans.dbc SRC:ProjectPreStore.dbc SRC:ProjectPreUpdate.dbc SRC:ProjectPostStore.dbc SRC:ProjectCollectionLoad.dbc SRC:RequestDataEntity.dbc SRC:RequestDefineTable.dbc SRC:RequestUpdateFields.dbc SRC:RequestPreStore.dbc SRC:RequestPreUpdate.dbc SRC:GanttViewDataEntity.dbc SRC:GanttViewDefineTable.dbc SRC:GanttViewCollectionLoad.dbc SRC:GanttViewDataIO.dbc
dblibr -ca OLIB:DataEntities.olb OBJ:DataEntities.dbo
dblink %LINKERFLAGS% -l EXE:DataEntities.elb OLIB:DataEntities.olb
endlocal
