namespace API.Entities
{
    public class Freelance : AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ago { get; set; }
    }
}