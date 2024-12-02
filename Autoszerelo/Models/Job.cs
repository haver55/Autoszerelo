namespace Autoszerelo.Models;

public class Job
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string LicensePlate { get; set; }
    public int YearOfManufacture { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int Severity { get; set; }
    public string Status { get; set; }
    public double EstimatedHours { get; set; }
    public Customer Customer { get; set; }
}