using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosWebAppMvc.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Obrigatório informar o nome !")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha !")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil !")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
