using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_MaxLength_Attribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MinLength(10)]
        public string Address { get; set; }

    }

    public class Customer
    {
        public int CustomerID { get; set; }
        
        [MaxLength(50,ErrorMessage="Name cannot be greater than 50")]
        public string Name { get; set; }

        [MinLength(10, ErrorMessage = "Name cannot be less than 10")]
        public string Address { get; set; }

    }



}
