namespace DivideAndWalkTheDog.DAL.Entities
{
    public class Dog
    {
        public int Id { get; set; }        
        public string Breed { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string AdditionalInfo { get; set; }
        public virtual UserInfo User { get; set; }
    }
}
