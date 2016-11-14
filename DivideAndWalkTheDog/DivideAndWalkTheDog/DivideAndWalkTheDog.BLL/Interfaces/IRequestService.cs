using DivideAndWalkTheDog.BLL.DTO;
using System.Collections.Generic;

namespace DivideAndWalkTheDog.BLL.Interfaces
{
    public interface IRequestService
    {
        RequestDTO GetRequest(int requestId);
        IEnumerable<RequestDTO> GetAllRequests();
        IEnumerable<RequestDTO> GetNearbyRequests();
        void CreateRequest(RequestDTO requestDTO);
        void EditRequest(RequestDTO request);
        void RemoveRequest(int id);
        IEnumerable<RequestDTO> FindRequests(SearchRequestDTO request);
    }
}
