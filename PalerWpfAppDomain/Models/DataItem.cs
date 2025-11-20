using System;

namespace PalerIPTSolution.PalerWpfAppDomain.Models
{
    public class DataItem
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedDate { get; }

        public DataItem(Guid id, string name, string description, DateTime createdDate)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
        }
    }
}
