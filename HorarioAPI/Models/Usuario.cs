﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorarioAPI.Models {
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Sexo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
