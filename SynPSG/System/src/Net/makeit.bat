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
set PROJECT=Net

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
set NAMESPACE=SynPSG-System-Net
set SYNDEFNS=SynPSG.System.Net

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
if EXIST C:\Development\SynPSG\System\lib\SynPSGSystemNet.olb del /F /Q C:\Development\SynPSG\System\lib\SynPSGSystemNet.olb 
if EXIST C:\Development\SynPSG\System\obj\Net\SynPSGSystemNet.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\SynPSGSystemNet.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\testmail.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\testmail.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\testftp.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\testftp.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\ContentType.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\ContentType.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\ContentDisposition.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\ContentDisposition.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\IPEndPoint.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\IPEndPoint.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\Socket.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\Socket.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\NetworkStream.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\NetworkStream.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\TcpClient.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\TcpClient.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\AttachmentBase.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\AttachmentBase.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\Attachment.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\Attachment.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\AttachmentCollection.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\AttachmentCollection.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\MailAddress.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\MailAddress.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\MailAddressCollection.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\MailAddressCollection.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\MailMessage.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\MailMessage.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\SmtpClient.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\SmtpClient.dbo 
if EXIST C:\Development\SynPSG\System\obj\Net\FtpClient.dbo del /F /Q C:\Development\SynPSG\System\obj\Net\FtpClient.dbo 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-ContentType.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-ContentType.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-ContentDisposition.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-ContentDisposition.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-IPEndPoint.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-IPEndPoint.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-Socket.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-Socket.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-NetworkStream.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-NetworkStream.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-TcpClient.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-TcpClient.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-AttachmentBase.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-AttachmentBase.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-Attachment.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-Attachment.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-AttachmentCollection.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-AttachmentCollection.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailAddress.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailAddress.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailAddressCollection.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailAddressCollection.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailMessage.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-MailMessage.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-SmtpClient.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-SmtpClient.dbh 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-FtpClient.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-FtpClient.dbh 
if "%NAMESPACE%" == "*" goto main_line 
if EXIST C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh del /F /Q C:\Development\SynPSG\System\hdr\%NAMESPACE%-*.dbh 
:main_line 
@echo on 
dblproto %VARIANT_FLAGS% SRC:ContentType.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ContentType.dbo SRC:ContentType.dbc 
dblproto %VARIANT_FLAGS% SRC:ContentDisposition.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:ContentDisposition.dbo SRC:ContentDisposition.dbc 
dblproto %VARIANT_FLAGS% SRC:IPEndPoint.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:IPEndPoint.dbo SRC:IPEndPoint.dbc 
dblproto %VARIANT_FLAGS% SRC:Socket.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:Socket.dbo SRC:Socket.dbc 
dblproto %VARIANT_FLAGS% SRC:NetworkStream.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:NetworkStream.dbo SRC:NetworkStream.dbc 
dblproto %VARIANT_FLAGS% SRC:TcpClient.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:TcpClient.dbo SRC:TcpClient.dbc 
dblproto %VARIANT_FLAGS% SRC:AttachmentBase.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:AttachmentBase.dbo SRC:AttachmentBase.dbc 
dblproto %VARIANT_FLAGS% SRC:Attachment.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:Attachment.dbo SRC:Attachment.dbc 
dblproto %VARIANT_FLAGS% SRC:AttachmentCollection.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:AttachmentCollection.dbo SRC:AttachmentCollection.dbc 
dblproto %VARIANT_FLAGS% SRC:MailAddress.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:MailAddress.dbo SRC:MailAddress.dbc 
dblproto %VARIANT_FLAGS% SRC:MailAddressCollection.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:MailAddressCollection.dbo SRC:MailAddressCollection.dbc 
dblproto %VARIANT_FLAGS% SRC:MailMessage.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:MailMessage.dbo SRC:MailMessage.dbc 
dblproto %VARIANT_FLAGS% SRC:SmtpClient.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:SmtpClient.dbo SRC:SmtpClient.dbc 
dblproto %VARIANT_FLAGS% SRC:FtpClient.dbc 
dbl %COMPILEFLAGS% -TX -WD=919 %VARIANT_FLAGS%  -o OBJ:FtpClient.dbo SRC:FtpClient.dbc 
dblibr -ca OLIB:SynPSGSystemNet.olb 
dblibr -w -r OLIB:SynPSGSystemNet.olb  OBJ:ContentType.dbo OBJ:ContentDisposition.dbo OBJ:IPEndPoint.dbo OBJ:Socket.dbo OBJ:NetworkStream.dbo OBJ:TcpClient.dbo OBJ:AttachmentBase.dbo OBJ:Attachment.dbo OBJ:AttachmentCollection.dbo OBJ:MailAddress.dbo OBJ:MailAddressCollection.dbo OBJ:MailMessage.dbo OBJ:SmtpClient.dbo OBJ:FtpClient.dbo 
dblink %LINKERFLAGS% -l EXE:SynPSGSystemNet.elb OLIB:SynPSGSystemNet.olb  
endlocal 
