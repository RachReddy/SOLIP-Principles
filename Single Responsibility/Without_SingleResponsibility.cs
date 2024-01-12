using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    // Sample classes for representation
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public double Amount { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }

    public class BillingApplication
    {
        public void ManageInvoice(Invoice invoice, Customer customer)
        {
            try
            {
                // Add logic to add invoice
                Console.WriteLine("Invoice added successfully.");

                // Add logic to delete invoice
                Console.WriteLine("Invoice deleted successfully.");

                // Add logic to send email
                Console.WriteLine($"Email sent to {customer.Email} for Invoice {invoice.InvoiceNumber}.");
            }
            catch (Exception ex)
            {
                // Add logic to log error
                Console.WriteLine($"Error logged: {ex.Message}");
            }
        }
    }

    class Without_SingleResponsibility
    {
       public static void Main()
        {
            var billingApp = new BillingApplication();

            // Add invoice, delete invoice, send email, and handle errors all in one class
            var invoice = new Invoice { InvoiceNumber = "123", Amount = 100.0 };
            var customer = new Customer { Email = "customer@example.com" };
            billingApp.ManageInvoice(invoice, customer);
        }
    }
}
