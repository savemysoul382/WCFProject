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

            //2й способ подключения
            //using (ServiceHost ServiceHost = new
            //    ServiceHost(typeof(MagicEightBallService),
            //        new Uri[] { new Uri("http://localhost:8080/MagicEightBallService") }))

            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                // Открыть хост и начать прослушивание входящих сообщений.
                serviceHost.Open();
                DisplayHostinfо(serviceHost);
                // Оставить службу функционирующей до тех пор,
                // пока не будет нажата клавиша <Enter>.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");

                Console.ReadLine();
            }
        }

        static void DisplayHostinfо(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");
            foreach (System.ServiceModel.Description.ServiceEndpoint se
                in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", se.Address); // Адрес
                Console.WriteLine("Binding: {0}", se.Binding.Name); // Привязка
                Console.WriteLine("Contract: {0}", se.Contract.Name); // Контракт
                Console.WriteLine();
                Console.WriteLine("**********************");
            }
        }
    }
}