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
    
    public partial class Cat_TipoObjeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_TipoObjeto()
        {
            this.tbl_CodigoDB = new HashSet<tbl_CodigoDB>();
        }
    
        public int intTipoObjeto { get; set; }
        public string vchTipoObjeto { get; set; }
        public bool bitActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CodigoDB> tbl_CodigoDB { get; set; }
    }
}
