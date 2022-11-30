﻿using Allup.ComponentViewModel.Header;
using Allup.DAL;
using Allup.Models;
using Allup.ViewModels.Basket;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Dictionary<string,string> settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);

            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;
            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }
            foreach (BasketVM item in basketVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == item.Id);
                item.Title = product.Title;
                item.Image = product.MainImage;
                item.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
                item.ExTax = product.ExTax;
            }

            HeaderVM headerVM = new HeaderVM
            {
                Settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value),
                Categories = await _context.Categories.Include(c => c.Children).Where(c => c.IsDeleted == false & c.IsMain).ToListAsync(),
                BasketVMs = basketVMs
            };

            return View(Task.FromResult(headerVM));
        }
    }
}