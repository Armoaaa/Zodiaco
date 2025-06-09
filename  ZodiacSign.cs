namespace ZodiacModels;

public class ZodiacSign
{
    public string Name { get; set; }
    public string DateRange { get; set; }
    public string[] Characteristics { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}