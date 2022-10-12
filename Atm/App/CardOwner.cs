using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    public class CardOwner 
    {
        public string FirstName { get; set; }  // listeyi programda manuel yazmasaydık private static tanımlayıp sadece bu sınıf içinden erişim sağlayabilirdik
        public string LastName { get; set; }
        public int CardNo { get; set; }  //bir isme ait card no bir kere girilsin sonra değiştirilemesin ama bir sürü card no eklenebilsin list e  -> readonly????
        public int CardPın { get; set; }

        public double Balance  { get; set; } //private static olursa sadece class içinden ulaşabilriz. Static yaptım çünkü addmoney de kullanıcam
    }
}
