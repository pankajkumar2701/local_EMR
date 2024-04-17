using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a medication entity with essential details
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// TenantId of the Medication 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Medication 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the Medication 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// ReadyRx of the Medication 
        /// </summary>
        public bool? ReadyRx { get; set; }
        /// <summary>
        /// FormulationCode of the Medication 
        /// </summary>
        public string? FormulationCode { get; set; }
        /// <summary>
        /// OtcDrug of the Medication 
        /// </summary>
        public bool? OtcDrug { get; set; }
        /// <summary>
        /// SystemFavourite of the Medication 
        /// </summary>
        public bool? SystemFavourite { get; set; }
        /// <summary>
        /// Generic of the Medication 
        /// </summary>
        public string? Generic { get; set; }
        /// <summary>
        /// Deleted of the Medication 
        /// </summary>
        public bool? Deleted { get; set; }
        /// <summary>
        /// MedicationType of the Medication 
        /// </summary>
        public int? MedicationType { get; set; }
        /// <summary>
        /// Foreign key referencing the RouteInfo to which the Medication belongs 
        /// </summary>
        public Guid? RouteId { get; set; }

        /// <summary>
        /// Navigation property representing the associated RouteInfo
        /// </summary>
        [ForeignKey("RouteId")]
        public RouteInfo? RouteId_RouteInfo { get; set; }
        /// <summary>
        /// Foreign key referencing the MedicationDosage to which the Medication belongs 
        /// </summary>
        public Guid? MedicationDosages { get; set; }

        /// <summary>
        /// Navigation property representing the associated MedicationDosage
        /// </summary>
        [ForeignKey("MedicationDosages")]
        public MedicationDosage? MedicationDosages_MedicationDosage { get; set; }
        /// <summary>
        /// Foreign key referencing the MedicationComposition to which the Medication belongs 
        /// </summary>
        public Guid? MedicationCompositions { get; set; }

        /// <summary>
        /// Navigation property representing the associated MedicationComposition
        /// </summary>
        [ForeignKey("MedicationCompositions")]
        public MedicationComposition? MedicationCompositions_MedicationComposition { get; set; }
        /// <summary>
        /// Foreign key referencing the DoctorFavouriteMedication to which the Medication belongs 
        /// </summary>
        public Guid? DoctorFavouriteMedication { get; set; }

        /// <summary>
        /// Navigation property representing the associated DoctorFavouriteMedication
        /// </summary>
        [ForeignKey("DoctorFavouriteMedication")]
        public DoctorFavouriteMedication? DoctorFavouriteMedication_DoctorFavouriteMedication { get; set; }
        /// <summary>
        /// Foreign key referencing the Product to which the Medication belongs 
        /// </summary>
        public Guid? Product { get; set; }

        /// <summary>
        /// Navigation property representing the associated Product
        /// </summary>
        [ForeignKey("Product")]
        public Product? Product_Product { get; set; }
        /// <summary>
        /// Foreign key referencing the DrugListItems to which the Medication belongs 
        /// </summary>
        public Guid? DrugListItems { get; set; }

        /// <summary>
        /// Navigation property representing the associated DrugListItems
        /// </summary>
        [ForeignKey("DrugListItems")]
        public DrugListItems? DrugListItems_DrugListItems { get; set; }
    }
}