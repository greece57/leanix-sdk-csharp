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
            client.setApiKey("146bb5665a2b86af3aa84fc59420f568");

            ServicesApi api = new ServicesApi();
            List<Service> services = api.getServices(false, "design");

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
