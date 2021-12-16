@echo off
setlocal
rem
rem Delete any existing exception files
rem
echo Deleting any old exception files...
if exist %DAT%\activity.exc del /q %DAT%\activity.exc
if exist %DAT%\attachment.exc del /q %DAT%\attachment.exc
if exist %DAT%\consultant.exc del /q %DAT%\consultant.exc
if exist %DAT%\contact.exc del /q %DAT%\contact.exc
if exist %DAT%\contract.exc del /q %DAT%\contract.exc
if exist %DAT%\country.exc del /q %DAT%\country.exc
if exist %DAT%\customer.exc del /q %DAT%\customer.exc
if exist %DAT%\expense.exc del /q %DAT%\expense.exc
if exist %DAT%\expensetype.exc del /q %DAT%\expensetype.exc
if exist %DAT%\tasktype.exc del /q %DAT%\tasktype.exc
if exist %DAT%\fee.exc del /q %DAT%\fee.exc
if exist %DAT%\feetype.exc del /q %DAT%\feetype.exc
if exist %DAT%\location.exc del /q %DAT%\location.exc
if exist %DAT%\note.exc del /q %DAT%\note.exc
if exist %DAT%\project.exc del /q %DAT%\project.exc
if exist %DAT%\request.exc del /q %DAT%\request.exc
if exist %DAT%\state.exc del /q %DAT%\state.exc
if exist %DAT%\task.exc del /q %DAT%\task.exc
if exist %DAT%\user.exc del /q %DAT%\user.exc
rem
rem Make sure we have all the sequential files that we need
rem
echo Checking that sequential files exist...
if not exist %DAT%\activity.seq goto missing_seq
if not exist %DAT%\attachment.seq goto missing_seq
if not exist %DAT%\consultant.seq goto missing_seq
if not exist %DAT%\contact.seq goto missing_seq
if not exist %DAT%\contract.seq goto missing_seq
if not exist %DAT%\country.seq goto missing_seq
if not exist %DAT%\customer.seq goto missing_seq
if not exist %DAT%\expense.seq goto missing_seq
if not exist %DAT%\expensetype.seq goto missing_seq
if not exist %DAT%\tasktype.seq goto missing_seq
if not exist %DAT%\fee.seq goto missing_seq
if not exist %DAT%\feetype.seq goto missing_seq
if not exist %DAT%\location.seq goto missing_seq
if not exist %DAT%\note.seq goto missing_seq
if not exist %DAT%\project.seq goto missing_seq
if not exist %DAT%\request.seq goto missing_seq
if not exist %DAT%\state.seq goto missing_seq
if not exist %DAT%\task.seq goto missing_seq
if not exist %DAT%\user.seq goto missing_seq
rem
rem Make sure that we have all the XDL files that we need
rem
echo Checking that XDL files exist...
if not exist %XDL%\activity.xdl ipar -x %DAT%\activity.ism > %XDL%\activity.xdl
if not exist %XDL%\attachment.xdl ipar -x %DAT%\attachment.ism > %XDL%\attachment.xdl
if not exist %XDL%\consultant.xdl ipar -x %DAT%\consultant.ism > %XDL%\consultant.xdl
if not exist %XDL%\contact.xdl ipar -x %DAT%\contact.ism > %XDL%\contact.xdl
if not exist %XDL%\contract.xdl ipar -x %DAT%\contract.ism > %XDL%\contract.xdl
if not exist %XDL%\country.xdl ipar -x %DAT%\country.ism > %XDL%\country.xdl
if not exist %XDL%\customer.xdl ipar -x %DAT%\customer.ism > %XDL%\customer.xdl
if not exist %XDL%\expense.xdl ipar -x %DAT%\expense.ism > %XDL%\expense.xdl
if not exist %XDL%\expensetype.xdl ipar -x %DAT%\expensetype.ism > %XDL%\expensetype.xdl
if not exist %XDL%\tasktype.xdl ipar -x %DAT%\tasktype.ism > %XDL%\tasktype.xdl
if not exist %XDL%\fee.xdl ipar -x %DAT%\fee.ism > %XDL%\fee.xdl
if not exist %XDL%\feetype.xdl ipar -x %DAT%\feetype.ism > %XDL%\feetype.xdl
if not exist %XDL%\login_audit.xdl ipar -x %DAT%\login_audit.ism > %XDL%\login_audit.xdl
if not exist %XDL%\location.xdl ipar -x %DAT%\location.ism > %XDL%\location.xdl
if not exist %XDL%\note.xdl ipar -x %DAT%\note.ism > %XDL%\note.xdl
if not exist %XDL%\project.xdl ipar -x %DAT%\project.ism > %XDL%\project.xdl
if not exist %XDL%\replication.xdl ipar -x %DAT%\replication.ism > %XDL%\replication.xdl
if not exist %XDL%\request.xdl ipar -x %DAT%\request.ism > %XDL%\request.xdl
if not exist %XDL%\state.xdl ipar -x %DAT%\state.ism > %XDL%\state.xdl
if not exist %XDL%\task.xdl ipar -x %DAT%\task.ism > %XDL%\task.xdl
if not exist %XDL%\user.xdl ipar -x %DAT%\user.ism > %XDL%\user.xdl
rem
rem Delete the existing ISAM and IS1 files
rem
echo Deleting ISAM files...
if exist %DAT%\activity.ism del /q %DAT%\activity.ism
if exist %DAT%\attachment.ism del /q %DAT%\attachment.ism
if exist %DAT%\consultant.ism del /q %DAT%\consultant.ism
if exist %DAT%\contact.ism del /q %DAT%\contact.ism
if exist %DAT%\contract.ism del /q %DAT%\contract.ism
if exist %DAT%\country.ism del /q %DAT%\country.ism
if exist %DAT%\customer.ism del /q %DAT%\customer.ism
if exist %DAT%\expense.ism del /q %DAT%\expense.ism
if exist %DAT%\expensetype.ism del /q %DAT%\expensetype.ism
if exist %DAT%\tasktype.ism del /q %DAT%\tasktype.ism
if exist %DAT%\fee.ism del /q %DAT%\fee.ism
if exist %DAT%\feetype.ism del /q %DAT%\feetype.ism
if exist %DAT%\location.ism del /q %DAT%\location.ism
if exist %DAT%\note.ism del /q %DAT%\note.ism
if exist %DAT%\project.ism del /q %DAT%\project.ism
if exist %DAT%\replication.ism del /q %DAT%\replication.ism
if exist %DAT%\request.ism del /q %DAT%\request.ism
if exist %DAT%\state.ism del /q %DAT%\state.ism
if exist %DAT%\task.ism del /q %DAT%\task.ism
if exist %DAT%\user.ism del /q %DAT%\user.ism
if exist %DAT%\login_audit.ism del /q %DAT%\login_audit.ism
if exist %DAT%\activity.is1 del /q %DAT%\activity.is1
if exist %DAT%\attachment.is1 del /q %DAT%\attachment.is1
if exist %DAT%\consultant.is1 del /q %DAT%\consultant.is1
if exist %DAT%\contact.is1 del /q %DAT%\contact.is1
if exist %DAT%\contract.is1 del /q %DAT%\contract.is1
if exist %DAT%\country.is1 del /q %DAT%\country.is1
if exist %DAT%\customer.is1 del /q %DAT%\customer.is1
if exist %DAT%\expense.is1 del /q %DAT%\expense.is1
if exist %DAT%\expensetype.is1 del /q %DAT%\expensetype.is1
if exist %DAT%\tasktype.is1 del /q %DAT%\tasktype.is1
if exist %DAT%\fee.is1 del /q %DAT%\fee.is1
if exist %DAT%\feetype.is1 del /q %DAT%\feetype.is1
if exist %DAT%\location.is1 del /q %DAT%\location.is1
if exist %DAT%\note.is1 del /q %DAT%\note.is1
if exist %DAT%\project.is1 del /q %DAT%\project.is1
if exist %DAT%\replication.is1 del /q %DAT%\replication.is1
if exist %DAT%\request.is1 del /q %DAT%\request.is1
if exist %DAT%\state.is1 del /q %DAT%\state.is1
if exist %DAT%\task.is1 del /q %DAT%\task.is1
if exist %DAT%\user.is1 del /q %DAT%\user.is1
if exist %DAT%\login_audit.is1 del /q %DAT%\login_audit.is1
rem
rem Load the ISAM files from the sequential files
rem
echo Creating new ISAM files...
fconvert -it DAT:activity.seq -oi DAT:activity.ism -d XDL:activity.xdl
fconvert -it DAT:attachment.seq -oi DAT:attachment.ism -d XDL:attachment.xdl
fconvert -it DAT:consultant.seq -oi DAT:consultant.ism -d XDL:consultant.xdl
fconvert -it DAT:contact.seq -oi DAT:contact.ism -d XDL:contact.xdl
fconvert -it DAT:contract.seq -oi DAT:contract.ism -d XDL:contract.xdl
fconvert -it DAT:country.seq -oi DAT:country.ism -d XDL:country.xdl
fconvert -it DAT:customer.seq -oi DAT:customer.ism -d XDL:customer.xdl
fconvert -it DAT:expense.seq -oi DAT:expense.ism -d XDL:expense.xdl
fconvert -it DAT:expensetype.seq -oi DAT:expensetype.ism -d XDL:expensetype.xdl
fconvert -it DAT:login_audit.seq -oi DAT:login_audit.ism -d XDL:login_audit.xdl
fconvert -it DAT:tasktype.seq -oi DAT:tasktype.ism -d XDL:tasktype.xdl
fconvert -it DAT:fee.seq -oi DAT:fee.ism -d XDL:fee.xdl
fconvert -it DAT:feetype.seq -oi DAT:feetype.ism -d XDL:feetype.xdl
fconvert -it DAT:location.seq -oi DAT:location.ism -d XDL:location.xdl
fconvert -it DAT:note.seq -oi DAT:note.ism -d XDL:note.xdl
fconvert -it DAT:project.seq -oi DAT:project.ism -d XDL:project.xdl
fconvert -it DAT:request.seq -oi DAT:request.ism -d XDL:request.xdl
fconvert -it DAT:state.seq -oi DAT:state.ism -d XDL:state.xdl
fconvert -it DAT:task.seq -oi DAT:task.ism -d XDL:task.xdl
fconvert -it DAT:user.seq -oi DAT:user.ism -d XDL:user.xdl
cd ..\dat
dbs DBLDIR:bldism -k XDL:replication.xdl
cd ..\rps
goto end
rem
rem
rem
:missing_seq
echo *** ERROR *** One or more sequential files were missing!
goto end
rem
:end
endlocal
