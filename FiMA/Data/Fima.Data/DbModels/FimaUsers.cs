
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Fima.Data.DbModels
{

using System;
    using System.Collections.Generic;
    
public partial class FimaUsers
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public FimaUsers()
    {

        this.FimaClaims = new HashSet<FimaClaims>();

        this.FimaLogins = new HashSet<FimaLogins>();

        this.FimaRoles = new HashSet<FimaRoles>();

    }


    public int Id { get; set; }

    public string UserName { get; set; }

    public string strEmpPassword { get; set; }

    public string strAccess { get; set; }

    public string strName { get; set; }

    public string strTown { get; set; }

    public string strIndex { get; set; }

    public string EmpFunction { get; set; }

    public string emptown { get; set; }

    public string Email { get; set; }

    public Nullable<bool> EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string PhoneNumber { get; set; }

    public Nullable<bool> PhoneNumberConfirmed { get; set; }

    public Nullable<bool> TwoFactorEnabled { get; set; }

    public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }

    public Nullable<bool> LockoutEnabled { get; set; }

    public Nullable<int> AccessFailedCount { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FimaClaims> FimaClaims { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FimaLogins> FimaLogins { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FimaRoles> FimaRoles { get; set; }

}

}
