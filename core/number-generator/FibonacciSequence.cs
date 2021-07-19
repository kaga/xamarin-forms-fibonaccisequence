using System;
namespace fibonaccisequence.NumberGenerator
{

#nullable enable
    public class FibonacciSequence
    {
        private readonly FibonacciSequence? _lastSequence;
        private readonly FibonacciSequence? _secondLastSequence;

        private decimal? _current;
        public decimal Current
        {
            get
            {
                var current = _current ?? Calculate(_lastSequence?.Current, _secondLastSequence?.Current);
                _current ??= current;
                return current;
            }
        }

        public FibonacciSequence()
        {
            
        }
        private FibonacciSequence(
            FibonacciSequence? lastSequence = null, 
            FibonacciSequence? secondLastSequence = null)
        {
            _lastSequence = lastSequence;
            _secondLastSequence = secondLastSequence;
        }

        public FibonacciSequence NextSequence()
        {
            return new(this, _lastSequence);
        }
        private static decimal Calculate(decimal? lastSequence = null, decimal? secondLastSequence = null)
        {
            if (lastSequence != null && secondLastSequence != null)
            {
                return lastSequence.Value + secondLastSequence.Value;
            }

            if (lastSequence == 0)
            {
                return 1;
            }
            
            return 0;
        }
    }
}
