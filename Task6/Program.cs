namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(5);

            EventHandlers handlers = new EventHandlers();

            counter.ThresholdReached += handlers.ShowMessage;
            counter.ThresholdReached += handlers.SendNotification;
            counter.ThresholdReached += handlers.LogEvent;

            for (int i=0;i<10;i++)
            {
                counter.Increment();
                Thread.Sleep(300);
            }
        }
    }
}