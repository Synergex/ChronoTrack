set SRCDEV=C
set DEVAREA=Development\SynPSG
set WORKSPACE=ChronoTrack
set ROOTFOLDER=%DEVAREA%\%WORKSPACE%
set DEVROOT=%SRCDEV%:\%ROOTFOLDER%
set EXE=%DEVROOT%\exe

dbssvc -cChronoTrackReplicator -r -d"ChronoTrack Replication Server" EXE:ChronoTrackReplicator.dbr
sc config ChronoTrackReplicator depend= lanmanworkstation/Eventlog/SynLM/MSSQLSERVER start= delayed-auto
