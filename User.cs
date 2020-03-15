using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class User
    {
        public User()
        {
            this.CaretedDate = DateTime.Now;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CaretedDate { get; set; }
    }
}
