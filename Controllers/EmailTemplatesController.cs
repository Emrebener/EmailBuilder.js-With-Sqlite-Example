using EmailBuilderTest.Data;
using EmailBuilderTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace EmailBuilderTest.Controllers;

public class EmailTemplatesController : Controller
{
    private readonly ApplicationDbContext _context;

    public EmailTemplatesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var templates = _context.EmailTemplates.ToList();
        return View(templates);
    }

    [HttpPost]
    public async Task<IActionResult> SaveTemplate([FromBody] EmailTemplateDto template)
    {
        if (template.Id == "" || !_context.EmailTemplates.Any(t => t.Id == template.Id))
        {
            template.Id = Guid.NewGuid().ToString();
            _context.EmailTemplates.Add(template);
        }
        else
        {
            var existing = await _context.EmailTemplates.FindAsync(template.Id);
            if (existing != null)
            {
                existing.Name = template.Name;
                existing.JsonDesign = template.JsonDesign;
                existing.HtmlContent = template.HtmlContent;
                _context.EmailTemplates.Update(existing);
            }
        }

        await _context.SaveChangesAsync();
        return Ok(template);
    }

    [HttpGet]
    public async Task<IActionResult> GetTemplate(string id)
    {
        var template = await _context.EmailTemplates.FindAsync(id);
        if (template == null)
            return NotFound();

        return Json(template);
    }
}
