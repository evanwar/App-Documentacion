//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WService.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat_TipoArchivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_TipoArchivo()
        {
            this.tbl_CodigoFuente = new HashSet<tbl_CodigoFuente>();
        }
    
        public int intTipoArchivo { get; set; }
        public string vchTipoArchivo { get; set; }
        public string vchExtension { get; set; }
        public bool bitActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CodigoFuente> tbl_CodigoFuente { get; set; }
    }
}
