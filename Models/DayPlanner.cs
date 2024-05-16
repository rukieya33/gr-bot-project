namespace REST_BOT.Models
{
    public class DayPlanner
    {

        public int Id { get; set; }
        public string? activity { get; set; }

        public string? day { get; set; }

        public string? startTime { get; set; }

        public string? endTime { get; set; }

        public string? breakTime { get; set; }
       
    }
}
