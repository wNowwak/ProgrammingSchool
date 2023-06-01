namespace Currency.Models;

public class CurrencyRateDto
{
    public string No { get; set; } = string.Empty;
    public DateTime EffectiveDate { get; set; }
    public decimal Mid { get; set; }
}
