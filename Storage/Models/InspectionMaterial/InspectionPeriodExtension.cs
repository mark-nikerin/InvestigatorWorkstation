﻿namespace Storage.Models
{
    using Storage.Interfaces;
    using System;

    public class InspectionPeriodExtension : IPeriodExtension
    { 
        public int Id { get; set; }
        public DateTime DecisionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
