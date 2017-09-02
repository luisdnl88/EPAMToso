using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPAMToso.Data.Model
{
    public class Expenses
    {
      [Key, Required]
      public int ExpenseID { get; set; }

      [Required, Display(Name="Description")]
      public string ExpenseDescription { get; set; }

      [Required, Display(Name = "Date of expense")]
      [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime ExpenseDate { get; set; }

      [DataType(DataType.Currency)]
      public decimal ExpenseAmount { get; set; }
    }
}
