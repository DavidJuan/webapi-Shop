using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3,ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MaxLength(60,ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024,ErrorMessage = "Este campo deve conter no maximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(int.MinValue, int.MaxValue, ErrorMessage = "O Preço deve ser maior que zero")]
        public decimal Price { get; set; }

        public Category Category { get; set; }
        
    }
}