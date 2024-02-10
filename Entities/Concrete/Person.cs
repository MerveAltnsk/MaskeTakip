using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person         //Person classı Maske takip uygulamasındaki vatandalşları temsil edecek
    {                           //Person nesnesi oluşturuldu
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
