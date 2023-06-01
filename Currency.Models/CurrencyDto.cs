namespace Currency.Models;

public class CurrencyDto
{
    public string Table { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public List<CurrencyRateDto> Rates { get; set; } = new();
}
