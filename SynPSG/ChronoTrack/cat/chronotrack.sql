select * from genesis_views

drop view projsummary

CREATE VIEW PROJSUMMARY AS
SELECT CUSTOMER.COMPANY, PROJECT.PROJECT_ID, PROJECT.CUSTOMER_ID, PROJECT.CONTRACT_ID, PROJECT.CONTRACT_PROJECT_ID, PROJECT.DESCRIPTION,  PROJECT.START_DATE, PROJECT.END_DATE, PROJECT.CURRENT_STATUS, PROJECT.LEAD_CONSULTANT, PROJECT.WORK_LOCATION_ID,  PROJECT.TEXT, LOCATION.DESCRIPTION AS LocDesc FROM PROJECT left outer join LOCATION on PROJECT.CUSTOMER_ID = LOCATION.CUSTOMER_ID and PROJECT.WORK_LOCATION_ID = LOCATION.LOCATION_ID left outer join CUSTOMER on PROJECT.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID

drop view projexpenses

CREATE VIEW PROJEXPENSES AS
SELECT CUSTOMER.COMPANY, PROJECT.PROJECT_ID, PROJECT.CUSTOMER_ID, PROJECT.CONTRACT_ID, PROJECT.CONTRACT_PROJECT_ID, PROJECT.DESCRIPTION,  PROJECT.START_DATE, PROJECT.END_DATE, PROJECT.CURRENT_STATUS, PROJECT.LEAD_CONSULTANT, PROJECT.WORK_LOCATION_ID,  PROJECT.TEXT, LOCATION.DESCRIPTION AS LocDesc, EXPENSE.EXPENSE_TYPE, EXPENSE.EXPENSE_DATE, EXPENSE.EXPENSED_BY,  (EXPENSE.UNIT_PRICE*EXPENSE.QUANTITY) AS ExpAmt, EXPENSETYPE.DESCRIPTION as ExpDesc, CHRONOTRACK_USER.FRIENDLY_NAME
FROM PROJECT left outer join LOCATION on PROJECT.CUSTOMER_ID = LOCATION.CUSTOMER_ID and PROJECT.WORK_LOCATION_ID = LOCATION.LOCATION_ID left outer join CUSTOMER on PROJECT.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID left outer join EXPENSE on EXPENSE.PROJECT_ID = PROJECT.PROJECT_ID left outer join EXPENSETYPE on EXPENSETYPE.EXPENSE_TYPE_ID = EXPENSE.EXPENSE_TYPE left outer join CHRONOTRACK_USER on CHRONOTRACK_USER.USER_ID = EXPENSE.EXPENSED_BY

drop view projfees

CREATE VIEW PROJFEES AS
SELECT CUSTOMER.COMPANY, PROJECT.PROJECT_ID, PROJECT.CUSTOMER_ID, PROJECT.CONTRACT_ID, PROJECT.CONTRACT_PROJECT_ID, PROJECT.DESCRIPTION,  PROJECT.START_DATE as ProjectStartDate, PROJECT.END_DATE as ProjectEndDate, PROJECT.CURRENT_STATUS, TASK.TASK_ID, TASK.TASK_TYPE, TASK.DESCRIPTION as TaskDesc, TASK.ASSIGNED_TO, TASK.START_DATE, TASK.START_TIME, TASK.END_DATE, TASK.END_TIME, TASK.BILLABLE_HOURS, TASK.LOCATION as TaskLocation, TASKTYP.TASK_TYPE_ID, TASKTYP.DESCRIPTION as TaskTypeDesc, LOCATION.DESCRIPTION AS TaskLocDesc, (TASK.BILLABLE_HOURS*CONSULTANT.FEE) AS BillableAmt FROM PROJECT left outer join TASK on TASK.PROJECT_ID = PROJECT.PROJECT_ID left outer join LOCATION on PROJECT.CUSTOMER_ID = LOCATION.CUSTOMER_ID and TASK.LOCATION = LOCATION.LOCATION_ID left outer join CUSTOMER on PROJECT.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID left outer join TASKTYP on TASKTYP.TASK_TYPE_ID = TASK.TASK_TYPE left outer join CHRONOTRACK_USER on CHRONOTRACK_USER.USER_ID = TASK.ASSIGNED_TO left outer join CONSULTANT on TASK.PROJECT_ID=CONSULTANT.PROJECT_ID AND TASK.ASSIGNED_TO=CONSULTANT.CONSULTANT_ID

drop view projhours

CREATE VIEW PROJHOURS AS
SELECT CUSTOMER.COMPANY, PROJECT.PROJECT_ID, PROJECT.CUSTOMER_ID, PROJECT.CONTRACT_ID, PROJECT.CONTRACT_PROJECT_ID, PROJECT.DESCRIPTION,  PROJECT.START_DATE as ProjectStartDate, PROJECT.END_DATE as ProjectEndDate, PROJECT.CURRENT_STATUS, PROJECT.LEAD_CONSULTANT, PROJECT.WORK_LOCATION_ID,  PROJECT.TEXT, TASK.TASK_ID, TASK.TASK_TYPE, TASK.DESCRIPTION as TaskDesc, TASK.ASSIGNED_TO, TASK.START_DATE, TASK.START_TIME, TASK.END_DATE, TASK.END_TIME, TASK.BILLABLE_HOURS, TASK.LOCATION as TaskLocation, TASKTYP.TASK_TYPE_ID, TASKTYP.DESCRIPTION as TaskTypeDesc, LOCATION.DESCRIPTION AS TaskLocDesc FROM PROJECT left outer join TASK on TASK.PROJECT_ID = PROJECT.PROJECT_ID left outer join LOCATION on PROJECT.CUSTOMER_ID = LOCATION.CUSTOMER_ID and TASK.LOCATION = LOCATION.LOCATION_ID left outer join CUSTOMER on PROJECT.CUSTOMER_ID = CUSTOMER.CUSTOMER_ID left outer join TASKTYP on TASKTYP.TASK_TYPE_ID = TASK.TASK_TYPE left outer join CHRONOTRACK_USER on CHRONOTRACK_USER.USER_ID = TASK.ASSIGNED_TO

