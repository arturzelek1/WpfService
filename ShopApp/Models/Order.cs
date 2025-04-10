using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApp.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? OrderEndDate { get; set; }

        public ICollection<OrderDetail> Items { get; set; } = new List<OrderDetail>();

        public double Total
        {
            get
            {
                double sum = 0;
                foreach(var item in Items)
                {
                    sum += item.Count * item.Product.Price;
                }

                if (Client.Discount > 0)
                    return sum * (100 - Client.Discount) / 100;
                else 
                    return sum;
            }
        }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
