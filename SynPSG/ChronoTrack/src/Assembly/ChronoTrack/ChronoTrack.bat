IF EXIST "ChronoTrack.dll" del "ChronoTrack.dll"
IF NOT EXIST "ChronoTrack.snk" sn -k "ChronoTrack.snk"
if '%1' == '-p' goto pooling
csc /nologo /target:library /out:"ChronoTrack.dll" /reference:"%XFNLNET%\xfnlnet.dll" /optimize /keyfile:"ChronoTrack.snk" %SYNCSCOPT% @ChronoTrack.rsp
goto done
:pooling
csc /nologo /target:library /define:POOLING /out:"ChronoTrack.dll" /reference:"%XFNLNET%\xfnlnet.dll" /optimize /keyfile:"ChronoTrack.snk" %SYNCSCOPT% @ChronoTrack.rsp
:done
