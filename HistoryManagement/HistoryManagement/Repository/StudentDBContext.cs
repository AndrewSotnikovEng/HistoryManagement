using HistoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HistoryManagement.Repository
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}