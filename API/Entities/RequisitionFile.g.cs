using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a requisitionfile entity with essential details
    /// </summary>
    public class RequisitionFile
    {
        /// <summary>
        /// Primary key for the RequisitionFile 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the RequisitionFile 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the RequisitionFile 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Requisition to which the RequisitionFile belongs 
        /// </summary>
        public Guid? RequisitionId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Requisition
        /// </summary>
        [ForeignKey("RequisitionId")]
        public Requisition? RequisitionId_Requisition { get; set; }
        /// <summary>
        /// RequisitionCode of the RequisitionFile 
        /// </summary>
        public string? RequisitionCode { get; set; }
        /// <summary>
        /// Title of the RequisitionFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the RequisitionFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the RequisitionFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the RequisitionFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the RequisitionFile 
        /// </summary>
        public string? AzureFilePath { get; set; }
        /// <summary>
        /// CreatedBy of the RequisitionFile 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the RequisitionFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Print of the RequisitionFile 
        /// </summary>
        public bool? Print { get; set; }
    }
}