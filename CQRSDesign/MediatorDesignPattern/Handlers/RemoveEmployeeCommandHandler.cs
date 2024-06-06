using CQRSDesign.DAL.Context;
using CQRSDesign.MediatorDesignPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSDesign.MediatorDesignPattern.Handlers
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly CQRSContext _context;

        public RemoveEmployeeCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Employees.Find(request.Id);
            _context.Employees.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
