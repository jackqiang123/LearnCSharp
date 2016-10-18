using Acme.Common;
using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Constructor invoke");
        }

        public Product(int productId,
                       string productName,
                       string description) :this()
        {
            Console.WriteLine("New Constructor invoke");
            this.productId = productId;
            this.description = description;
            this.productName = productName;
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Vendor productVender;

        public Vendor ProductVender
        {
            get {
                if (this.productVender == null) {
                    this.productVender = new Vendor();
                }
                return productVender;
            }
            set { productVender = value; }
        }


        public string SayHello() {
            //var vendor = new Vendor();
            //vendor.SendWelcomeEmail("Message from Product");


            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Product", this.productName, "sales@abc.com");
            var result = LogAction("Saying Hello");
            return "Hello " + ProductName + " ("+ProductId+"): "+Description;
        }

    }
}
