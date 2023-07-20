using DA_prod.Validations;
using Microsoft.AspNetCore.Routing;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace DA_prod.Models
{
    public class Egresado
    {
        public int ID { get; set; }

        [Display(Name = "Folio")]
        [Required(ErrorMessage = "Folio Obligatorio")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Folio Incorrecto")]
        [DisplayFormat(DataFormatString = "{0:D8}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Folio Incorrecto")]

        public string FolioInterno { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(150, ErrorMessage = "Nombre Invalido")]
        [PrimerLetraMayuscula]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellidos Obligatorio")]
        [Display(Name = "Apellidos")]
        [StringLength(150, ErrorMessage = "Apellido invalido")]
        [PrimerLetraMayuscula]

        public string Apellidos { get; set; }


        [Display(Name = "Hombre")]

        public bool Sexo { get; set; }


        [Display(Name ="Edad")]

        public int Edad { get; set; }

        [Required(ErrorMessage = "Fecha de Ingreso Obligatorio")]
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "Fecha de Egreso Obligatorio")]
        [Display(Name = "Fecha de Egreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaEgreso { get; set; }


        [Required(ErrorMessage = "Motivo obligatorio")]
        [Display(Name = "Motivo de engreso")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]

        public string MotivoEgreso { get; set; }


       
        [Display(Name = "Resumen de la evolución y del estado general de salud:")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]

        public string ResumenSalud { get; set; }


        
        [Display(Name = "Problemas de salud pendientes")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]

        public string ProblemaSalud { get; set; }


        [Display(Name = "a) El usuario se ha mantenido en abstinencia un promedio de 3 meses.")]
        public bool Tres_meses { get; set; }


        [Display(Name = "b) El usuario ha recibido los componentes terapéuticos mínimos indispensables para promover su rehabilitación. ")]
        public bool Terapia { get; set; }


        [Display(Name = "c) El usuario ha participado activamente en todas las sesiones programadas por el médico, responsable, servidores y padrino. ")]
        public bool Sesiones { get; set; }


        [Display(Name = "d) El estado de salud del usuario es óptimo. ")]
        public bool Salud_optimo { get; set; }


        [Display(Name = "e) El usuario se compromete a asistir de manera periódica a su programa de rehabilitación.")]
        public bool Asistencia_externa { get; set; }
    }
}
