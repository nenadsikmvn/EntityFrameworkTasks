//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkTasks.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Grades = new HashSet<Grade>();
        }
   
        public int StudentId { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Ime ne moze biti duze od 50 slova niti manje od 3")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        [DisplayName("Index No.")]
        public int IndexNo { get; set; }
        public int ProgrammeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual StudyProgramme StudyProgramme { get; set; }
    }
}