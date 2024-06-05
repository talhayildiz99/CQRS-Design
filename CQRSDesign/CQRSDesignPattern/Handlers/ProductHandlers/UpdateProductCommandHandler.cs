﻿using CQRSDesign.CQRSDesignPattern.Commands.ProductCommands;
using CQRSDesign.DAL.Context;

namespace CQRSDesign.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);
            value.ProductName = command.ProductName;
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.Description = command.Description;
            value.ImageUrl = command.ImageUrl;
            value.CategoryId = command.CategoryId;
            _context.SaveChanges();
        }
    }
}