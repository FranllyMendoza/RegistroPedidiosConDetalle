using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidiosConDetalle.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }

        public int OrdenId { get; set; }

        public float Cantidad { get; set; }

        public int ProductoId { get; set; }

        [Range(minimum: 0.0, maximum: 50000000.0, ErrorMessage = "Inserte costo válido")]
        public float Costo { get; set; }
    }
}
