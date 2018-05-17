using System;
using System.Collections.Generic;
using System.Text;
using Adventure.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Adventure.Data
{
    public class AdventureContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}
