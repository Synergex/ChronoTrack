rem
rem script to build the SynPSGNetCore .NET wrappers
rem

set CORENETBIN=C:\Development\SynPSG\Core\VSSolutions\SynPSGNetCore\bin\%CONFIGURATION%

rem clean up before we generate

if EXIST %SRCDIR%\*.dbl del %SRCDIR%\*.dbl
if EXIST %SRCDIR%\*.inc del %SRCDIR%\*.inc

gennet -s -o SRCDIR:SynPSGNetCore.dbl %SRCDIR%\SynPSGNetCore.xml
dblproto -expdir HDRDIR: SRCDIR:SynPSGNetCore.dbl
dbl -qrelax:interop -W0 -o OBJDIR:SynPSGNetCore.dbo SRCDIR:SynPSGNetCore.dbl
dblibr -ca LIBDIR:SynPSGNetCore.olb OBJDIR:SynPSGNetCore
dblink -l EXEDIR:SynPSGNetCore.elb LIBDIR:SynPSGNetCore.olb

