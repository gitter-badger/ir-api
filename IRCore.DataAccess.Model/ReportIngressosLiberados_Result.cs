//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRCore.DataAccess.Model
{
    using System;
    
    public partial class ReportIngressosLiberados_Result
    {
        public int LocalID { get; set; }
        public string LocalNome { get; set; }
        public string LocalCidade { get; set; }
        public int EventoID { get; set; }
        public string EventoNome { get; set; }
        public string DataHora { get; set; }
        public Nullable<int> ClasseID { get; set; }
        public string ClasseNome { get; set; }
        public Nullable<int> Disponibilizados { get; set; }
        public Nullable<int> Resgatados { get; set; }
        public Nullable<int> Liberados { get; set; }
        public Nullable<int> ParceiroID { get; set; }
    }
}