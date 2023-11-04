namespace wpf_financial_accounting_system.MVVM.Model;

public class CategoryModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get;set;  }
    public decimal? Budget { get; set; }
}