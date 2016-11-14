namespace DivideAndWalkTheDog.WEB.ViewModels
{
    public class DogViewModel
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string AdditionalInfo { get; set; }
        public UserViewModel User { get; set; }
    }
}