using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoJaramillo_TallerMVC.Models;

    public class TallerMVC_Db_Context : DbContext
    {
        public TallerMVC_Db_Context (DbContextOptions<TallerMVC_Db_Context> options)
            : base(options)
        {
        }

        public DbSet<MateoJaramillo_TallerMVC.Models.Burguer> Burguer { get; set; } = default!;
    }
