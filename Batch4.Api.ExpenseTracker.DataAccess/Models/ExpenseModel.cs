using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.DataAccess.Models
{

    [Table("Tbl_Expense")]
    public class ExpenseModel
    {
        [Key]
        public int ExpenseId { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public bool IsDelete { get; set; }
    }

    public class ExpenseRequestModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
    }

    public class ExpenseDetailModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
