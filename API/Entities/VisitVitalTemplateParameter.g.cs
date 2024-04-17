using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a visitvitaltemplateparameter entity with essential details
    /// </summary>
    public class VisitVitalTemplateParameter
    {
        /// <summary>
        /// TenantId of the VisitVitalTemplateParameter 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the VisitVitalTemplateParameter 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the VisitVitalTemplateParameter 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Visit to which the VisitVitalTemplateParameter belongs 
        /// </summary>
        public Guid? VisitId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Visit
        /// </summary>
        [ForeignKey("VisitId")]
        public Visit? VisitId_Visit { get; set; }
        /// <summary>
        /// Foreign key referencing the ClinicalParameter to which the VisitVitalTemplateParameter belongs 
        /// </summary>
        public Guid? ClinicalParameterId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ClinicalParameter
        /// </summary>
        [ForeignKey("ClinicalParameterId")]
        public ClinicalParameter? ClinicalParameterId_ClinicalParameter { get; set; }
        /// <summary>
        /// Foreign key referencing the ClinicalParameterValue to which the VisitVitalTemplateParameter belongs 
        /// </summary>
        public Guid? ClinicalParameterValueId { get; set; }

        /// <summary>
        /// Navigation property representing the associated ClinicalParameterValue
        /// </summary>
        [ForeignKey("ClinicalParameterValueId")]
        public ClinicalParameterValue? ClinicalParameterValueId_ClinicalParameterValue { get; set; }
        /// <summary>
        /// ClinicalParameterValueName of the VisitVitalTemplateParameter 
        /// </summary>
        public string? ClinicalParameterValueName { get; set; }
        /// <summary>
        /// TextValue of the VisitVitalTemplateParameter 
        /// </summary>
        public string? TextValue { get; set; }
        /// <summary>
        /// NumberValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? NumberValue { get; set; }
        /// <summary>
        /// NumericValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? NumericValue { get; set; }

        /// <summary>
        /// DateValue of the VisitVitalTemplateParameter 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateValue { get; set; }

        /// <summary>
        /// DateTimeValue of the VisitVitalTemplateParameter 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeValue { get; set; }

        /// <summary>
        /// TimeValue of the VisitVitalTemplateParameter 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? TimeValue { get; set; }
        /// <summary>
        /// SystolicValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? SystolicValue { get; set; }
        /// <summary>
        /// DiastolicValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? DiastolicValue { get; set; }
        /// <summary>
        /// YearValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? YearValue { get; set; }
        /// <summary>
        /// DurationValue of the VisitVitalTemplateParameter 
        /// </summary>
        public int? DurationValue { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the VisitVitalTemplateParameter belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }

        /// <summary>
        /// Required field Sequence of the VisitVitalTemplateParameter 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// IsSpecificValue of the VisitVitalTemplateParameter 
        /// </summary>
        public bool? IsSpecificValue { get; set; }
        /// <summary>
        /// AssociatedNotes of the VisitVitalTemplateParameter 
        /// </summary>
        public string? AssociatedNotes { get; set; }
    }
}