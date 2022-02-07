using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Designer_Pattern.PluralSigth_ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        public Employee(string name,Decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
                ? ApprovalResponse.BeyonApprovalLimit
                : ApprovalResponse.Approved;
        }

        private readonly decimal _approvalLimit;
    }
}
