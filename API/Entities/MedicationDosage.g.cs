using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a medicationdosage entity with essential details
    /// </summary>
    public class MedicationDosage
    {
        /// <summary>
        /// TenantId of the MedicationDosage 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the MedicationDosage 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the MedicationDosage 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the MedicationDosage belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
        /// <summary>
        /// Dosage of the MedicationDosage 
        /// </summary>
        public int? Dosage { get; set; }
        /// <summary>
        /// Frequency of the MedicationDosage 
        /// </summary>
        public int? Frequency { get; set; }
        /// <summary>
        /// SingleDosage of the MedicationDosage 
        /// </summary>
        public bool? SingleDosage { get; set; }
        /// <summary>
        /// Duration of the MedicationDosage 
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Foreign key referencing the Uom to which the MedicationDosage belongs 
        /// </summary>
        public Guid? UomId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Uom
        /// </summary>
        [ForeignKey("UomId")]
        public Uom? UomId_Uom { get; set; }
        /// <summary>
        /// Ongoing of the MedicationDosage 
        /// </summary>
        public bool? Ongoing { get; set; }
        /// <summary>
        /// Stat of the MedicationDosage 
        /// </summary>
        public bool? Stat { get; set; }
        /// <summary>
        /// Quantity of the MedicationDosage 
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// Required field Sequence of the MedicationDosage 
        /// </summary>
        [Required]
        public int Sequence { get; set; }
        /// <summary>
        /// Favourite of the MedicationDosage 
        /// </summary>
        public bool? Favourite { get; set; }
        /// <summary>
        /// DosageFormType of the MedicationDosage 
        /// </summary>
        public int? DosageFormType { get; set; }
        /// <summary>
        /// DosageFormat of the MedicationDosage 
        /// </summary>
        public string? DosageFormat { get; set; }
        /// <summary>
        /// DosageFormatFrequencyId of the MedicationDosage 
        /// </summary>
        public Guid? DosageFormatFrequencyId { get; set; }
    }
}