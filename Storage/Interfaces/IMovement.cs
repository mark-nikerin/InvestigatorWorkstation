namespace Storage.Interfaces
{
    using System;

    public interface IMovement : IEntity
    {
        DateTime DecisionDate { get; set; }
        string Note { get; set; }
    }
}
