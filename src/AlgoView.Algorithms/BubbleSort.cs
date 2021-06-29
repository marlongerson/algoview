using System;

namespace AlgoView.Algorithms
{
    public class BubbleSort
    {
        private readonly int[] _values;

        public event EventHandler<BubbleSortProgressEventArgs> Progress;
        public event EventHandler<BubbleSortSwapEventArgs> Swapped;

        public BubbleSort(int[] values)
        {
            _values = values;
        }

        public void Sort()
        {
            while (true)
            {
                var swapped = false;

                for (var i = 0; i < _values.Length - 1; i++)
                {
                    Progress?.Invoke(this, new BubbleSortProgressEventArgs { Index = i });

                    if (_values[i] > _values[i + 1])
                    {
                        var temp = _values[i];
                        _values[i] = _values[i + 1];
                        _values[i + 1] = temp;

                        Swapped?.Invoke(this, new BubbleSortSwapEventArgs
                        {
                            Index1 = i,
                            Index2 = i + 1,
                        });

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}