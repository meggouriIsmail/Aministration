//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aministration
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelativeHumidity
    {
        public int RelativeHumidityId { get; set; }
        public float Sec { get; set; }
        public float Mou { get; set; }
        public float Hum { get; set; }
        public Nullable<float> ThermometreMin { get; set; }
        public Nullable<float> ThermometreMax { get; set; }
        public Nullable<float> ThermometreMoyMaxMin { get; set; }
        public Nullable<float> ThermometreMA { get; set; }
        public Nullable<float> ThermometreMI { get; set; }
        public int Heur { get; set; }
        public Nullable<System.DateTime> DateObservation { get; set; }
        public int StationId { get; set; }
        public int ObservateurId { get; set; }
    
        public virtual Observateur Observateur { get; set; }
        public virtual Station Station { get; set; }
    }
}
