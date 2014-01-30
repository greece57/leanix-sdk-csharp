using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeanIX.Api;
using LeanIX.Api.Models;
using LeanIX.Api.Common;

class SampleClient
{
    static void Main(string[] args)
    {
        try
        {
            ApiClient client = ApiClient.GetInstance();
            client.setBasePath("https://app.leanix.net/demo/api/v1");
            client.setApiKey("c5be3ec455aaf5fb7f9e234bb80feb2a");

            ServicesApi api = new ServicesApi();
            List<Service> services = api.getServices(false, "");

            foreach (Service s in services)
            {
                System.Console.WriteLine(s.ID + " " + s.name);
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        System.Console.ReadLine();
    }
}
