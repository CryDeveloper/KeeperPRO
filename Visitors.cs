//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeeperPRO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visitors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitors()
        {
            this.Applications = new HashSet<Applications>();
            this.Visits = new HashSet<Visits>();
            this.Data_Authorization = new HashSet<Data_Authorization>();
        }
    
        public int ID_Visitor { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> Seria { get; set; }
        public Nullable<int> Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applications> Applications { get; set; }
        public virtual BlackList BlackList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Data_Authorization> Data_Authorization { get; set; }
    }
}
