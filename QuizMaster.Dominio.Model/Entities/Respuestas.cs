//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizMaster.Dominio.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Respuestas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Respuestas()
        {
            this.RespuestasAlumnosCuestionarios = new HashSet<RespuestasAlumnosCuestionarios>();
        }
    
        public int IDRespuesta { get; set; }
        public Nullable<int> IDPregunta { get; set; }
        public string Respuesta { get; set; }
        public Nullable<bool> EsCorrecta { get; set; }
    
        public virtual Preguntas Preguntas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RespuestasAlumnosCuestionarios> RespuestasAlumnosCuestionarios { get; set; }
    }
}
