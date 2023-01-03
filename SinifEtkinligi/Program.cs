using System.Threading.Channels;
using SinifEtkinligi.entities;

namespace SinifEtkinligi;

class Program
{
    static void Main(string[] args)
    {
        InternalWorker worker1 = new InternalWorker();
        worker1.SetName("Ahmet");
        worker1.SetLastname("Yılmaz");
        worker1.SetSalary(100); // parametre asgari ücretin altında olduğu için asgari ücret tanımlanır
        worker1.CreateID();

        worker1.WriteDetails();


        ExternalWorker worker2 = new ExternalWorker();
        worker2.SetName("Mehmet");
        worker2.SetLastname("Yılmaz");
        worker2.SetFee(1000);
        worker2.CheckContract();
        worker2.WriteDetails();
    }
}