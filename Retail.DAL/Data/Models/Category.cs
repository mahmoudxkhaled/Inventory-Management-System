namespace Retail.DAL;

public class Category
{
    public Guid ID { get; set; }
    public string NAME { get; set; } = string.Empty;
    public string DESCRIPTION { get; set; } = string.Empty;
    public ICollection<Product> PRODUCTS { get; set; } = new HashSet<Product>();

}
