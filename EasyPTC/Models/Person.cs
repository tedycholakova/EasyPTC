namespace EasyPTC.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Person
    {
        [Display(Name = "Human")]
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}