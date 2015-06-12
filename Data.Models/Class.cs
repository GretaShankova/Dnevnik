namespace Data.Models
{
    public class Class
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public int UserId { get; set; }

        public virtual User Teacher { get; set; }
    }
}