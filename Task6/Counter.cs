namespace EventDemo
{
    public delegate void ThresholdReachedHandler(int count);

    public class Counter
    {
        public event ThresholdReachedHandler? ThresholdReached;
        private int count = 0;
        private int threshold;

        public Counter(int threshold)
        {
            this.threshold = threshold;
        }
        public void Increment()
        {
            count++;
            Console.WriteLine($"Counter Value:{count}");

            if (count == threshold)
            {
                OnThresholdReached();
            }
        }

        private void OnThresholdReached()
        {
            ThresholdReached?.Invoke(count);
        }
    }
}