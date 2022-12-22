using BethanysPieShopNewVersion.Models;
using BethanysPieShopNewVersion.Models;
using System.Collections;
using System.Collections.Generic;

namespace BethanysPieShopNewVersion.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
