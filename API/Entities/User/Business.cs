namespace API.Entities
{
    public class Business : AppUser
    {
        public string NameBusiness { get; set; }
        public string Activity { get; set; }
        public string LegalStatus { get; set; }
        public string Siret { get; set; }
    }
}