using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSTutorial
{
    public class InvoiceService
    {
        public List<InvoiceModel> GetInvoices()
        {
            return new List<InvoiceModel>()
            {
                new InvoiceModel() {InvoiceNumber = 1, Amount = 10, CostCategory = "Utilities"},
                new InvoiceModel() {InvoiceNumber = 2, Amount = 50, CostCategory = "Telephone"},
                new InvoiceModel() {InvoiceNumber = 3, Amount = 30, CostCategory = "Services"},
                new InvoiceModel() {InvoiceNumber = 4, Amount = 40, CostCategory = "Consultancy"},
                new InvoiceModel() {InvoiceNumber = 5, Amount = 60, CostCategory = "Raw materials"}
            };
        }
    }
}
