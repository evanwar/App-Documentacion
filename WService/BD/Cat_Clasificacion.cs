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
    
    public partial class Cat_Clasificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cat_Clasificacion()
        {
            this.tbl_ControlCambiosBDConfig = new HashSet<tbl_ControlCambiosBDConfig>();
            this.tbl_ControlCambiosCodigoConfig = new HashSet<tbl_ControlCambiosCodigoConfig>();
        }
    
        public int intClasificacionID { get; set; }
        public string vchClasificacion { get; set; }
        public bool bitActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ControlCambiosBDConfig> tbl_ControlCambiosBDConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ControlCambiosCodigoConfig> tbl_ControlCambiosCodigoConfig { get; set; }
    }
}
