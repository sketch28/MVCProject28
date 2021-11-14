using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProject28.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required]

        public string ExpensesName { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage ="Amount Must Be Greater Than 0!")]
        public int Amount { get; set; }
    }
}
