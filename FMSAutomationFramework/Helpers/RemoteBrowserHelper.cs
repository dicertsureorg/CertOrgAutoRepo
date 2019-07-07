using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace CertsureAutomationFramework.Helpers
{
    public class RemoteBrowserHelper
    {
        public static IWebDriver GetDriver(string preferedbrowser, TestContext context)
        {
            string browserVersion = TestSettings.Default.BrowserVersion;

            var caps = new DesiredCapabilities();
            var remoteCapabilities = new RemoteBrowserHelper();
            switch (preferedbrowser)
            {
                case "Chrome":
                    {
                        var options = remoteCapabilities.GetChromeOptions();
                        var capabilities = (DesiredCapabilities)options.ToCapabilities();
                        caps = remoteCapabilities.SetCapabilities(capabilities, preferedbrowser, browserVersion, context);
                        break;
                    }
                case "Safari":
                    {
                        var capabilities = new DesiredCapabilities();
                        capabilities.SetCapability("browserstack.safari.enablePopups", "true");
                        caps = remoteCapabilities.SetCapabilities(capabilities, preferedbrowser, browserVersion, context);
                        break;
                    }
                case "IE":
                    {
                        var capabilities = new DesiredCapabilities();
                        capabilities.SetCapability("browserstack.ie.enablePopups", "true");
                        capabilities.SetCapability("browserstack.ie.noFlash", "true");
                        caps = remoteCapabilities.SetCapabilities(capabilities, preferedbrowser, browserVersion, context);
                        break;
                    }
                case "Firefox":
                    {
                        var capabilities = new DesiredCapabilities();
                        caps = remoteCapabilities.SetCapabilities(capabilities, preferedbrowser, browserVersion, context);
                        break;
                    }
                default:
                    {
                        var options = remoteCapabilities.GetChromeOptions();
                        var capabilities = (DesiredCapabilities)options.ToCapabilities();
                        caps = remoteCapabilities.SetCapabilities(capabilities, preferedbrowser, browserVersion, context);
                        break;
                    }

            }

            var url = new Uri("https://hub-cloud.browserstack.com/wd/hub/");
            return new RemoteWebDriver(url, caps);

        }

        public DesiredCapabilities SetCapabilities(DesiredCapabilities cap, string browserName, string browserVersion, TestContext context)
        {
            var testName = context.TestName;
            cap.SetCapability(CapabilityType.SupportsFindingByCss, true);
            cap.SetCapability(CapabilityType.HandlesAlerts, true);
            cap.SetCapability(CapabilityType.TakesScreenshot, true);
            cap.SetCapability(CapabilityType.SupportsLocationContext, true);
            cap.SetCapability(CapabilityType.IsJavaScriptEnabled, true);
            cap.SetCapability("browserstack.networkLogs", true);
            cap.SetCapability("browser", browserName);
            cap.SetCapability("browser_version", browserVersion); 
            cap.SetCapability("build", testName);
            cap.SetCapability("browserstack.debug", "true");
            cap.SetCapability("resolution", "1920x1080");
            cap.SetCapability("browserstack.user", "anirudhachavan1");
            cap.SetCapability("browserstack.key", "Jbg6m5aY42GAgKMmtyWf");
            cap.SetCapability(" browserstack.console", "errors");
            cap.SetCapability("browserstack.local", "false");

            return cap;
        }
        private ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("--lang=en-GB");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--disable-plugins");
            options.AddArgument("--start-maximized");
            options.AddArgument("--enable-logging");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--incognito");
            options.AddArgument("--enable-javascript");
            options.AddArgument("--allow-running-insecure-content");
            options.AddArgument("--javascript-harmony");
            return options;
        }
    }
}
