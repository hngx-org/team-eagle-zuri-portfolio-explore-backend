namespace Zuri_Portfolio_Explore.Domains.DTOs.Response
{
    public class PortfolioResponse
    {
        public string? Id { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? ProfileUrl { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? Provider { get; set; }
        public List<string>? Tracks { get; set; }
        public string? Location { get; set; }
        public string? Slug { get; set; }
        public string? Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Skills { get; set; }
        public int Projects { get; set; }
        //TODO:: Some more items to be added pending avaliablity in DB {Address, Role, Badge}
    }

    public class ProjectDTO
    {
        public int Total { get; set; }
    }
}