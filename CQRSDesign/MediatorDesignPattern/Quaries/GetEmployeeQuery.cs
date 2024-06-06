using CQRSDesign.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSDesign.MediatorDesignPattern.Quaries
{
    public class GetEmployeeQuery : IRequest<List<GetEmployeeQueryResult>>
    {
    }
}
