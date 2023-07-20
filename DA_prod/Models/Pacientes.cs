using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using DA_prod.Validations;

namespace DA_prod.Models
{
    public class Pacientes : IValidatableObject
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


        [Required(ErrorMessage = "Fecha de Ingreso Obligatorio")]
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }



        [Required(ErrorMessage = "Hora Obligatorio")]
        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        public string HoraIngreso { get; set; }



        [Required(ErrorMessage = "Dirrecion Obligatoria")]
        [Display(Name = "Direccion")]
        [StringLength(150, ErrorMessage = "Direccion Incorrecta")]
        public string Direccion { get; set; }



        [Required(ErrorMessage = "Telefono Obligatorio")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Telefono Incorrecto")]
        [Display(Name = "Telefono")]
        [DisplayFormat(DataFormatString = "{0:D3-D3-D4}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}", ErrorMessage = "Telefono Incorrecto")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }



        [Required(ErrorMessage = "Nacionalidad Obligatorio")]
        [Display(Name = "Nacionalidad")]
        [StringLength(150, ErrorMessage = "Nacionalidad Invalido")]
        [PrimerLetraMayuscula]
        public string Nacionalidad { get; set; }



        [Display(Name = "Hombre")]
        public bool Sexo { get; set; }



        [Required(ErrorMessage = "Fecha de Nacimiento Obligatorio")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-18);



        [Display(Name = "Estado Civil")]
        [StringLength(20, ErrorMessage = "Estado civil invalido")]
        public string EstCivil { get; set; }



        [Display(Name = "Escolaridad")]
        [StringLength(300, ErrorMessage = "Sobrepasa limites de texto")]
        public string Escolaridad { get; set; }



        [Display(Name = "Ocupación")]
        [StringLength(300, ErrorMessage = "Sobrepasa limites de texto")]
        public string Ocupacion { get; set; }


        [Display(Name = "¿Cuantos ingresos previos?")]
        public int IngresosPrev { get; set; }


        [Display(Name = "¿Lo refiere alguna Institución?")]
        public bool Referido { get; set; }


        [Display(Name = "Ingreso Voluntario")]
        public bool Voluntario { get; set; }


        [Required(ErrorMessage = "Motivo obligatorio")]
        [Display(Name = "Motivo por el ingreso")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]
        public string Motivo { get; set; }


        [Required(ErrorMessage = "Estado de salud obligatorio")]
        [Display(Name = "Estado de Salud")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]
        public string Salud { get; set; }


        [Display(Name = "Diabetes")]
        public bool Diabetes { get; set; }


        [Display(Name = "Hepatitis")]
        public bool Hepatitis { get; set; }


        [Display(Name = "Hipertensión")]
        public bool Presion { get; set; }


        [Display(Name = "Cáncer")]
        public bool Cancer { get; set; }


        [Display(Name = "Psiquiátrica")]
        public bool Psiq { get; set; }


        [Display(Name = "Obesidad")]
        public bool Obeso { get; set; }


        [Display(Name = "Enfermedades Infecto Contagiosa")]
        public bool Infeccion { get; set; }



        [Display(Name = "Alergias")]
        public bool Alergias { get; set; }


        [Display(Name = "Especificaciones de enfermedades anteriores u otras:")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]
        public string Enfermedades { get; set; }
        /// <summary>
        /// ////////////////DATOS DEL FAMILIAR
        /// </summary>
        [Required(ErrorMessage = "Nombre Responsable Obligatorio")]
        [Display(Name = "Responsable")]
        [StringLength(150, ErrorMessage = "Nombre Incorrecto")]
        [PrimerLetraMayuscula]

        public string NombreFamiliar { get; set; }


        [Required(ErrorMessage = "Parentesco Obligatorio")]
        [Display(Name = "Parentesco")]
        [StringLength(150, ErrorMessage = "Parentesco Invalido")]
        [PrimerLetraMayuscula]
        public string Parentesco { get; set; }


        [Display(Name = "Edad")]
        public int EdadFam { set; get; }


        [Display(Name = "Ocupación del responsable")]
        [StringLength(300, ErrorMessage = "Sobrepasa limites de texto")]
        public string OcupacionFam { get; set; }



        [Display(Name = "Dirreción del responsable")]
        [StringLength(200, ErrorMessage = "Sobrepasa 200 caracteres")]
        public string DirFam { get; set; }



        [Required(ErrorMessage = "Telefono Obligatorio")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Telefono Incorrecto")]
        [Display(Name = "Telefono: 555-555-5555")]
        [DisplayFormat(DataFormatString = "{0:D3-D3-D4}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}", ErrorMessage = "Telefono Incorrecto")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoFam { get; set; }

        /// <summary>
        /// /////////FIN DE LOS DATOS DEL RESPONSABLE FAMILIAR//////////////
        /// </summary>

        


        [Display(Name = "a) El usuario es mayor de edad.")]
        public bool MayorEdad { get; set; }


        [Display(Name = "b) El usuario presenta un nivel de dependencia al alcohol o drogas. ")]
        public bool Adicto { get; set; }


        [Display(Name = "c) El usuario presenta alguna(s) consecuencia asociada al consumo. ")]
        public bool Cons { get; set; }


        [Display(Name = "d) El usuario presenta algún trastorno mental o psiquiátrico no controlado que le impida beneficiarse del tratamiento. ")]
        public bool TrastornoMental { get; set; }


        [Display(Name = "e) ¿El usuario cumple con todos los criterios de admisión al tratamiento? ")]
        public bool Asistencia_externa { get; set; }



        [Display(Name = "En caso de no haber cumplido los criterios, indicar el lugar al que será derivado:")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]
        public string Criterios { get; set; }



        //[Required(ErrorMessage = "Revisión obligatorio")]
        [Display(Name = "Revisión Fisica:")]
        [StringLength(600, ErrorMessage = "Solo 600 caracteres")]
        public string Revision { get; set; }


        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.Direccion != null)
            {
                string primeraLetra = this.Direccion[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult(
                        "La primera letra debe ser mayuscula " + validationContext.DisplayName
                        );
                }
            }
            
        }
    }
}

