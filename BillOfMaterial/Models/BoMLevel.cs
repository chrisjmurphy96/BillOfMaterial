namespace BillOfMaterial.Models;

public class BoMLevel
{
    public int PrimaryKey { get; set; }
    public string? PartNumber { get; set; }
    public float Quantity { get; set; }
    public string? Unit { get; set; }
    public float TotalCost { get; set; }
    public string? Vendor { get; set; }
    public string? Type { get; set; }
    public float Cost { get; set; }
    public float QuantityOnHand { get; set; }
    /// <summary>
    /// reference to another row if this is a multi-level BoM
    /// </summary>
    public int? ReferenceKey { get; set; }
    public BoMLevel? InnerLevel { get; set; }
}
