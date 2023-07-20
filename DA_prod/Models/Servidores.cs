using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;
using DA_prod.Validations;

namespace DA_prod.Models
{
    public class Servidores
    {
        public int ID { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "Correo electronico obligatorio")]
        [StringLength(100, ErrorMessage = "Correo invalido")]
        [EmailAddress]

        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña obligatoria")]
        [StringLength(100, ErrorMessage = "Exceede tamaño")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "Nombre de usuario obligatorio")]
        [StringLength(50, ErrorMessage = "Exceede tamaño permitido!")]
        //Validacion de usuario existente

        public string NombreServidor { get; set; }

        [Display(Name = "Nombre de Usuario")]
        [Required(ErrorMessage = "Nombre de usuario obligatorio")]
        [StringLength(50, ErrorMessage = "Exceede tamaño permitido!")]
        //Validacion de usuario existente

        public string UserName { get; set; }

        [Display(Name = "Grupo de procedencia")]
        [Required(ErrorMessage = "Información de grupo obligatorio")]
        [StringLength(100, ErrorMessage = "Grupo invalido")]
        //Validacion de grupos disponibles

        public string Grupo { get; set; }

        [Required(ErrorMessage = "Telefono Obligatorio")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Telefono Incorrecto")]
        [Display(Name = "Telefono 555-555-5555")]
        [DisplayFormat(DataFormatString = "{0:D3-D3-D4}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}", ErrorMessage = "Telefono Incorrecto")]
        [DataType(DataType.PhoneNumber)]

        public string TelefonoPersonal { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Estado actual de grupo")]
        [StringLength(30, ErrorMessage = "Estado Invalido")]
        //Validacion de los estados disponibles

        public string Estado { get; set; }

        [Display(Name = "Servicio actual")]
        [Required(ErrorMessage = "Servicio obligatorio")]
        [StringLength(30, ErrorMessage = "Servicio no permitido")]
        //Validacion de lista de servicios

        public string Servicio { get; set; }

        [Required(ErrorMessage = "Fecha de ingreso obligatorio")]
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaIngreso { get; set; }// = DateTime.Today.AddYears(-18);
    }
}
