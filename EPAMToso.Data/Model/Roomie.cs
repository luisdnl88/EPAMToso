using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPAMToso.Data.Model
{
  public class Roomie
  {
    [Key]
    public int RoomieID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string LastName { get; set; }

    public int HouseID { get; set; }

    public virtual ICollection<Expenses> Expenses { get; set; }

    public virtual House House { get; set; }
    

    public Roomie()
    {
      Expenses = new List<Expenses>();
    }

  }
}
