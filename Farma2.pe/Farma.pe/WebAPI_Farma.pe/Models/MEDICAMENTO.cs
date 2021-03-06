//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Farma.pe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICAMENTO()
        {
            this.FAVORITO = new HashSet<FAVORITO>();
            this.MEDICAMENTO_FARMACIA = new HashSet<MEDICAMENTO_FARMACIA>();
            this.PROMOCION = new HashSet<PROMOCION>();
        }
    
        public int ID_MED { get; set; }
        public int ID_ADV { get; set; }
        public int ID_FOR { get; set; }
        public int ID_PRE { get; set; }
        public int ID_LAB { get; set; }
        public int ID_SIN { get; set; }
        public string NOM_MED { get; set; }
        public string CON_MED { get; set; }
    
        public virtual ADVERTENCIA ADVERTENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAVORITO> FAVORITO { get; set; }
        public virtual FORMA_USO FORMA_USO { get; set; }
        public virtual LABORATORIO LABORATORIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAMENTO_FARMACIA> MEDICAMENTO_FARMACIA { get; set; }
        public virtual PRESENTACION PRESENTACION { get; set; }
        public virtual SINTOMA SINTOMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROMOCION> PROMOCION { get; set; }
    }
}
