using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a clinicalparameter entity with essential details
    /// </summary>
    public class ClinicalParameter
    {
        /// <summary>
        /// TenantId of the ClinicalParameter 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ClinicalParameter 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the ClinicalParameter 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// InputTypeId of the ClinicalParameter 
        /// </summary>
        public Guid? InputTypeId { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the ClinicalParameter belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }
        /// <summary>
        /// UnitTypeId of the ClinicalParameter 
        /// </summary>
        public Guid? UnitTypeId { get; set; }
        /// <summary>
        /// Notes of the ClinicalParameter 
        /// </summary>
        public bool? Notes { get; set; }
        /// <summary>
        /// Suggestion of the ClinicalParameter 
        /// </summary>
        public bool? Suggestion { get; set; }
        /// <summary>
        /// FeatureParameter of the ClinicalParameter 
        /// </summary>
        public bool? FeatureParameter { get; set; }
    }
}