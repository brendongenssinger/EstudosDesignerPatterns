using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Designer_Pattern.PluralSigth_ChainOfResponsibility;
namespace Designer_Pattern.PluralSigth_ChainOfResponsibility
{
    public class ExpenseReport :IExpenseReport
    {
        public ExpenseReport(decimal total)
        {
            Total = total;
        }

        public decimal Total { get; }
    }
}
