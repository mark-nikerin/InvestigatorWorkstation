namespace Storage.Interfaces
{
    using System;

    public interface IPeriodExtension : IEntity
    {
        DateTime DecisionDate { get; set; }
        DateTime ExpirationDate { get; set; }
    }
}
