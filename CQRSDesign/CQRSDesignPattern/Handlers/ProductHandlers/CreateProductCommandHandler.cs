﻿using CQRSDesign.DAL.Context;
using CQRSDesign.CQRSDesignPattern.Commands.ProductCommands;
using CQRSDesign.DAL.Entities;

namespace CQRSDesign.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handler(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryId = command.CategoryId,
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                ProductName = command.ProductName,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
