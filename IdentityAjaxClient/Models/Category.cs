using System.ComponentModel.DataAnnotations;

namespace IdentityAjaxClient.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [StringLength(40)]
        public string CategoryName { get; set; }
    }
}
