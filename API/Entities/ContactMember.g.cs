using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a contactmember entity with essential details
    /// </summary>
    public class ContactMember
    {
        /// <summary>
        /// TenantId of the ContactMember 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ContactMember 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the ContactMember belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }
        /// <summary>
        /// Foreign key referencing the Title to which the ContactMember belongs 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Title
        /// </summary>
        [ForeignKey("TitleId")]
        public Title? TitleId_Title { get; set; }

        /// <summary>
        /// Required field FirstName of the ContactMember 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// MiddleName of the ContactMember 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the ContactMember 
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Required field Name of the ContactMember 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Gender to which the ContactMember belongs 
        /// </summary>
        public Guid? GenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Gender
        /// </summary>
        [ForeignKey("GenderId")]
        public Gender? GenderId_Gender { get; set; }

        /// <summary>
        /// Dob of the ContactMember 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        /// <summary>
        /// Age of the ContactMember 
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// DobIsApproximate of the ContactMember 
        /// </summary>
        public bool? DobIsApproximate { get; set; }
        /// <summary>
        /// Email of the ContactMember 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// MobileNumberCountryCode of the ContactMember 
        /// </summary>
        public int? MobileNumberCountryCode { get; set; }
        /// <summary>
        /// Mobile of the ContactMember 
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// AlternateNumberCountryCode of the ContactMember 
        /// </summary>
        public int? AlternateNumberCountryCode { get; set; }
        /// <summary>
        /// AlternateMobile of the ContactMember 
        /// </summary>
        public string? AlternateMobile { get; set; }
        /// <summary>
        /// MembershipNumber of the ContactMember 
        /// </summary>
        public string? MembershipNumber { get; set; }

        /// <summary>
        /// MembershipExpiryDate of the ContactMember 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? MembershipExpiryDate { get; set; }
        /// <summary>
        /// IsDependent of the ContactMember 
        /// </summary>
        public bool? IsDependent { get; set; }
        /// <summary>
        /// PrincipalMemberName of the ContactMember 
        /// </summary>
        public string? PrincipalMemberName { get; set; }
        /// <summary>
        /// PrincipalMembershipNumber of the ContactMember 
        /// </summary>
        public string? PrincipalMembershipNumber { get; set; }
        /// <summary>
        /// AddressLine1 of the ContactMember 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the ContactMember 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the ContactMember 
        /// </summary>
        public string? StateId { get; set; }
        /// <summary>
        /// CityId of the ContactMember 
        /// </summary>
        public string? CityId { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the ContactMember belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
        /// <summary>
        /// PostalCode of the ContactMember 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// NationalIdNumber of the ContactMember 
        /// </summary>
        public string? NationalIdNumber { get; set; }
        /// <summary>
        /// IsDisabled of the ContactMember 
        /// </summary>
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the ContactMember belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
    }
}