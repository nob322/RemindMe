//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExceptionLog
    {
        public System.DateTime ExceptionDate { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
        public string SystemLog { get; set; }
        public string CustomMessage { get; set; }
    }
}
