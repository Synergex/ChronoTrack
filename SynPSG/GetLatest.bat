@echo off

if "%VAULT_USER%"=="" goto error_user
if "%VAULT_PASSWORD%"=="" goto error_password

setlocal

set VAULT_SERVER=psgapps.synergex.com
set VAULT_REPOSITORY=PSG Projects
set VAULT_PATH=$/Development/SynPSG/
set VAULT_TARGET=C:\Development\SynPSG

echo Setting Vault authentication ...
vault rememberlogin -host %VAULT_SERVER% -user "%VAULT_USER%" -password "%VAULT_PASSWORD%" > nul
if not "%ERRORLEVEL%"=="0" goto error_login

echo Getting latest version of %VAULT_PATH% in  %VAULT_TARGET% ...
vault get -repository "%VAULT_REPOSITORY%" -workingfolder "%VAULT_TARGET%" %VAULT_PATH%  > nul
if not "%ERRORLEVEL%"=="0" goto error_get

goto done

:error_user
echo ERROR: Set your Vault username in environment variable VAULT_USER
goto end

:error_password
echo ERROR: Set your Vault password in environment variable VAULT_PASSWORD
goto end

:error_login
echo ERROR: Failed to set authentication. Check environment variables VAULT_USER and VAULT_PASSWORD
goto done

:error_get
echo ERROR: Failed to get latest files.
goto done

:done
vault forgetlogin > nul

endlocal

:end
