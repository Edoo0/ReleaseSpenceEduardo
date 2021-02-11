//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReleaseSpence.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sensores()
        {
            this.Datos_clima = new HashSet<Datos_clima>();
            this.Datos_co2 = new HashSet<Datos_co2>();
            this.Datos_energia = new HashSet<Datos_energia>();
            this.Datos_extensometro = new HashSet<Datos_extensometro>();
            this.Datos_o2 = new HashSet<Datos_o2>();
            this.Datos_piezometro = new HashSet<Datos_piezometro>();
            this.Datos_pm10 = new HashSet<Datos_pm10>();
        }
    
        public int idSensor { get; set; }
        public int idTipo { get; set; }
        public int idFigura { get; set; }
        public int idPuntoMonitoreo { get; set; }
        public string nombre { get; set; }
        public Nullable<float> maxLimit { get; set; }
        public Nullable<float> minLimit { get; set; }
        public string syncToken { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_clima> Datos_clima { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_co2> Datos_co2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_energia> Datos_energia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_extensometro> Datos_extensometro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_o2> Datos_o2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_piezometro> Datos_piezometro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_pm10> Datos_pm10 { get; set; }
        public virtual Figuras Figuras { get; set; }
        public virtual Marcadores Marcadores { get; set; }
        public virtual Sensores_Piezometros Sensores_Piezometros { get; set; }
        public virtual TipoSensores TipoSensores { get; set; }
        public virtual Punto_de_Monitoreo Punto_de_Monitoreo { get; set; }
    }
}