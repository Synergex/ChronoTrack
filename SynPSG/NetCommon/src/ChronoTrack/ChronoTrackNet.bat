rem
rem scriptto build the ChronoTrack Infragistics .NET wrappers
rem

rem clean up before we generate

if EXIST %SRCDIR%\*.dbl del /F /Q %SRCDIR%\ChronoTrackNet.dbl
if EXIST %SRCDIR%\*.inc del /F /Q %SRCDIR%\ChronoTrackNet.inc

gennet -o SRCDIR:ChronoTrackNet.dbl -s %SRCDIR%\ChronoTrackNetUI.xml -s %SRCDIR%\ChronoTrackNetUIDX.xml -s %SRCDIR%\ChronoTrackNetMS.xml -s %CORESRCDIR%\SynPSGNetCode.xml
dblproto -expdir HDRDIR: SRCDIR:ChronoTrackNet.dbl
dbl -qrelax:interop -W0 -o OBJDIR:ChronoTrackNet.dbo SRCDIR:ChronoTrackNet.dbl
dblibr -ca LIBDIR:ChronoTrackNet.olb OBJDIR:ChronoTrackNet

