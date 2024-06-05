using CQRSDesign.CQRSDesignPattern.Results.CategoryResults;
using CQRSDesign.DAL.Context;

namespace CQRSDesign.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetCategoryQueryResult> Handle() 
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
            });
            return values.ToList();
        }
    }
}
