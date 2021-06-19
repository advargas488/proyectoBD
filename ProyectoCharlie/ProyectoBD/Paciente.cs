//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Citas = new HashSet<Cita>();
            this.Clínica_Paciente = new HashSet<Clínica_Paciente>();
            this.Paciente_Medico = new HashSet<Paciente_Medico>();
        }
    
        public int Cédula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public Nullable<int> Teléfono { get; set; }
        public string Provincia { get; set; }
        public string Cantón { get; set; }
        public string Distrito { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> Fecha_Nac { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clínica_Paciente> Clínica_Paciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente_Medico> Paciente_Medico { get; set; }
    }
}
