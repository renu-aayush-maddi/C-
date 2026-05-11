namespace EventDemo
{
    public class EventHandlers
    {
        public void ShowMessage(int value)
        {
            Console.WriteLine($"Threshold Reached at {value}");
        }

        public void SendNotification(int value)
        {
            Console.WriteLine($"Notification Sent for value {value}");
        }

        public void LogEvent(int value)
        {
            Console.WriteLine($"Event Logged :Counter reached {value}");
        }
    }
}