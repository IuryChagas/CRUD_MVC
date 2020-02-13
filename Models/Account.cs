namespace CRUD_MVC.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } 
    }
}