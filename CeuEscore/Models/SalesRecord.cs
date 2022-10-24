using CeuEscore.Models.Enums;

namespace CeuEscore.Models
{
    public class SalesRecord
    {
        //1 - basics attributes
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        //2 - implementando o relacionamento com Seller
        public Seller Seller { get; set; }


        //3 - implementando o construtor vazio
        public SalesRecord()
        {

        }

        //3 - implementando o construtor com argumentos
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    

    }
}
