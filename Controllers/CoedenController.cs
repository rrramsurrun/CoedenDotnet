// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net;
// using System.Net.WebSockets;
// using System.Runtime.CompilerServices;
// using System.Text;
// using System.Threading.Tasks;
using Coeden.Models;
using Coeden.Services;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Mvc;
using portfolio.Coeden.Models;


namespace Coeden.Controller
{

  public class CoedenController : ControllerBase
  {
    private readonly TreeService _treeService;

    public CoedenController(TreeService treeService)
    {
      _treeService = treeService;
    }

    [Route("/trees")]
    [HttpGet]
    public async Task<TreesDataDTO> GetTrees(double N, double S, double E, double W)
    {
      var localTrees = await _treeService.GetTreesByBounds(N, S, E, W);
      Console.WriteLine(localTrees.Count());
      return new TreesDataDTO(localTrees, N, S, E, W);
    }
    // [Route("/singleTree")]
    // [HttpGet]
    // public async Task<Tree[]> GetTree()
    // {
    //   return [];
    // }


  }
}