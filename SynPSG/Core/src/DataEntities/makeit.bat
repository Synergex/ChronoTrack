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
set SynPSGNetLIB=%SRCDEV%:\%DEVAREA%\%COMMONAREA%\lib\SynPSGNetLibrary.olb

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
set NAMESPACE=SynPSG-Core-DataEntities
set SYNDEFNS=SynPSG.Core.DataEntities

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
if EXIST C:\Development\SynPSG\Core\lib\CoreDataEntities.olb del /F /Q C:\Development\SynPSG\Core\lib\CoreDataEntities.olb 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\CoreDataEntities.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\CoreDataEntities.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\DataEntityTypes.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\DataEntityTypes.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\UpdateConflictEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\UpdateConflictEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\UpdateConflict.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\UpdateConflict.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PreUpdateEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PreUpdateEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PreUpdate.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PreUpdate.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PreStoreEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PreStoreEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PreStore.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PreStore.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PostStoreEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PostStoreEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\PostStore.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\PostStore.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\FormatTransViewEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\FormatTransViewEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\FormatTransView.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\FormatTransView.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\DefineTable.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\DefineTable.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\DefineTableEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\DefineTableEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\UpdateFields.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\UpdateFields.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\UpdateFieldsEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\UpdateFieldsEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\CollectionLoadEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\CollectionLoadEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\CollectionLoad.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\CollectionLoad.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\OnDelete.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\OnDelete.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\OnDeleteEventArgs.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\OnDeleteEventArgs.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\SDMSio.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\SDMSio.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\SDMSBase.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\SDMSBase.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\SDMSTable.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\SDMSTable.dbo 
if EXIST C:\Development\SynPSG\Core\obj\DataEntities\SDMSCollection.dbo del /F /Q C:\Development\SynPSG\Core\obj\DataEntities\SDMSCollection.dbo 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DataEntityTypes.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DataEntityTypes.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateConflictEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateConflictEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateConflict.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateConflict.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreUpdateEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreUpdateEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreUpdate.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreUpdate.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreStoreEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreStoreEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreStore.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PreStore.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PostStoreEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PostStoreEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PostStore.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-PostStore.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-FormatTransViewEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-FormatTransViewEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-FormatTransView.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-FormatTransView.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DefineTable.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DefineTable.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DefineTableEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-DefineTableEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateFields.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateFields.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateFieldsEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-UpdateFieldsEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-CollectionLoadEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-CollectionLoadEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-CollectionLoad.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-CollectionLoad.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-OnDelete.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-OnDelete.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-OnDeleteEventArgs.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-OnDeleteEventArgs.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSio.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSio.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSBase.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSBase.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSTable.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSTable.dbh 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSCollection.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-SDMSCollection.dbh 
if "%NAMESPACE%" == "*" goto main_line 
if EXIST C:\Development\SynPSG\Core\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\Core\hdr\%NAMESPACE%-*.dbh 
:main_line 
@echo on 
dblproto  %VARIANT_FLAGS%  SRC:DataEntityTypes.dbc SRC:UpdateConflictEventArgs.dbc SRC:UpdateConflict.dbc SRC:PreUpdateEventArgs.dbc SRC:PreUpdate.dbc SRC:PreStoreEventArgs.dbc SRC:PreStore.dbc SRC:PostStoreEventArgs.dbc SRC:PostStore.dbc SRC:FormatTransViewEventArgs.dbc SRC:FormatTransView.dbc SRC:DefineTable.dbc SRC:DefineTableEventArgs.dbc SRC:UpdateFields.dbc SRC:UpdateFieldsEventArgs.dbc SRC:CollectionLoadEventArgs.dbc SRC:CollectionLoad.dbc SRC:OnDelete.dbc SRC:OnDeleteEventArgs.dbc SRC:SDMSio.dbc SRC:SDMSBase.dbc SRC:SDMSTable.dbc SRC:SDMSCollection.dbc 
dbl %COMPILEFLAGS% -TX %VARIANT_FLAGS% -o OBJ:CoreDataEntities.dbo  SRC:DataEntityTypes.dbc SRC:UpdateConflictEventArgs.dbc SRC:UpdateConflict.dbc SRC:PreUpdateEventArgs.dbc SRC:PreUpdate.dbc SRC:PreStoreEventArgs.dbc SRC:PreStore.dbc SRC:PostStoreEventArgs.dbc SRC:PostStore.dbc SRC:FormatTransViewEventArgs.dbc SRC:FormatTransView.dbc SRC:DefineTable.dbc SRC:DefineTableEventArgs.dbc SRC:UpdateFields.dbc SRC:UpdateFieldsEventArgs.dbc SRC:CollectionLoadEventArgs.dbc SRC:CollectionLoad.dbc SRC:OnDelete.dbc SRC:OnDeleteEventArgs.dbc SRC:SDMSio.dbc SRC:SDMSBase.dbc SRC:SDMSTable.dbc SRC:SDMSCollection.dbc 
dblibr -ca OLIB:CoreDataEntities.olb OBJ:CoreDataEntities.dbo 
dblink %LINKERFLAGS% -l EXE:CoreDataEntities.elb OLIB:CoreDataEntities.olb 
endlocal 
