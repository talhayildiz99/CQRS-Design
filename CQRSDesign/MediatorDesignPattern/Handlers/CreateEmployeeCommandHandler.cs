using CQRSDesign.DAL.Context;
using CQRSDesign.DAL.Entities;
using CQRSDesign.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSDesign.MediatorDesignPattern.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
    {
        private readonly CQRSContext _context;

        public CreateEmployeeCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _context.Employees.AddAsync(new Employee
            {
                Name = request.Name,
                Salary = request.Salary,
                Surname = request.Surname
            });
            await _context.SaveChangesAsync();
        }
    }
}
