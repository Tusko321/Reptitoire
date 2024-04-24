using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reptitoire.ReptitoireManager.Reptile
{
    [System.Serializable]
    public class ReptileInfo
    {
        public string name;
        public string birthday;
        public string species;
        public string sex;
        public string lastDayFed;

        public ReptileInfo(string name, string birthday, string species, string sex, string lastDayFed)
        {
            this.name = name;
            this.birthday = birthday;
            this.species = species;
            this.sex = sex;
            this.lastDayFed = lastDayFed;
        }

        public string GetAge()
        {
            TimeSpan age = DateTime.Now.Date - DateTime.Parse(birthday);
            
            if(age.Days < 365)
            {
                return age.Days.ToString() + " days";
            }
            else
            {
                int years = age.Days / 365;
                int days = age.Days % 365;

                return years + "y " + days + " days";
            }
        }

        public bool WasFedToday()
        {
            DateTime dateFed = DateTime.Parse(lastDayFed);

            return dateFed.Date.Equals(DateTime.Now.Date);
        }
    }
}
