using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaveragesLibrary.Domain.Dtos
{
    public class MangaUpdateDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
    }
}