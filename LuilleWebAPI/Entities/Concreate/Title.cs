namespace LuilleWebAPI.Entities.Concreate
{
    public class Title
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
