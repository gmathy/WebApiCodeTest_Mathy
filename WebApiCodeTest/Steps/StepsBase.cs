using System;
using RestSharp;

namespace WebApiCodeTest.Steps
{
    
    public class StepsBase
    {
        protected RestClient Client;
        public RestRequest Request;
        protected IRestResponse Response;

        protected readonly Uri BaseUri = new Uri("http://searchapi.asos.com");

       
        public StepsBase()
        {
            Client = new RestClient(BaseUri);
        }
    }
}