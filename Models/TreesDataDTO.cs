using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coeden.Models;

namespace portfolio.Coeden.Models
{
  public class TreesDataDTO(List<Tree> trees, double N, double S, double E, double W)
  {
    public List<Tree> Trees { get; set; } = trees;
    public MapBounds Bounds { get; set; } = new MapBounds(N, S, E, W);
  }
}