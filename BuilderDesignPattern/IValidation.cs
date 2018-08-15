using System;

namespace BuilderDesignPattern
{
    public interface IValidation
    {
        IValidationType ValidationType { get; set; }

        bool InProgress { get; set; }

        DateTime ValidationDate { get; set; }

        bool ValidatedBySupervisor { get; set; }

        bool ValidateByMaster { get; set; }
    }
}