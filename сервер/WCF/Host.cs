using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Service;

namespace WCF
{
    internal class Host
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CompanyService)))
            {
                host.Open();
                Console.WriteLine("Server actived");
                Console.ReadLine();
            }
        }
    }
}
