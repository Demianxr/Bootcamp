namespace Core.Requests
{
    public class FilterUserRequestModel
    {
        public int? UserId { get; set; } 
        public string ProductType { get; set; }
        public string Currency { get; set; }
        
    }
}
