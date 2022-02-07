using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PluralSigth_ChainOfResponsibility
{
    public class ApprovalCommon
    {
    }

    public interface IExpenseReport
        {
            Decimal Total { get;}
        }
        public interface IExpenseApprover
        {
            ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
        }
        public enum ApprovalResponse
        {
            Denied,Approved,BeyonApprovalLimit
        }
}
