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
    using System.Collections.Generic;
    
    public partial class EstornoDadosCartaoCredito
    {
        public int ID { get; set; }
        public Nullable<int> VendaBilheteriaIDCancel { get; set; }
        public Nullable<int> VendaBilheteriaIDVenda { get; set; }
        public string Bandeira { get; set; }
        public string Cartao { get; set; }
        public decimal Valor { get; set; }
        public string Cliente { get; set; }
        public string CPFCliente { get; set; }
        public string CancelamentoPor { get; set; }
        public Nullable<System.DateTime> DataInsert { get; set; }
        public Nullable<System.DateTime> DataEnvio { get; set; }
        public string Email { get; set; }
        public bool PlanilhaGerada { get; set; }
    
        public virtual tVendaBilheteria tVendaBilheteria { get; set; }
        public virtual tVendaBilheteria tVendaBilheteria1 { get; set; }
    }
}