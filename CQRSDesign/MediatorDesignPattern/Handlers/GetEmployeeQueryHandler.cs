using CQRSDesign.CQRSDesignPattern.Queries.CategoyQueries;
using CQRSDesign.DAL.Context;
using CQRSDesign.MediatorDesignPattern.Quaries;
using CQRSDesign.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSDesign.MediatorDesignPattern.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<GetEmployeeQueryResult>>
    {
        private readonly CQRSContext _context;

        public GetEmployeeQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetEmployeeQueryResult>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.Select(x => new GetEmployeeQueryResult
            {
                EmployeeId = x.EmployeeId,
                Name = x.Name,
                Salary = x.Salary,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}
