namespace MvcLabManager.Models;
using System.ComponentModel.DataAnnotations;

public class Computer
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Ram { get; set; }

    [Required(ErrorMessage = "Preencha o campo")]
    public string Processor { get; set; }

    public Computer() { }

    public Computer(int id, string ram, string processor)
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}