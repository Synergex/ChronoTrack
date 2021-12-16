setlocal
@echo off
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
set DOPAUSE=YES

if "%1" == "no" set DOPAUSE=NO
if "%1" == "NO" set DOPAUSE=NO

if EXIST performance.txt del performance.txt
echo ******************************>> performance.txt
echo ******************************>> performance.txt
TIME /T >> performance.txt
@echo off
set sfwinipath=c:\Development\SynPSG\ini
call c:\development\SynPSG\System\src\base\makeit.bat
@echo on
call c:\development\SynPSG\System\src\IO\makeit.bat
@echo on
call c:\development\SynPSG\System\src\Text\makeit.bat
@echo on
call c:\development\SynPSG\System\src\Net\makeit.bat
@echo off
TIME /T >> performance.txt
echo ******************************>> performance.txt
echo ******************************>> performance.txt
type performance.txt
del /F /Q performance.txt
if "%DOPAUSE%" == "YES" pause
:final
endlocal

