using System;


namespace Alarm
{
    public class Alarm
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public bool Recurring { get; set; }
        public bool Active { get; set; }
    }
}
