using System;
using System.Net;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using TechTalk.SpecFlow;

namespace WebApiCodeTest.Steps
{
   
    public class CommonSteps:StepsBase
    {

        [When(@"(?i)the response is received")]
        public void WhenIGetTheResponseBackFromApi()
        {
            Response = Client.Execute<dynamic>(Request);


        }


        public dynamic Deserilize()
        {

            Response = Client.Execute<dynamic>(Request);
            dynamic Response1 = JsonConvert.DeserializeObject(Response.Content);

            return Response1;
        }

    }
}
