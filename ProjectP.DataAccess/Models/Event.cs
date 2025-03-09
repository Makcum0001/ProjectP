namespace ProjectP.DataAccess.Models
{
    public enum EventScope
    {
        Local,      
        City,       
        Federal
    }

    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public EventScope Scope { get; set; } 
    }
}
