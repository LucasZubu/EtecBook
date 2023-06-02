using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects
{
    public class RegisterDto
    {
       [Required(ErrorMessage = "Informe o Nome")] 
       [StringLength(60,  ErrorMessage = "O Nome deve possuir no maximo 60 caracteres")]
       public string Name {get; set;}

       [Required(ErrorMessage = "Informe o Email")] 
       [EmailAddress(ErrorMessage = "Informe um Email Válido")]
       [StringLength(100,  ErrorMessage = "O email no maximo 100 caracteres")]
       public string Email {get; set;}

       [DataType(DataType.Password)] 
       [Required(ErrorMessage = "Informe Senha")] 
       [StringLength(20, MinimumLength = 6,
        ErrorMessage = "A senha deve possuir no maximo 20 Caracteres")]
       public string Password {get; set;}        
    }
}