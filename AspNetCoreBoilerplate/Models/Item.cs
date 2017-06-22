using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreBoilerplate.Models
{
    public class Item
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}