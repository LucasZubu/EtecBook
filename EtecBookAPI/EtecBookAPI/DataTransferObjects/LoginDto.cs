using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects
{
    public class LoginDto
    {
       [Required(ErrorMessage = "Informe o Email ou o Nome de Usuário")] 
       [StringLength(100,  ErrorMessage = "O email ou nome deve possuir no maximo 100 caracteres")]
       public string Email {get; set;}

       [DataType(DataType.Password)] 
       [Required(ErrorMessage = "Informe Senha")] 
       [StringLength(20,  ErrorMessage = "A senha deve possuir no maximo 20 Caracteres")]
       public string Password {get; set;}
    }
}