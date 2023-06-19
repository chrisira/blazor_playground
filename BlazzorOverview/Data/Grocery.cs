using System.ComponentModel.DataAnnotations;
namespace BlazzorOverview.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15,ErrorMessage="Name should be less than 15 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1,10000,ErrorMessage ="The range should be between 1-1000")]
        public float Price { get; set; }
    }
}
