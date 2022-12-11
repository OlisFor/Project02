using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Project02.StepDefinitions.Utility
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver driver;

        // Implementing Extent Report

        static AventStack.ExtentReports.ExtentReports extent;   
        static AventStack.ExtentReports.ExtentReports feature;
        AventStack.ExtentReports.ExtentTest scenario, step;

        static string reportpath = Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Results"
            + Path.DirectorySeparatorChar + "ExtentReport" + DateTime.Now.ToString("ddMMyy HHmmss");


       

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            CreateExtentReport();

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title); 
        }

        [BeforeScenario]
        public void BeforeScenairo(ScenarioContext context)
        {
            scenario = feature.CreateNode(context.ScenarioInfo.Title);
        }

        [BeforeStep]
        public void BeforeTest()
        {
            step = scenario;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                string screenshot = GetScreenshot();
                step.Log(Status.Pass, context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build());
            }
            else if(context.TestError !=null)
            {
                string screenshot = GetScreenshot();
                step.Log(Status.Fail, context.StepContext.StepInfo.Text, MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build());
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Quit();
        }

        public static void CreateExtentReport ()
        {
            //Extent report Generation

            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
            extent.AddSystemInfo("Environment", "UAT");
            extent.AddSystemInfo("os", Environment.OSVersion.ToString());

            htmlreport.Config.DocumentTitle = "AccessElearn Automation Training";
            htmlreport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlreport.Config.ReportName = "Regression Testing";

        }

        public string GetScreenshot()
        {
            return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
        }
        
    }
}