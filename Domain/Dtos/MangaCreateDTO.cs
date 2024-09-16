using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaveragesLibrary.Domain.Dtos
{
    public class MangaCreateDTO
    {
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}