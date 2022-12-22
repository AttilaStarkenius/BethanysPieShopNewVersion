﻿using BethanysPieShopNewVersion.Models;
using BethanysPieShopNewVersion.ViewModels;
using BethanysPieShopNewVersion.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopNewVersion.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }
    }
}
