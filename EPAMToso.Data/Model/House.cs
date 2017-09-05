using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPAMToso.Data.Model
{
    public class House
    {
        [Key]
        public int HouseID { get; set; }

        public string HouseName { get; set; }

        public virtual ICollection<Roomie> Roomies { get; set; }
        public virtual ICollection<Expenses> Expenses { get; set; }
  }
}
