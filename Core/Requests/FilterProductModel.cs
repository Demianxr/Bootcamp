using Core.Constants;

namespace Core.Requests
{
    public class FilterProductModel
    {
        public int? Id { get; set; } // Optional for filtering by ID
        public string Name { get; set; } // Optional for filtering by name (partial match)
        public int? Month { get; set; } // Optional for filtering by month
        public int? Year { get; set; } // Optional for filtering by year
        public DateTime? FromDate { get; set; } // Optional for filtering by date range (start)
        public DateTime? ToDate { get; set; } // Optional for filtering by date range (end)
    }
}