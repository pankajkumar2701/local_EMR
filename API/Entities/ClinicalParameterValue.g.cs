using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a clinicalparametervalue entity with essential details
    /// </summary>
    public class ClinicalParameterValue
    {
        /// <summary>
        /// TenantId of the ClinicalParameterValue 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ClinicalParameterValue 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the ClinicalParameterValue 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Sequence of the ClinicalParameterValue 
        /// </summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// Value of the ClinicalParameterValue 
        /// </summary>
        public string? Value { get; set; }
        /// <summary>
        /// IsAbnormal of the ClinicalParameterValue 
        /// </summary>
        public bool? IsAbnormal { get; set; }
    }
}