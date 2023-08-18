using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; } // primary key, Id name is primary key by default, otherwise data annotation [key] is required to set it

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }  


    }
}
