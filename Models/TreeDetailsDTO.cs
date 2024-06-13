using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coeden.Models;

namespace portfolio.Coeden.Models
{
  public class TreesDetailsDTO(Genus genus, Species species)
  {
    public Genus? Genus { get; set; } = genus;
    public Species? species { get; set; } = species;
  }
}