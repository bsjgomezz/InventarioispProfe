using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Pais
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;

        public int ProvinciaId { get; set; } = 0;

        public bool IsDeleted { get; set; } = false;
    }
}