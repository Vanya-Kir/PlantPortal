using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    public class Disease
    {
        public long Id { get; set; }

        public required string Name { get; set; }

        public string? LatinName { get; set; }

        public string? Description { get; set; }

        public DateOnly DateUpdate { get; set; }

        /// <summary>
        /// Вид растения
        /// </summary>
        public string? Species { get; set; }

        public List<string>? Images { get; set; }
    }
}
