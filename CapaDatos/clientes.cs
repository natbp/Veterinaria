//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            this.mascotas = new HashSet<mascotas>();
        }
    
        public int cedula_cli { get; set; }
        public string nombre_cli { get; set; }
        public string nombre_usuc { get; set; }
        public string direccion_cli { get; set; }
        public string correo_cli { get; set; }
        public Nullable<int> telefono_cli { get; set; }
        public string contrasena_cli { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mascotas> mascotas { get; set; }
    }
}
