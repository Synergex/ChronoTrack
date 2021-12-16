rem @echo off
rem I disabled regen of code because the routines have now been customized.
goto end
rem
setlocal
set templates=sql_io syn_io_replicate
call codegen -s CONSULTANT_FEE      -t %templates% -r -e
call codegen -s COUNTRY             -t %templates% -r -e
call codegen -s CUSTOMER            -t %templates% -r -e
call codegen -s CUSTOMER_CONTACT    -t %templates% -r -e
call codegen -s CUSTOMER_CONTRACT   -t %templates% -r -e
call codegen -s CUSTOMER_LOCATION   -t %templates% -r -e
call codegen -s EXPENSE_TYPE        -t %templates% -r -e
call codegen -s TASK_TYPE           -t %templates% -r -e
call codegen -s FEE_TYPE            -t %templates% -r -e
call codegen -s PROJECT             -t %templates% -r -e
call codegen -s PROJECT_ACTIVITY    -t %templates% -r -e
call codegen -s PROJECT_ATTACHMENT  -t %templates% -r -e
call codegen -s PROJECT_CONSULTANT  -t %templates% -r -e
call codegen -s PROJECT_EXPENSE     -t %templates% -r -e
call codegen -s PROJECT_NOTE        -t %templates% -r -e
call codegen -s PROJECT_TASK        -t %templates% -r -e
call codegen -s REQUEST             -t %templates% -r -e
call codegen -s STATE               -t %templates% -r -e
call codegen -s USER                -t %templates% -r -e
endlocal
:end
