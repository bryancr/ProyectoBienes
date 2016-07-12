using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoBienes.Models
{
    [Table("Bienes")]
    public class Bienes
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        
        public Boolean Estado { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}