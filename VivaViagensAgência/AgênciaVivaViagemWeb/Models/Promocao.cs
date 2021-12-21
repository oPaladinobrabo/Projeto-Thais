using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgênciaVivaViagemWeb.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }

        public int IdDestino { get; set; }
        [ForeignKey("IdDestino")]

        public double Desconto { get; set; }

        public string Descricao { get; set; }

        public virtual Destino Destinos { get; set; }


    }
}