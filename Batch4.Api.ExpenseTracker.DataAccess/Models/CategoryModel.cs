using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.DataAccess.Models
{
    [Table("Tbl_Category")]
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class CategoryRequestModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
