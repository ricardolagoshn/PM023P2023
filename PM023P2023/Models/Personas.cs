﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using SQLite;

namespace PM023P2023.Models
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; } = string.Empty;
        public DateTime fechanac { get; set; }

        [MaxLength(30), Unique]
        public int telefono { get; set;} 
        public byte[] foto { get; set; }
    }
}
