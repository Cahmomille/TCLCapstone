using System.ComponentModel.DataAnnotations;

namespace RazorPagesUser.Models;

public class User
{
    public int Id { get; set; }

    public string? firstName { get; set; }
    public string? lastName { get; set; }

}