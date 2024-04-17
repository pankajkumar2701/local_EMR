using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace local_EMR.Entities
{
    /// <summary> 
    /// Represents a productcategory entity with essential details
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// TenantId of the ProductCategory 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the ProductCategory 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Code of the ProductCategory 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field Name of the ProductCategory 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// IsStandard of the ProductCategory 
        /// </summary>
        public bool? IsStandard { get; set; }
        /// <summary>
        /// ProductType of the ProductCategory 
        /// </summary>
        public int? ProductType { get; set; }
        /// <summary>
        /// Enabled of the ProductCategory 
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// MappedToSupplier of the ProductCategory 
        /// </summary>
        public bool? MappedToSupplier { get; set; }
        /// <summary>
        /// CanHaveInventory of the ProductCategory 
        /// </summary>
        public bool? CanHaveInventory { get; set; }
        /// <summary>
        /// CreatedBy of the ProductCategory 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the ProductCategory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the ProductCategory 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the ProductCategory 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}