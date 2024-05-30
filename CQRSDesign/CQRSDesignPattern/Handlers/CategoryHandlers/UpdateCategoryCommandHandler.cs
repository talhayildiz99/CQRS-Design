﻿using CQRSDesign.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSDesign.DAL.Context;

namespace CQRSDesign.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            values.CategoryName = command.CategoryName;
            _context.SaveChanges();
        }
    }
}
