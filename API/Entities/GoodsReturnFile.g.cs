using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a goodsreturnfile entity with essential details
    /// </summary>
    public class GoodsReturnFile
    {
        /// <summary>
        /// TenantId of the GoodsReturnFile 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the GoodsReturnFile 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }

        /// <summary>
        /// Required field Name of the GoodsReturnFile 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the GoodsReturn to which the GoodsReturnFile belongs 
        /// </summary>
        public Guid? GoodsReturnId { get; set; }

        /// <summary>
        /// Navigation property representing the associated GoodsReturn
        /// </summary>
        [ForeignKey("GoodsReturnId")]
        public GoodsReturn? GoodsReturnId_GoodsReturn { get; set; }
        /// <summary>
        /// GoodsReturnCode of the GoodsReturnFile 
        /// </summary>
        public string? GoodsReturnCode { get; set; }
        /// <summary>
        /// Title of the GoodsReturnFile 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// FileName of the GoodsReturnFile 
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// FileExtension of the GoodsReturnFile 
        /// </summary>
        public string? FileExtension { get; set; }
        /// <summary>
        /// MimeType of the GoodsReturnFile 
        /// </summary>
        public string? MimeType { get; set; }
        /// <summary>
        /// AzureFilePath of the GoodsReturnFile 
        /// </summary>
        public string? AzureFilePath { get; set; }
        /// <summary>
        /// CreatedBy of the GoodsReturnFile 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the GoodsReturnFile 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Print of the GoodsReturnFile 
        /// </summary>
        public bool? Print { get; set; }
    }
}