using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Mascota
    {
        public int Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime Hora { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string NombreMascota { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string Raza { get; set; }

        [Column(TypeName = "int")]
        [Range(0, 50)]
        public int Edad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Este campo tiene un máximo de 50 caracteres.")]
        public string NombreDueno { get; set; }

        [Required]
        public string Celular { get; set; }
    }
}