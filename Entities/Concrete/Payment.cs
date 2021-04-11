using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int PaymentId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public int DateMonth { get; set; }
        public int DateYear { get; set; }
        public int CvvCode { get; set; }
    }
}
