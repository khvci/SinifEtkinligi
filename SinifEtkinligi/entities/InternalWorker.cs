using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SinifEtkinligi.entities
{
    class InternalWorker : Worker
    {
        private double minSalary = 8500;
        private double salary { get; set; }

        /// Şirket çalışanının maaşını asgari ücretin altında olmayacak şekilde atayan metot:
        public void SetSalary(double salary)
        {
            this.salary = salary >= minSalary ? salary : minSalary;
        }

        // Çalışan detaylarını yazdıran metot
        public void WriteDetails()
        {
            Console.WriteLine($"ID: {this.GetID()} \n" + 
                              $"İsim: {this.GetName()} \n" +
                              $"Soyisim: {this.GetLastName()} \n" +
                              $"Başlangıç Tarihi: {this.GetStartTime()} \n" +
                              $"Maaş: {this.salary}");
        }

        // Getter 
        public double GetSalary() { return this.salary; }

        

    }
}
