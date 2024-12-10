namespace Autoszerelo.Modell;
using System.ComponentModel.DataAnnotations;

public class Client
{
    public int Id { get; set; }  // Automatikusan generált EF által
    [Required(ErrorMessage = "A név megadása kötelező.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "A lakcím megadása kötelező.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Az email cím megadása kötelező.")]
    [EmailAddress(ErrorMessage = "Érvénytelen email cím formátum.")]
    public string Email { get; set; }
}