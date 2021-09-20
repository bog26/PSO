using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    class Status
    {
        private string crtStatus;
        private List<string> transactionStatuses = new List<string>()
        { "Requested", "Accepted", "Completed"};
        private List<string> messageStatuses = new List<string>()
        { "sent", "received", "read"};
        public Status(Transaction tr)
        {
            this.crtStatus = this.transactionStatuses[0];
        }
        public string CrtStatus
        { 
            get{ return this.crtStatus; }
            set {this.crtStatus = value; } 
        }
    public void ChangeTransactionStatus(int i)
        {
            if (i == transactionStatuses.Count - 1)
            {
                this.crtStatus = transactionStatuses[transactionStatuses.Count - 1];
            }
            else 
            {
                this.crtStatus = transactionStatuses[i++];
            }
            
            

        }
    }
}
