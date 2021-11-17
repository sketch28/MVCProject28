using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProject28.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("ExpenseTypes")]
        [Required]
        public string Name { get; set; }

    }
}
