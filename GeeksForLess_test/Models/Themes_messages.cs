//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeeksForLess_test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Themes_messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Themes_messages()
        {
            this.Themes_messages1 = new HashSet<Themes_messages>();
        }
    
        public long Id { get; set; }
        public long Theme { get; set; }
        public string Author { get; set; }
        public Nullable<long> Reply_to { get; set; }
        public string Text { get; set; }
        public Nullable<System.DateTime> Publication_date { get; set; }
    
        public virtual Themes Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Themes_messages> Themes_messages1 { get; set; }
        public virtual Themes_messages Themes_messages2 { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
