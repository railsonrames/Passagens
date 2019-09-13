using Passagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));
            Uri address = new Uri("http://localhost:8080/clientes");

            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), address);

            try
            {
                host.Open();
                ShowServiceInformation(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void ShowServiceInformation (ServiceHost serviceHost)
        {
            Console.WriteLine($"{serviceHost.Description.ServiceType} está online");
            foreach (var item in serviceHost.Description.Endpoints)
            {
                Console.WriteLine(item.Address);
            }
        }
    }
}
