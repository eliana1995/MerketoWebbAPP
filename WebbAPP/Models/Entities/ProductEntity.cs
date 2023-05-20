
using System.ComponentModel.DataAnnotations;


namespace WebbAPP.Models.Entities;

public class ProductEntity
    {

    [Key]
    public string ArticleNumber { get; set; } = null!;
    public string? BarCode { get; set; }
    public string? ProductName { get; set; } = null!;
    public string? Ingress { get; set; }
    public string? Description { get; set; }
    public string? VendorName { get; set; }

    public ICollection<ProductTagEntity> Tags { get; set; } = new HashSet<ProductTagEntity>();

    /*public ICollection<ProductCategoryEntity> Categories { get; set; } = new HashSet<ProductCategoryEntity>();
    public ICollection<ProductTagEntity> Tags { get; set; } = new HashSet<ProductTagEntity>();
    public ICollection<ProductImageEntity> Images { get; set; } = new HashSet<ProductImageEntity>();
    public ICollection<ProductReviewEntity> Reviews { get; set; } = new HashSet<ProductReviewEntity>();*/

}
