using System.ComponentModel.DataAnnotations;

namespace prueba.Models
{
    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public class Trabajador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo TipoDocumento es requerido.")]
        [Display(Name = "Tipo de Documento")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El campo NumeroDocumento es requerido.")]
        [Display(Name = "Número de Documento")]
        public string NumeroDocumento { get; set; }

        [Required(ErrorMessage = "El campo Nombres es requerido.")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Sexo es requerido.")]
        [Display(Name = "Sexo")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "El campo Departamento es requerido.")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "El campo Provincia es requerido.")]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "El campo Distrito es requerido.")]
        [Display(Name = "Distrito")]
        public string Distrito { get; set; }
    }
}
