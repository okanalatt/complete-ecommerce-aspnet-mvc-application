namespace eTickets.Models
{
    public class ErrorViewModel // ErrorViewModel class
    {
        public string? RequestId { get; set; } // RequestId property

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); // ShowRequestId property
    }
}
