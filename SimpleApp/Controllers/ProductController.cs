using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleApp.Models;
using SimpleApp.Repositories;

namespace SimpleApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult> Index()
        {
            List<Product> products = _repository.GetProducts();
            return View(products);
        }
    }
}