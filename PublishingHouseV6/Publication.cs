//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PublishingHouseV6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publication()
        {
            this.AuthorsPublications = new HashSet<AuthorsPublications>();
        }
    
        public int IdPublication { get; set; }
        public string Title { get; set; }
        public int Volume { get; set; }
        public int Edition { get; set; }
        public int IdOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuthorsPublications> AuthorsPublications { get; set; }
        public virtual Order Order { get; set; }
    }
}
