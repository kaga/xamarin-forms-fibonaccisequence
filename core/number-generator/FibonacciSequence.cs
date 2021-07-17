using System;
namespace fibonaccisequence.NumberGenerator
{

#nullable enable
    public class FibonacciSequence
    {
        private readonly FibonacciSequence? lastSequence;
        private readonly FibonacciSequence? secondLastSequence;

        public Decimal Current
        {
            get
            {
                if (lastSequence == null && secondLastSequence == null)
                {
                    return 0;
                }

                if (lastSequence.Current == 0)
                {
                    return 1;
                }

                return lastSequence.Current + secondLastSequence.Current;
            }
        }

        public FibonacciSequence()
        {

        }

        private FibonacciSequence(FibonacciSequence? lastSequence, FibonacciSequence? secondLastSequence)
        {
            this.lastSequence = lastSequence;
            this.secondLastSequence = secondLastSequence;
        }

        public FibonacciSequence NextSequence()
        {
            return new FibonacciSequence(this, lastSequence);
        }
    }
}
