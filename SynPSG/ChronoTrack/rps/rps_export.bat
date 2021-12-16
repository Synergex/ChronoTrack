if exist %DEVROOT%\rps\rpsschema.sch del /q %DEVROOT%\rps\rpsschema.sch
if exist %DEVROOT%\rps\rpsschema.sch goto delete_fail
dbs RPS:rpsutl -e %DEVROOT%\rps\rpsschema.sch
goto done
:delete_fail
echo *ERROR* Failed to delete existing schema, did you check it out first?
:done