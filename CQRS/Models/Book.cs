using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
    }
}
