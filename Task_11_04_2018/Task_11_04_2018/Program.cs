using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(2);
            c.ThresholdReached += c_ThresholdReached;
            c.NameReached += c_NameReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
        }
        static void c_NameReached(object sender, NameReachedEventArgs e)
        {
            Console.WriteLine("I am {0}  {1}.", e.Name, e.Surname);
        }
    }
    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total > threshold)
            {
                NameReachedEventArgs args1 = new NameReachedEventArgs();
                args1.Name = "Diana";
                args1.Surname = "Zheltok";
                OnNameReached(args1);
            }
            if (total == threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        protected virtual void OnNameReached(NameReachedEventArgs e)
        {
            EventHandler<NameReachedEventArgs> handler = NameReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        public event EventHandler<NameReachedEventArgs> NameReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
    public class NameReachedEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}