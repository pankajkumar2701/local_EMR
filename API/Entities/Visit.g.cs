using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a visit entity with essential details
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// TenantId of the Visit 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Visit 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Visit 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// VisitTypeId of the Visit 
        /// </summary>
        public Guid? VisitTypeId { get; set; }
        /// <summary>
        /// VisitModeId of the Visit 
        /// </summary>
        public Guid? VisitModeId { get; set; }
        /// <summary>
        /// Foreign key referencing the Patient to which the Visit belongs 
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Patient
        /// </summary>
        [ForeignKey("PatientId")]
        public Patient? PatientId_Patient { get; set; }

        /// <summary>
        /// VisitStartDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? VisitStartDate { get; set; }

        /// <summary>
        /// VisitCloseDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? VisitCloseDate { get; set; }

        /// <summary>
        /// PreviousVisitDate of the Visit 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PreviousVisitDate { get; set; }
        /// <summary>
        /// PreviousVisitId of the Visit 
        /// </summary>
        public Guid? PreviousVisitId { get; set; }
        /// <summary>
        /// PrescriptionConverted of the Visit 
        /// </summary>
        public bool? PrescriptionConverted { get; set; }
        /// <summary>
        /// VisitAttending of the Visit 
        /// </summary>
        public bool? VisitAttending { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Visit belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? LocationId_Location { get; set; }
        /// <summary>
        /// ContactId of the Visit 
        /// </summary>
        public Guid? ContactId { get; set; }
        /// <summary>
        /// CreditVisit of the Visit 
        /// </summary>
        public bool? CreditVisit { get; set; }
        /// <summary>
        /// CoverCategoryId of the Visit 
        /// </summary>
        public string? CoverCategoryId { get; set; }
        /// <summary>
        /// MedicationLayout of the Visit 
        /// </summary>
        public int? MedicationLayout { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitType to which the Visit belongs 
        /// </summary>
        public Guid? VisitType { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitType
        /// </summary>
        [ForeignKey("VisitType")]
        public VisitType? VisitType_VisitType { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitMode to which the Visit belongs 
        /// </summary>
        public Guid? VisitMode { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitMode
        /// </summary>
        [ForeignKey("VisitMode")]
        public VisitMode? VisitMode_VisitMode { get; set; }
        /// <summary>
        /// Foreign key referencing the Doctor to which the Visit belongs 
        /// </summary>
        public Guid? Doctor { get; set; }

        /// <summary>
        /// Navigation property representing the associated Doctor
        /// </summary>
        [ForeignKey("Doctor")]
        public Doctor? Doctor_Doctor { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the Visit belongs 
        /// </summary>
        public Guid? Contact { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("Contact")]
        public Address? Contact_Address { get; set; }
        /// <summary>
        /// Foreign key referencing the Appointment to which the Visit belongs 
        /// </summary>
        public Guid? Appointment { get; set; }

        /// <summary>
        /// Navigation property representing the associated Appointment
        /// </summary>
        [ForeignKey("Appointment")]
        public Appointment? Appointment_Appointment { get; set; }
        /// <summary>
        /// Foreign key referencing the DayVisit to which the Visit belongs 
        /// </summary>
        public Guid? DayVisit { get; set; }

        /// <summary>
        /// Navigation property representing the associated DayVisit
        /// </summary>
        [ForeignKey("DayVisit")]
        public DayVisit? DayVisit_DayVisit { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitChiefComplaint to which the Visit belongs 
        /// </summary>
        public Guid? VisitChiefComplaint { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitChiefComplaint
        /// </summary>
        [ForeignKey("VisitChiefComplaint")]
        public VisitChiefComplaint? VisitChiefComplaint_VisitChiefComplaint { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitDiagnosis to which the Visit belongs 
        /// </summary>
        public Guid? VisitDiagnosis { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitDiagnosis
        /// </summary>
        [ForeignKey("VisitDiagnosis")]
        public VisitDiagnosis? VisitDiagnosis_VisitDiagnosis { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitGuideline to which the Visit belongs 
        /// </summary>
        public Guid? VisitGuideline { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitGuideline
        /// </summary>
        [ForeignKey("VisitGuideline")]
        public VisitGuideline? VisitGuideline_VisitGuideline { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitVitalTemplateParameter to which the Visit belongs 
        /// </summary>
        public Guid? VisitVitalTemplateParameter { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitVitalTemplateParameter
        /// </summary>
        [ForeignKey("VisitVitalTemplateParameter")]
        public VisitVitalTemplateParameter? VisitVitalTemplateParameter_VisitVitalTemplateParameter { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitInvestigation to which the Visit belongs 
        /// </summary>
        public Guid? VisitInvestigation { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitInvestigation
        /// </summary>
        [ForeignKey("VisitInvestigation")]
        public VisitInvestigation? VisitInvestigation_VisitInvestigation { get; set; }
        /// <summary>
        /// VisitClinicalPrintableNotes of the Visit 
        /// </summary>
        public string? VisitClinicalPrintableNotes { get; set; }
        /// <summary>
        /// Foreign key referencing the Invoice to which the Visit belongs 
        /// </summary>
        public Guid? Invoice { get; set; }

        /// <summary>
        /// Navigation property representing the associated Invoice
        /// </summary>
        [ForeignKey("Invoice")]
        public Invoice? Invoice_Invoice { get; set; }
        /// <summary>
        /// Foreign key referencing the Dispense to which the Visit belongs 
        /// </summary>
        public Guid? Dispenses { get; set; }

        /// <summary>
        /// Navigation property representing the associated Dispense
        /// </summary>
        [ForeignKey("Dispenses")]
        public Dispense? Dispenses_Dispense { get; set; }
        /// <summary>
        /// VisitReferralNotes of the Visit 
        /// </summary>
        public string? VisitReferralNotes { get; set; }
        /// <summary>
        /// Foreign key referencing the VisitMedicalCertificate to which the Visit belongs 
        /// </summary>
        public Guid? VisitMedicalCertificates { get; set; }

        /// <summary>
        /// Navigation property representing the associated VisitMedicalCertificate
        /// </summary>
        [ForeignKey("VisitMedicalCertificates")]
        public VisitMedicalCertificate? VisitMedicalCertificates_VisitMedicalCertificate { get; set; }
    }
}