//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WWService.ModelBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat_Modulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_Modulos()
        {
            this.tbl_DatosGenerales = new HashSet<tbl_DatosGenerales>();
        }
    
        public int IdModulo { get; set; }
        public string nombreModulo { get; set; }
        public bool estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DatosGenerales> tbl_DatosGenerales { get; set; }
    }
}