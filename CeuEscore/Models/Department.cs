namespace CeuEscore.Models
{
    public class Department
    {
        //1 - basics attributes
        public int Id { get; set; }
        public string Name { get; set; }

        //2 - implementando o relacionamento com Seller
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //3 - implementando o construtor vazio
        public Department()
        {

        }

        //3 - implementando o construtor com argumentos

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }


        //4 - Custom methods 
        //adicionar vendedor
        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //total venda por periodo no depto com LINQ
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial,final));
        }

    }
}
