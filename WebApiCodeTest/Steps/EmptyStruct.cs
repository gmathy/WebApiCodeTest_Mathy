using System.Diagnostics;
using AutoMapper;
using BoDi;
using TechTalk.SpecFlow;
using Tfl.Web.AutomationTests.AccessData;
using Tfl.Web.AutomationTests.Interfaces;
using Tfl.Web.AutomationTests.Pages;
using Tfl.Web.AutomationTests.WebDriver;
using TfL.Web.Common.Mapping.Profiles.Common;
using TfL.Web.Repositories.DataAccess.Interfaces;
using Tfl.Web.AutomationTests.CommonSettings;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Tracing;
using System.IO;
using System.Text;
using System.Drawing.Imaging;

namespace Tfl.Web.AutomationTests.Steps
{
    [Binding]
    public class Initializer
    {
        private readonly IObjectContainer _objectContainer;
        public IApiClient ApiClient;
       
        public Initializer(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {
            Mapper.Initialize(
            mappingConfig =>
            {
                mappingConfig.AddProfile<CommonProfile>();
            });

            ApiClient = ApiClientFactory.CreateClient();
            _objectContainer.RegisterInstanceAs<IApiClient>(ApiClient);
            if (GetAppData.GetBrowser() != "")
            {
                if (Driver.Instance == null)
                    Driver.Initialize();
                else
                {
                    Driver.Instance.Manage().Cookies.DeleteAllCookies();
                    Driver.GoToBaseUrl();
                }
            }
          


          

            RucPages = new RucPages(Driver.Instance);
            _objectContainer.RegisterInstanceAs<IRuc>(RucPages);

        }

}
