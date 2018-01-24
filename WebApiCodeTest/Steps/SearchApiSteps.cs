using System.Net;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using Newtonsoft.Json.Linq;

namespace WebApiCodeTest.Steps
{
    [Binding]


    public class SearchApiSteps : CommonSteps
    {



        private const string SearchV1Path = "/product/search/V1/";
        private const string Accept = "application/json";
        private const string Store = "1";
        private const string Lang = "en";
        private const string Currency = "GBP";
        private const string OffSet = "0";
        private const string Q = "";
        private const string Limit = "10";


        [Given(@"(?i)I search for (.*) items")]
        public void GivenISearchForItems(string searchTerm)
        {

            Request = new RestRequest(Method.GET)
            {
                Resource = SearchV1Path
            };

            Request.AddHeader("Accept", Accept);

            Request.AddParameter("store", Store);
            Request.AddParameter("lang", Lang);
            Request.AddParameter("currency", Currency);
            Request.AddParameter("offset", OffSet);
            Request.AddParameter("q", searchTerm);
            Request.AddParameter("limit", Limit);
        }



        [Then(@"(?i)I will receive (.*) response")]
        public void ThenIWillReceiveAnResponse(HttpStatusCode statusCode)
        {
            Assert.That(Response.StatusCode, Is.EqualTo(statusCode));
        }


        [Then(@"I should see the alternate search term displayed")]
        public void ThenIShouldSeeTheAlternateSearchTermDisplayed()
        {
          
            var alternate = Deserilize().alternateSearchTerms;
            Assert.That(alternate, Is.Not.Null);
        }

        [Then(@"the spell check is true")]
        public void ThenTheSpellCheckIsTrue()
        {
            bool spellcheck = Deserilize().searchPassMeta.isSpellcheck;
            Assert.That(spellcheck, Is.EqualTo(true));
        }


        [Given(@"I search without search term")]
        public void GivenISearchWithoutSearchTerm()
        {
            Request = new RestRequest(Method.GET)
            {
                Resource = SearchV1Path
            };

            Request.AddHeader("Accept", Accept);
            Request.AddParameter("store", Store);
            Request.AddParameter("lang", Lang);
            Request.AddParameter("currency", Currency);
            Request.AddParameter("offset", OffSet);
            Request.AddParameter("q", Q);
            Request.AddParameter("limit", Limit);
        }


    }
}
   