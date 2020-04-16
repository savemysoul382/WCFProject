using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFProject;


namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host *****");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                // Открыть хост и начать прослушивание входящих сообщений.
                serviceHost.Open();
                // Оставить службу функционирующей до тех пор,
                // пока не будет нажата клавиша <Enter>.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");

                Console.ReadLine();
            }
        }
    }
}
