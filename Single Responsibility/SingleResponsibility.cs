//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLID_Principles
//{
//    // Sample classes for representation : use Invoice1 & Customer1 because this namespace already has defnition for Invoice and Customer.
//    public class Invoice1
//    {
//        public string InvoiceNumber { get; set; }
//        public double Amount { get; set; }
//    }

//    public class Customer1
//    {
//        public string Email { get; set; }
//    }

//    // Class responsible for adding and deleting invoices
//    public class InvoiceManager
//    {
//        public void AddInvoice(Invoice1 invoice)
//        {
//            // Add logic to add invoice
//            Console.WriteLine("Invoice added successfully.");
//        }

//        public void DeleteInvoice(Invoice1 invoice)
//        {
//            // Add logic to delete invoice
//            Console.WriteLine("Invoice deleted successfully.");
//        }
//    }

//    // Class responsible for sending email notifications
//    public class EmailNotifier
//    {
//        public void SendInvoiceEmail(Invoice1 invoice, Customer1 customer)
//        {
//            // Add logic to send email
//            Console.WriteLine($"Email sent to {customer.Email} for Invoice {invoice.InvoiceNumber}.");
//        }
//    }

//    // Class responsible for error logging
//    public class ErrorLogger
//    {
//        public void LogError(Exception ex)
//        {
//            // Add logic to log error
//            Console.WriteLine($"Error logged: {ex.Message}");
//        }
//    }



//    class SingleResponsibility
//    {
//        static void Main()
//        {
//            var invoiceManager = new InvoiceManager();
//            var emailNotifier = new EmailNotifier();
//            var errorLogger = new ErrorLogger();

//            try
//            {
//                // Add invoice
//                var invoice = new Invoice1 { InvoiceNumber = "123", Amount = 100.0 };
//                invoiceManager.AddInvoice(invoice);

//                // Delete invoice
//                invoiceManager.DeleteInvoice(invoice);

//                // Send email notification
//                var customer = new Customer1 { Email = "customer@example.com" };
//                emailNotifier.SendInvoiceEmail(invoice, customer);
//            }
//            catch (Exception ex)
//            {
//                // Log errors
//                errorLogger.LogError(ex);
//            }
//        }
//    }
//}