//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_TheKeeper.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public Nullable<int> DivisionCode { get; set; }
        public Nullable<int> RoleCode { get; set; }
        public int AccessCode { get; set; }
    
        public virtual Division Division { get; set; }
        public virtual Role Role { get; set; }
    }
}
