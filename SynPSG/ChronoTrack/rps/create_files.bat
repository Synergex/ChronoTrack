setlocal
set DAT=%DEVROOT%\rps\newfiles
if not exist %DAT%\. mkdir %DAT%
cd %DAT%
del /s /q %DAT%\*.*
call createfile -s consultant_fee
call createfile -s country
call createfile -s customer
call createfile -s customer_contact
call createfile -s customer_contract
call createfile -s customer_location
call createfile -s expense_type
call createfile -s task_type
call createfile -s fee_type
call createfile -s license_audit
call createfile -s project
call createfile -s project_activity
call createfile -s project_attachment
call createfile -s project_consultant
call createfile -s project_expense
call createfile -s project_note
call createfile -s project_task
call createfile -s request
call createfile -s sql_replication_item
call createfile -s state
call createfile -s user
ipar -gx *.ism
endlocal
