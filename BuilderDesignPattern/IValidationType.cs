namespace BuilderDesignPattern
{
    public interface IValidationType
    {
        string Title { get; set; }

        IValidation requirement { get; set; }

        bool NeedsRequirementAproval { get; set; }

        byte ValidationSeverity { get; set; }
    }
}