using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifEtkinligi.entities
{
    class Worker
    {
        private string id { get; set; }
        private string Name;
        private string LastName { get; set; }
        private DateTime startTime { get; set; }

        // Dışarıdan gelen ve şirketin devamlı personeli olan çalışanları gruplayan metot:
        private string GroupWorkers()
        {
            if (this.GetType() == typeof(InternalWorker))
            {
                return "1";
            }
            return "2";
        }

        // Şirket çalışanlarına 1 ile, dışarıdan gelenlere 2 ile başlayan id atayan metot:
        public void CreateID()
        {
            this.id = this.GroupWorkers() + Guid.NewGuid().ToString();
        }

        // Boş bırakılamaz şekilde personel ismi atama metodu:
        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Bu alan boş olamaz.");
            }
            this.Name = name;
        }

        // Boş bırakılamaz şekilde personel soyismi atama metodu:
        public void SetLastname(string lastname)
        {
            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new Exception("Bu alan boş olamaz.");
            }
            this.LastName = lastname;
        }

        // işe başlangıç tarihi atama metodu:
        public void SetStartTime(DateTime datetime)
        {
            this.startTime = datetime;
        } 


        // Getter metotları
        public string GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public DateTime GetStartTime()
        {
            return this.startTime;
        }


    }
}
