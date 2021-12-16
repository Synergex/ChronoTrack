@echo off
setlocal
if not "%cd%"=="C:\Development\SynPSG" (
  echo ******************************************************************************
  echo *
  echo *
  echo ChronoTrack development environment must be installed in C:\Development\SynPSG
  echo *
  echo *
  echo ******************************************************************************
  goto final
)
rem
rem let's see what options have been passed.
rem null options will display help!!
rem
rem command is;
rem makeChronoTrack Debug|Release IG|DX|MS YES|NO
rem
rem CONFIG is either Debug or Release
rem NSPACE is the required namespace ("IN"=Infragistics, "DX"=DevExpress, "MS"=Microsoft
rem DOPAUSE is set to YES if we wish to pause at the end (default)
rem
set CONFIG=
set NSPACE=
set DOPAUSE=YES
rem
rem sort out what has been set
rem
if "%1" == "debug" set CONFIG=Debug
if "%1" == "DEBUG" set CONFIG=Debug
if "%1" == "Debug" set CONFIG=Debug

if "%1" == "release" set CONFIG=Release
if "%1" == "RELEASE" set CONFIG=Release
if "%1" == "Release" set CONFIG=Release

if "%2" == "in" set NSPACE=ChronoTrackNetUI
if "%2" == "IN" set NSPACE=ChronoTrackNetUI

if "%2" == "dx" set NSPACE=ChronoTrackNetUIDX
if "%2" == "DX" set NSPACE=ChronoTrackNetUIDX

if "%2" == "ms" set NSPACE=ChronoTrackNetUIMS
if "%2" == "MS" set NSPACE=ChronoTrackNetUIMS

if "%2" == "tk" set NSPACE=ChronoTrackNetUITK
if "%2" == "TK" set NSPACE=ChronoTrackNetUITK

if "%2" == "all" set NSPACE=ALL
if "%2" == "ALL" set NSPACE=ALL

if "%3" == "no" set DOPAUSE=NO
if "%3" == "NO" set DOPAUSE=NO

if  "%CONFIG%" == "" goto show_help
if  "%NSPACE%" == "" goto show_help

if "%NSPACE%" == "ChronoTrackNetUITK" set VARIANT_FLAGS=-qvariant=0
if "%NSPACE%" == "ChronoTrackNetUI" set VARIANT_FLAGS=-qvariant=1
if "%NSPACE%" == "ChronoTrackNetUIDX" set VARIANT_FLAGS=-qvariant=2
if "%NSPACE%" == "ChronoTrackNetUIMS" set VARIANT_FLAGS=-qvariant=3
if "%NSPACE%" == "ALL" set VARIANT_FLAGS=-qvariant=4

rem do processing

if EXIST setvs.bat call setvs.bat

if EXIST performance.txt del performance.txt
echo ******************************>> performance.txt
echo ******************************>> performance.txt
TIME /T >> performance.txt
@echo off
set sfwinipath=c:\Development\SynPSG\ini
call c:\development\SynPSG\ChronoTrack\rps\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\smc\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\src\Assembly\makeit.bat
@echo on
if "%NSPACE%" == "ChronoTrackNetUITK" goto no_dot_net
call c:\development\SynPSG\NetCommon\bat\buildAssembly.bat %CONFIG% %NSPACE%
@echo on
call c:\development\SynPSG\NetCommon\bat\addToGAC.bat %CONFIG% %NSPACE%
@echo on
call c:\development\SynPSG\NetCommon\bat\build.bat %CONFIG% %NSPACE%
@echo on
goto synergy_stuff
:no_dot_net
rem here is where we can create a dummy logging, etc
:synergy_stuff
call c:\development\SynPSG\Core\src\Utilities\makeit.bat
@echo on
call c:\development\SynPSG\Core\src\DataEntities\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\src\DataEntities\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\src\Subroutines\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\src\Applications\makeit.bat
@echo on
net stop chronotrackreplicator
if "%ERRORLEVEL%"=="0" set RESTART_REPLICATOR=YES
call c:\development\SynPSG\ChronoTrack\src\SqlApi\makeit.bat
if "%RESTART_REPLICATOR"=="YES" net start chronotrackreplicator
@echo on
call c:\development\SynPSG\ChronoTrack\src\Server\makeit.bat
@echo on
call c:\development\SynPSG\ChronoTrack\src\Toolkit\makeit.bat
@echo off
@echo on
if "%NSPACE%" == "ChronoTrackNetUITK" goto no_web
call C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackWS\makeit.bat %CONFIG%
call C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoTrackMonitor\makeit.bat %CONFIG%
call C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoWebDX\makeit.bat %CONFIG%
call C:\Development\SynPSG\ChronoTrack\VSSolutions\ChronoMobile\makeit.bat %CONFIG%
call C:\Development\SynPSG\ChronoTrack\VSSolutions\LicensingDashboard\makeit.bat %CONFIG%
call C:\Development\SynPSG\ChronoTrack\VSSolutions\ODBCdashboard\makeit.bat %CONFIG%
:no_web
@echo off
TIME /T >> performance.txt
echo ******************************>> performance.txt
echo ******************************>> performance.txt
type performance.txt
del /F /Q performance.txt
if "%DOPAUSE%" == "YES" pause
goto final
rem
:show_help
rem
rem sho help screen
rem
echo ********************************************************************
echo * MakeChronoTrack - build the ChronoTrack system
echo *
echo * "MakeChronoTrack Debug|Release IN|DX|MS|ALL NO"
echo *
echo * Where:
echo *    Configuration :
echo *        Debug - Build the debug version of the UI controls
echo *        Release - Build the release version
echo *
echo *    Environment :
echo *        IN - build Infragistics version
echo *        DX - build DevExpress version
echo *        MS - Build Microsoft version
echo *        TK - Build Synergy Toolkit version
echo *        ALL - Build a version using everything!!
echo *
echo *    wait :
echo *        YES (default) - cause the script to key for a key press
echo *        NO - no wait when script complete
echo *
echo ********************************************************************
goto final
rem
:final
endlocal

