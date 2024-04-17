using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a doctor entity with essential details
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// TenantId of the Doctor 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Doctor 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// EntityCode of the Doctor 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Doctor 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }

        /// <summary>
        /// Required field Name of the Doctor 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Code of the Doctor 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// IsStandard of the Doctor 
        /// </summary>
        public bool? IsStandard { get; set; }
        /// <summary>
        /// DateOfBirth of the Doctor 
        /// </summary>
        public string? DateOfBirth { get; set; }
        /// <summary>
        /// DobIsApproximate of the Doctor 
        /// </summary>
        public bool? DobIsApproximate { get; set; }
        /// <summary>
        /// Foreign key referencing the Title to which the Doctor belongs 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Title
        /// </summary>
        [ForeignKey("TitleId")]
        public Title? TitleId_Title { get; set; }

        /// <summary>
        /// Required field FirstName of the Doctor 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Doctor 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Doctor 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the Doctor belongs 
        /// </summary>
        public Guid? OfficialAddressId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("OfficialAddressId")]
        public Address? OfficialAddressId_Address { get; set; }
        /// <summary>
        /// TimezoneId of the Doctor 
        /// </summary>
        public string? TimezoneId { get; set; }
        /// <summary>
        /// Foreign key referencing the Language to which the Doctor belongs 
        /// </summary>
        public Guid? LanguageId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Language
        /// </summary>
        [ForeignKey("LanguageId")]
        public Language? LanguageId_Language { get; set; }
        /// <summary>
        /// Foreign key referencing the Gender to which the Doctor belongs 
        /// </summary>
        public Guid? GenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Gender
        /// </summary>
        [ForeignKey("GenderId")]
        public Gender? GenderId_Gender { get; set; }
        /// <summary>
        /// NationalityId of the Doctor 
        /// </summary>
        public string? NationalityId { get; set; }
        /// <summary>
        /// MedicalRegistrationNumber of the Doctor 
        /// </summary>
        public string? MedicalRegistrationNumber { get; set; }
        /// <summary>
        /// Qualifications of the Doctor 
        /// </summary>
        public string? Qualifications { get; set; }
        /// <summary>
        /// Specialisations of the Doctor 
        /// </summary>
        public string? Specialisations { get; set; }
        /// <summary>
        /// ProfessionalMemberships of the Doctor 
        /// </summary>
        public string? ProfessionalMemberships { get; set; }
        /// <summary>
        /// CommunicationVerificationId of the Doctor 
        /// </summary>
        public string? CommunicationVerificationId { get; set; }
        /// <summary>
        /// AgeUnitId of the Doctor 
        /// </summary>
        public string? AgeUnitId { get; set; }
        /// <summary>
        /// Age of the Doctor 
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// Deleted of the Doctor 
        /// </summary>
        public bool? Deleted { get; set; }
        /// <summary>
        /// BankDetailCompleted of the Doctor 
        /// </summary>
        public bool? BankDetailCompleted { get; set; }
        /// <summary>
        /// SpecialityId of the Doctor 
        /// </summary>
        public string? SpecialityId { get; set; }
        /// <summary>
        /// CalendarSync of the Doctor 
        /// </summary>
        public bool? CalendarSync { get; set; }
        /// <summary>
        /// StaffCode of the Doctor 
        /// </summary>
        public string? StaffCode { get; set; }
        /// <summary>
        /// ZohoLeadId of the Doctor 
        /// </summary>
        public string? ZohoLeadId { get; set; }
        /// <summary>
        /// Notes of the Doctor 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// AddressLine1 of the Doctor 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Doctor 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// Foreign key referencing the State to which the Doctor belongs 
        /// </summary>
        public Guid? StateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated State
        /// </summary>
        [ForeignKey("StateId")]
        public State? StateId_State { get; set; }
        /// <summary>
        /// Foreign key referencing the City to which the Doctor belongs 
        /// </summary>
        public Guid? CityId { get; set; }

        /// <summary>
        /// Navigation property representing the associated City
        /// </summary>
        [ForeignKey("CityId")]
        public City? CityId_City { get; set; }
        /// <summary>
        /// PostalCode of the Doctor 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Doctor belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
    }
}