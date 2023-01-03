using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifEtkinligi.entities
{
    internal class ExternalWorker : Worker
    {
        private double fee;
        private DateTime ContractExpirationTime { get; set; }

        // Dışarıdan gelen işgörenin kontratının devam edip etmediğini kontrol eden metot:
        public bool CheckContract()
        {
            bool isContractOngoing = DateTime.Now < ContractExpirationTime;
            Console.WriteLine(isContractOngoing ? "Kontrat Devam Ediyor." : "Kontrat Sona Ermiş.");
            return isContractOngoing;
        }

        // Çalışan detaylarını yazdıran metot
        public void WriteDetails()
        {
            Console.WriteLine($"ID: {this.GetID()} \n" +
                              $"İsim: {this.GetName()} \n" +
                              $"Soyisim: {this.GetLastName()} \n" +
                              $"Başlangıç Tarihi: {this.GetStartTime()} \n" +
                              $"Ücret: {this.fee}");
        }

        // Getter ve setter for Fee
        public double GetFee()
        {
            return this.fee;
        }

        public void SetFee(double fee ) { this.fee = fee; }

    }
}
