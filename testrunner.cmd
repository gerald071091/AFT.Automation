@echo off
setlocal EnableDelayedExpansion

:continue

pushd %~dp0

%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe "AFT.Automation.UnitTest\AFT.Automation.UnitTest.csproj"

if ERRORLEVEL 1 goto retest

cd D:\AFT\AFT.SeleniumTest\AFT.Automation(Final)\aft.automation\packages\SpecRun.Runner.1.5.2\tools

set profile=%1
if "%profile%" == "" set profile=Default

set /p feature=Feature to run?
2>nul call :case_%feature%
if ERRORLEVEL 1 call :default_case
:case_login
:case_Login
:case_registration
:case_Registration
goto singleProcess
:case_all
:case_All
goto allProcess
:default_case
goto retest

:retest
set /p rfeature=Feature is not valid, Do you want to continue (Y/N)?
2>nul call :case_%rfeature%
if ERRORLEVEL 1 call :default_case
:case_n
:case_N
:default_case
goto end
:case_y
:case_Y
goto continue

:singleProcess
call :camelCase result "%feature%"
SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\AFT.Automation.UnitTest\bin\Debug" /filter:"@!result!" "/outputFolder:%~dp0\TestResults" /log:specrun.log %2 %3 %4 %5

popd
goto eof

:allProcess
SpecRun.exe run %profile%.srprofile "/baseFolder:%~dp0\AFT.Automation.UnitTest\bin\Debug" "/outputFolder:%~dp0\TestResults" /log:specrun.log %2 %3 %4 %5

popd
goto eof

:eof
set /p choice=Do you want to test again (Y/N)?
2>nul call :case_%choice%
if ERRORLEVEL 1 call :default_case
:case_n
:case_N
:default_case
goto end
:case_y
:case_Y
goto continue

:end
exit

:camelCase
setlocal EnableDelayedExpansion
set "temp=%~2"
set "helper=##AABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVVWWXXYYZZ"
set "first=!helper:*%temp:~0,1%=!"
set "first=!first:~0,1!"
if "!first!"=="#" set "first=!temp:~0,1!"
set "temp=!first!!temp:~1!"
(
    endlocal
    set "result=%temp%"
)







