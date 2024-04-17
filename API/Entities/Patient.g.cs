using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a patient entity with essential details
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// TenantId of the Patient 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Patient 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Code of the Patient 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Patient 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Title to which the Patient belongs 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Title
        /// </summary>
        [ForeignKey("TitleId")]
        public Title? TitleId_Title { get; set; }
        /// <summary>
        /// FirstName of the Patient 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Patient 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Patient 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Foreign key referencing the Gender to which the Patient belongs 
        /// </summary>
        public Guid? GenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Gender
        /// </summary>
        [ForeignKey("GenderId")]
        public Gender? GenderId_Gender { get; set; }

        /// <summary>
        /// Dob of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        /// <summary>
        /// NationalIdNumber of the Patient 
        /// </summary>
        public string? NationalIdNumber { get; set; }

        /// <summary>
        /// RegisteredOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RegisteredOn { get; set; }

        /// <summary>
        /// DateOfDeath of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateOfDeath { get; set; }
        /// <summary>
        /// ReasonOfDeath of the Patient 
        /// </summary>
        public string? ReasonOfDeath { get; set; }
        /// <summary>
        /// IsDeceased of the Patient 
        /// </summary>
        public bool? IsDeceased { get; set; }
        /// <summary>
        /// ReferredBy of the Patient 
        /// </summary>
        public string? ReferredBy { get; set; }
        /// <summary>
        /// Mobile of the Patient 
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Email of the Patient 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the Patient belongs 
        /// </summary>
        public Guid? AddressId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("AddressId")]
        public Address? AddressId_Address { get; set; }

        /// <summary>
        /// LastVisitDate of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastVisitDate { get; set; }
        /// <summary>
        /// EntityCode of the Patient 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Patient 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// Foreign key referencing the BloodGroup to which the Patient belongs 
        /// </summary>
        public Guid? BloodGroup { get; set; }

        /// <summary>
        /// Navigation property representing the associated BloodGroup
        /// </summary>
        [ForeignKey("BloodGroup")]
        public BloodGroup? BloodGroup_BloodGroup { get; set; }
        /// <summary>
        /// FileNumber of the Patient 
        /// </summary>
        public string? FileNumber { get; set; }
        /// <summary>
        /// CreatedBy of the Patient 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Patient 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// AlternateMobile of the Patient 
        /// </summary>
        public string? AlternateMobile { get; set; }
        /// <summary>
        /// IsDisabled of the Patient 
        /// </summary>
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// MobileNumberCountryCode of the Patient 
        /// </summary>
        public int? MobileNumberCountryCode { get; set; }
        /// <summary>
        /// AlternateNumberCountryCode of the Patient 
        /// </summary>
        public int? AlternateNumberCountryCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Patient belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientNotes to which the Patient belongs 
        /// </summary>
        public Guid? PatientNotes { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientNotes
        /// </summary>
        [ForeignKey("PatientNotes")]
        public PatientNotes? PatientNotes_PatientNotes { get; set; }
        /// <summary>
        /// Import of the Patient 
        /// </summary>
        public bool? Import { get; set; }
        /// <summary>
        /// Foreign key referencing the Membership to which the Patient belongs 
        /// </summary>
        public Guid? MembershipId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Membership
        /// </summary>
        [ForeignKey("MembershipId")]
        public Membership? MembershipId_Membership { get; set; }
        /// <summary>
        /// PatientEnrollment of the Patient 
        /// </summary>
        public bool? PatientEnrollment { get; set; }

        /// <summary>
        /// EnrollmentDate of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EnrollmentDate { get; set; }
        /// <summary>
        /// Landline of the Patient 
        /// </summary>
        public string? Landline { get; set; }
        /// <summary>
        /// IsVip of the Patient 
        /// </summary>
        public bool? IsVip { get; set; }
        /// <summary>
        /// IsConfidential of the Patient 
        /// </summary>
        public bool? IsConfidential { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientAllergy to which the Patient belongs 
        /// </summary>
        public Guid? PatientAllergy { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientAllergy
        /// </summary>
        [ForeignKey("PatientAllergy")]
        public PatientAllergy? PatientAllergy_PatientAllergy { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientStatistics to which the Patient belongs 
        /// </summary>
        public Guid? PatientStatistics { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientStatistics
        /// </summary>
        [ForeignKey("PatientStatistics")]
        public PatientStatistics? PatientStatistics_PatientStatistics { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientCategory to which the Patient belongs 
        /// </summary>
        public Guid? PatientCategories { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientCategory
        /// </summary>
        [ForeignKey("PatientCategories")]
        public PatientCategory? PatientCategories_PatientCategory { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientComorbidity to which the Patient belongs 
        /// </summary>
        public Guid? PatientComorbidities { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientComorbidity
        /// </summary>
        [ForeignKey("PatientComorbidities")]
        public PatientComorbidity? PatientComorbidities_PatientComorbidity { get; set; }
        /// <summary>
        /// Foreign key referencing the ContactMember to which the Patient belongs 
        /// </summary>
        public Guid? ContactMembers { get; set; }

        /// <summary>
        /// Navigation property representing the associated ContactMember
        /// </summary>
        [ForeignKey("ContactMembers")]
        public ContactMember? ContactMembers_ContactMember { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientPayor to which the Patient belongs 
        /// </summary>
        public Guid? PatientPayors { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientPayor
        /// </summary>
        [ForeignKey("PatientPayors")]
        public PatientPayor? PatientPayors_PatientPayor { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientLifeStyle to which the Patient belongs 
        /// </summary>
        public Guid? PatientLifeStyle { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientLifeStyle
        /// </summary>
        [ForeignKey("PatientLifeStyle")]
        public PatientLifeStyle? PatientLifeStyle_PatientLifeStyle { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientEnrollmentLink to which the Patient belongs 
        /// </summary>
        public Guid? PatientEnrollmentLinks { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientEnrollmentLink
        /// </summary>
        [ForeignKey("PatientEnrollmentLinks")]
        public PatientEnrollmentLink? PatientEnrollmentLinks_PatientEnrollmentLink { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientHospitalisationHistory to which the Patient belongs 
        /// </summary>
        public Guid? PatientHospitalisationHistories { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientHospitalisationHistory
        /// </summary>
        [ForeignKey("PatientHospitalisationHistories")]
        public PatientHospitalisationHistory? PatientHospitalisationHistories_PatientHospitalisationHistory { get; set; }
        /// <summary>
        /// Foreign key referencing the PregnancyHistory to which the Patient belongs 
        /// </summary>
        public Guid? PregnancyHistories { get; set; }

        /// <summary>
        /// Navigation property representing the associated PregnancyHistory
        /// </summary>
        [ForeignKey("PregnancyHistories")]
        public PregnancyHistory? PregnancyHistories_PregnancyHistory { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientMedicalHistoryNote to which the Patient belongs 
        /// </summary>
        public Guid? PatientMedicalHistoryNotes { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientMedicalHistoryNote
        /// </summary>
        [ForeignKey("PatientMedicalHistoryNotes")]
        public PatientMedicalHistoryNote? PatientMedicalHistoryNotes_PatientMedicalHistoryNote { get; set; }
        /// <summary>
        /// Foreign key referencing the PatientPregnancy to which the Patient belongs 
        /// </summary>
        public Guid? PatientPregnancies { get; set; }

        /// <summary>
        /// Navigation property representing the associated PatientPregnancy
        /// </summary>
        [ForeignKey("PatientPregnancies")]
        public PatientPregnancy? PatientPregnancies_PatientPregnancy { get; set; }
        /// <summary>
        /// AddressLine1 of the Patient 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Patient 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// Foreign key referencing the State to which the Patient belongs 
        /// </summary>
        public Guid? StateId { get; set; }

        /// <summary>
        /// Navigation property representing the associated State
        /// </summary>
        [ForeignKey("StateId")]
        public State? StateId_State { get; set; }
        /// <summary>
        /// Foreign key referencing the City to which the Patient belongs 
        /// </summary>
        public Guid? CityId { get; set; }

        /// <summary>
        /// Navigation property representing the associated City
        /// </summary>
        [ForeignKey("CityId")]
        public City? CityId_City { get; set; }
        /// <summary>
        /// PostalCode of the Patient 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Country to which the Patient belongs 
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Country
        /// </summary>
        [ForeignKey("CountryId")]
        public Country? CountryId_Country { get; set; }
    }
}