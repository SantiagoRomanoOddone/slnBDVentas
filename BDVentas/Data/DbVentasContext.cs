﻿using BDVentas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVentas.Data
{
    public class DbVentasContext : DbContext
    {
        public DbVentasContext() : base("KeyDbVentas") { }

        // propiedades DbSet<m>
        // De trabajador
        public DbSet<Trabajador> Trabajadores { get; set; }

    }
}
