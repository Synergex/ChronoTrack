rem
rem build SMC
rem
set XSHOW=HIDE

set RPSMFIL=C:\Development\SynPSG\ChronoTrack\rps\rpsmain.ism
set RPSTFIL=C:\Development\SynPSG\ChronoTrack\rps\rpstext.ism

if exist C:\Development\SynPSG\ChronoTrack\smc\cdt.ism del /Q C:\Development\SynPSG\ChronoTrack\smc\cdt.is*
if exist C:\Development\SynPSG\ChronoTrack\smc\cmpdt.ism del /Q C:\Development\SynPSG\ChronoTrack\smc\cmpdt.is*

set SRC=C:\Development\SynPSG\ChronoTrack\smc
set XFPL_SMCPATH=C:\Development\SynPSG\ChronoTrack\smc
dbr DBLDIR:mdu -m %RPSMFIL% -t %RPSTFIL% -i SRC:smcschema.xml
set XSHOW=