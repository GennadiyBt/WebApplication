namespace AnimalClinic.Models.Requests
{
    public class CreatePetRequesr
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
