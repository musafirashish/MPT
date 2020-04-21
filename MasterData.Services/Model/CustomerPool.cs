using System;
using System.Collections.Generic;
using System.Text;

namespace MasterData.Services.Model
{
    public class CustomerPool
    {
        public int CustomerPoolId { get; set; }
        public string CustomerPoolCode { get; set; }
        public string CustomerPoolName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
