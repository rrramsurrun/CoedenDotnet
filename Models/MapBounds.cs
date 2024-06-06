using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Coeden.Models
{
  public class MapBounds(double N, double S, double E, double W)
  {
    public double North { get; set; } = N;
    public double South { get; set; } = S;
    public double East { get; set; } = E;
    public double West { get; set; } = W;
  }
}