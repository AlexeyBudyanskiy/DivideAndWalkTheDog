using System.Collections.Generic;
using DivideAndWalkTheDog.BLL.DTO;

namespace DivideAndWalkTheDog.BLL.Interfaces
{
    public interface IDogService
    {
        DogDTO GetDog(int dogId);
        IEnumerable<DogDTO> GetAllDogs();
        void CreateDog(DogDTO dog);
        void EditDog(DogDTO dog);
        IEnumerable<DogDTO> FindDogs(SearchDogDTO dog);
        DogDTO GetByUserId(int userId);
    }
}
