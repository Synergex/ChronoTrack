setlocal

if "%LIBPATH%" NEQ "" goto loaded
if EXIST "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "C:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86
if EXIST "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" call "D:\Program Files\Microsoft Visual Studio 9.0\VC\vcvarsall.bat" x86

:loaded
set XSHOW=HIDE
set PATH=%PATH%;%XFNLNET%
dbr DBLDIR:genxml -f ChronoTrack -i ChronoTrack -d C:\development\SynPSG\ChronoTrack\src\assembly -s C:\development\SynPSG\ChronoTrack\smc -m C:\development\SynPSG\ChronoTrack\rps\rpsmain.ism -t C:\development\SynPSG\ChronoTrack\rps\rpstext.ism -v 0
gencs -f C:\development\SynPSG\ChronoTrack\src\assembly\ChronoTrack.xml -d C:\development\SynPSG\ChronoTrack\src\Assembly -n ChronoTrack -v 0
cd C:\development\SynPSG\ChronoTrack\src\Assembly\ChronoTrack
set XSHOW=
call ChronoTrack.bat
call \Development\SynPSG\NetCommon\bat\AddToGac final !
endlocal
