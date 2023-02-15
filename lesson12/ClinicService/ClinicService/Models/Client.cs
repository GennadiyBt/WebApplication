namespace ClinicService.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Document { get; set; }


        public string SurName { get; set; }


        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }


        public Client() { }

        public Client(int clientId, string document, string surName, string firstName, string patronymic, DateTime birthday)
        {
            ClientId = clientId;
            Document = document;
            SurName = surName;
            FirstName = firstName;
            Patronymic = patronymic;
            Birthday = birthday;
        }
    }
}
