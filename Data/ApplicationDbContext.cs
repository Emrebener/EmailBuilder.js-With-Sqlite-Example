using EmailBuilderTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmailBuilderTest.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<EmailTemplateDto> EmailTemplates => Set<EmailTemplateDto>();
}
