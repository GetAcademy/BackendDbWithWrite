namespace WebApplication2.ViewModels
{
    public record Note
    {
        public int Id { get; }
        public string Title { get; }
        public string Body { get; }
        public string CreatedUtc { get; }

        public Note()
        {

        }

        public Note(int id, string title, string body, string createdUtc)
        {
            CreatedUtc = createdUtc;
            Body = body;
            Title = title;
            Id = id;
        }
    }
}
