using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgênciaVivaViagemWeb.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public String Pais { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String NomeDestino { get; set; }

        public virtual ICollection<Promocao> Promocao { get; set; }
    }
}
