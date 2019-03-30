using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCParcial.Models
{
    public enum TipoEstado
    {
        Activo,
        Inactivo
    }
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]                                                    //damos prop y tab tab seguido y nos da toda esa propiedad
        [Display(Name = "Product Name")]

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [Required]

        public int Cantidad { get; set; }

        [Required]

        public TipoUnidad Unidad { get; set; }

        [Required]

        public TipoEstado Estado { get; set; }

     
    }
}