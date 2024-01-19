using System.ComponentModel.DataAnnotations;

namespace WearHouse.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
