//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorrldWebDesign.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        public int UserGroupID { get; set; }
        public int UserID { get; set; }
        public int TeacherID { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
