namespace MvcLabManager.Models;
using System.ComponentModel.DataAnnotations;

public class Lab
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public int Number { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Block { get; set; }

    public Lab() { }

    public Lab(int id, int number, string name, string block)
    {
        Id = id;
        Number = number;
        Name = name;
        Block = block;
    }
}