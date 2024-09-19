using System.ComponentModel.DataAnnotations;

namespace MultRH_MVC.Models.ViewModels
{
    public class Client
    {
        private int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        [Phone(ErrorMessage ="Telefone inválido")]
        public string Telefone {  get; set; }

    }
}
