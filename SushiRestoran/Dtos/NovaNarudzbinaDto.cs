using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SushiRestoran.Models;

namespace SushiRestoran.Dtos
{
    public class NovaNarudzbinaDto
    {
        public List<StavkaNarudzbineDto> Jela { get; set; }
    }
}