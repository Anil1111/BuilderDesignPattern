using System.Collections.Generic;

namespace BuilderDesignPattern
{
    public interface IEquipment
    {
        void AddValidation(IValidation validation);

        IEnumerable<IValidation> GetValidationStatus();

        IEnumerable<string> GetConstructionStatus();
    }
}