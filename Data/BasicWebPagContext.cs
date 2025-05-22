using System;
using System.Collections.Generic;
using BasicWebPag.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicWebPag.Data;

public partial class BasicWebPagContext : DbContext
{
    public BasicWebPagContext()
    {
    }

    public BasicWebPagContext(DbContextOptions<BasicWebPagContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Department { get; set; }
}
