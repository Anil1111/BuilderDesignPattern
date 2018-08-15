using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class ExternalValidationType : IValidationType
    {
        public string Title { get; set; }
        public IValidation requirement { get; set; }
        public bool NeedsRequirementAproval { get; set; }
        public byte ValidationSeverity { get; set; }
    }
}
