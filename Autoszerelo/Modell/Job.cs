namespace Autoszerelo.Modell;
using System.ComponentModel.DataAnnotations;

public class Job
{
    public int Id { get; set; }  // Automatikusan generált EF által

    public int ClientId { get; set; }  // Ügyfél ID (Kapcsolódás)

    [Required(ErrorMessage = "A gépjármű rendszám megadása kötelező.")]
    [RegularExpression(@"^[A-Z]{3}-\d{3}$", ErrorMessage = "A rendszám formátuma helytelen. Pl. ABC-123")]
    public string LicensePlate { get; set; }

    [Range(1900, int.MaxValue, ErrorMessage = "A gyártási év nem lehet kisebb 1900-nál.")]
    public int Year { get; set; }

    [Required(ErrorMessage = "A munka kategóriája megadása kötelező.")]
    public string Category { get; set; }

    [Required(ErrorMessage = "A hiba leírása kötelező.")]
    public string Description { get; set; }

    [Range(1, 10, ErrorMessage = "A hiba súlyosságának 1 és 10 között kell lennie.")]
    public int Severity { get; set; }

    [Required(ErrorMessage = "A munka állapotának megadása kötelező.")]
    public string Status { get; set; }
}