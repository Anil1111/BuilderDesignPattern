using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class FoundationValidation : IValidation
    {
        public IValidationType ValidationType { get; set; }
        public bool InProgress { get; set; }
        public DateTime ValidationDate { get; set; }
        public bool ValidatedBySupervisor { get; set; }
        public bool ValidateByMaster { get; set; }
    }
}
