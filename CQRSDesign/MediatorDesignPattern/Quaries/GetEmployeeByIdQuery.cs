using CQRSDesign.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSDesign.MediatorDesignPattern.Quaries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
