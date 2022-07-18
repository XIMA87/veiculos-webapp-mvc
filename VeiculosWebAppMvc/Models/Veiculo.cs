using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosWebAppMvc.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informar Nome/Modelo do veículo é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informar a placa do veículo é obrigatório!")]
        public string Placa { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
