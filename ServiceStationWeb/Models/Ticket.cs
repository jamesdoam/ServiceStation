using System.ComponentModel.DataAnnotations;

namespace ServiceStationWeb.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TicketNumber { get; set; }
        public string DeviceID { get; set; }
        public string ContactName { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
