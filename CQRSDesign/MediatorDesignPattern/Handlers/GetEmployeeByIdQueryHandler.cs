using CQRSDesign.DAL.Context;
using CQRSDesign.MediatorDesignPattern.Quaries;
using CQRSDesign.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSDesign.MediatorDesignPattern.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, GetEmployeeByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetEmployeeByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.Id);
            return new GetEmployeeByIdQueryResult
            {
                EmployeeId = values.EmployeeId,
                Name = values.Name,
                Salary = values.Salary,
                Surname = values.Surname
            };
        }
    }
}
