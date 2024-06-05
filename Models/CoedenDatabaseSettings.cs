using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coeden.Models
{
  public class TreeStoreDatabaseSettings
  {
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string TreesCollectionName { get; set; } = null!;
  }
}