using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace StudentsApp.Models
{
    public class StudentContext : DbContext
    {
        public  DbSet<StudentModel> Students { get; set; }
    }
}