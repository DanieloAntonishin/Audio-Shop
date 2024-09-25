using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class AccountBL
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public char Role { get; set; }
        public double SpentMoney { get; set; }
        public int Discount { get; set; }
    }
}
