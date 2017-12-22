Design/Approach Framework:
* Page Object Model pattern
* Object Repository
* Factory design pattern
* Data driven Approach
* Modular Approach
* Business Driven Development (SpecFlow)

Things to download (http://www.seleniumhq.org/download/):
* ChromeDriver
* IEDriver
* GeckoDriver(Firefox)
* Selenium server

Tools used for automation:
* Nunit (https://www.nunit.org/)
* Selenium (http://www.seleniumhq.org/)
* SpecFlow (http://www.specflow.org/)

CREATE HUB AND NODE USING DEFAULT CONFIG

Create selenium grid hub with default config:
* java -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role hub -port <serverPort#>

Create selenium grid node with multiple driver accessibility:
* java -Dwebdriver.chrome.driver=<WebDriverPath>\chromedriver.exe -Dwebdriver.ie.driver=<WebDriverPath>\IEDriverServer.exe -Dwebdriver.gecko.driver=<WebDriverPath>\\geckodriver.exe -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role node -hub http://localhost:<serverPort#>/grid/register -port <nodePort#> -maxSession 5

CREATE HUB AND NODE USING CONFIG FILE

Create selenium grid hub using the config file(json):
* java -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role hub -hubConfig <ConfigPath>\ServerConfig.json -port <serverPort#>

Create selenium grid node using the config file(json) --Firefox:
* java -Dwebdriver.gecko.driver=<WebDriverPath>\geckodriver.exe -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role node -hub http://localhost:<serverPort#>/grid/register -nodeConfig <ConfigPath>\FirefoxNodeConfig.json -port <nodePort#>

Create selenium grid node using the config file(json) --Chrome:
* java -Dwebdriver.chrome.driver=<WebDriverPath>\chromedriver.exe -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role node -hub http://localhost:<serverPort#>/grid/register -nodeConfig <ConfigPath>\ChromeNodeConfig.json -port <nodePort#>

Create selenium grid node using the config file(json) --internet explorer:
* java -Dwebdriver.ie.driver=<WebDriverPath>\IEDriverServer.exe -jar <SeleniumServerPath>\selenium-server-standalone-<version>.jar -role node -hub http://localhost:<serverPort#>/grid/register -nodeConfig <ConfigPath>\IENodeConfig.json -port <nodePort#>

