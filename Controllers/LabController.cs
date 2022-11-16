using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LabController : Controller
{
    private readonly LabManagerContext _context;

    public LabController(LabManagerContext context) {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Labs);
    }

    public IActionResult Show(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound();
        }

        return View(lab);
    }

    public IActionResult Delete(int id)
    {
        _context.Labs.Remove(_context.Labs.Find(id));
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}