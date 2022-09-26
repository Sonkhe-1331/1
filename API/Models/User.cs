//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CourseCentres = new HashSet<CourseCentre>();
            this.Documents = new HashSet<Document>();
            this.RegisteredCourses = new HashSet<RegisteredCours>();
            this.Room_Booking = new HashSet<Room_Booking>();
        }
    
        public int id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Nullable<int> UserTypeId { get; set; }
        public Nullable<int> CourseCentreId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserRole_ID { get; set; }
        public string Email { get; set; }
        public Nullable<bool> isGuest { get; set; }
        public string IdNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseCentre> CourseCentres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegisteredCours> RegisteredCourses { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserType UserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room_Booking> Room_Booking { get; set; }
    }
}
