setlocal
rem
rem Delete any existing sequential files
rem
if exist %DAT%\activity.seq del /q %DAT%\activity.seq
if exist %DAT%\attachment.seq del /q %DAT%\attachment.seq
if exist %DAT%\consultant.seq del /q %DAT%\consultant.seq
if exist %DAT%\contact.seq del /q %DAT%\contact.seq
if exist %DAT%\contract.seq del /q %DAT%\contract.seq
if exist %DAT%\country.seq del /q %DAT%\country.seq
if exist %DAT%\customer.seq del /q %DAT%\customer.seq
if exist %DAT%\expense.seq del /q %DAT%\expense.seq
if exist %DAT%\expensetype.seq del /q %DAT%\expensetype.seq
if exist %DAT%\tasktype.seq del /q %DAT%\tasktype.seq
if exist %DAT%\fee.seq del /q %DAT%\fee.seq
if exist %DAT%\feetype.seq del /q %DAT%\feetype.seq
if exist %DAT%\location.seq del /q %DAT%\location.seq
if exist %DAT%\note.seq del /q %DAT%\note.seq
if exist %DAT%\project.seq del /q %DAT%\project.seq
if exist %DAT%\request.seq del /q %DAT%\request.seq
if exist %DAT%\state.seq del /q %DAT%\state.seq
if exist %DAT%\task.seq del /q %DAT%\task.seq
if exist %DAT%\user.seq del /q %DAT%\user.seq
rem
rem Unload the ISAM files to new sequential files
rem
fconvert -ii DAT:activity.ism -ot DAT:activity.seq
fconvert -ii DAT:attachment.ism -ot DAT:attachment.seq
fconvert -ii DAT:consultant.ism -ot DAT:consultant.seq
fconvert -ii DAT:contact.ism -ot DAT:contact.seq
fconvert -ii DAT:contract.ism -ot DAT:contract.seq
fconvert -ii DAT:country.ism -ot DAT:country.seq
fconvert -ii DAT:customer.ism -ot DAT:customer.seq
fconvert -ii DAT:expense.ism -ot DAT:expense.seq
fconvert -ii DAT:expensetype.ism -ot DAT:expensetype.seq
fconvert -ii DAT:tasktype.ism -ot DAT:tasktype.seq
fconvert -ii DAT:fee.ism -ot DAT:fee.seq
fconvert -ii DAT:feetype.ism -ot DAT:feetype.seq
fconvert -ii DAT:location.ism -ot DAT:location.seq
fconvert -ii DAT:note.ism -ot DAT:note.seq
fconvert -ii DAT:project.ism -ot DAT:project.seq
fconvert -ii DAT:request.ism -ot DAT:request.seq
fconvert -ii DAT:state.ism -ot DAT:state.seq
fconvert -ii DAT:task.ism -ot DAT:task.seq
fconvert -ii DAT:user.ism -ot DAT:user.seq
rem
endlocal
