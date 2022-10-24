namespace CeuEscore.Models
{
    public class Seller
    {
        //1 - basics attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }


        //2 - implementando o relacionamento com department
        public Department Department { get; set; }

        //2 - implementando o relacionamento com SalesRecord
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        //3 - implementando o construtor vazio
        public Seller()
        {

        }

        //3 - implementando o construtor com argumentos
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }


        //4 - Custom methods 
        //adicionar venda
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        //remover venda
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        //total venda por periodo com LINQ
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
