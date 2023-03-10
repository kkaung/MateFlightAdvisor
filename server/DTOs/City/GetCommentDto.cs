namespace FlightAdvisorService.DTOs;

public class GetCommetDto
{
    public int Id { get; set; }
    public string Body { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int CityId { get; set; }
    public int UserId { get; set; }
}
