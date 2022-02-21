using System.ComponentModel.DataAnnotations;

namespace testef.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 a 60 carateres")]
        public string Title { get; set; }
    }
}