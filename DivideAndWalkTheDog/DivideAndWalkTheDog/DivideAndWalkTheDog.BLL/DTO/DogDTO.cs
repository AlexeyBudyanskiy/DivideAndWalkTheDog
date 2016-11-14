namespace DivideAndWalkTheDog.BLL.DTO
{
    public class DogDTO
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string AdditionalInfo { get; set; }
        public UserDTO User { get; set; }
    }
}
