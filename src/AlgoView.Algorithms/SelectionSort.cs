using System;

namespace AlgoView.Algorithms
{
    public class SelectionSort<T> where T : IComparable
    {
        private T[] _values;

        public event EventHandler<SelectionSortProgressEventArgs> Progress;
        public event EventHandler<SelectionSortMinimumFoundEventArgs> MinimumFound;
        public event EventHandler<SelectionSortSwapEventArgs> BeforeSwap;
        public event EventHandler<SelectionSortSwapEventArgs> Swapped;

        public SelectionSort(T[] values)
        {
            _values = values;
        }

        public void Sort()
        {
            for (var i = 0; i < _values.Length; i++)
            {
                var k = i;
                for (var j = i + 1; j < _values.Length; j++)
                {
                    Progress?.Invoke(this, new SelectionSortProgressEventArgs
                    {
                        Index = j,
                    });

                    if (_values[j].CompareTo(_values[k]) == -1)
                    {
                        k = j;
                        MinimumFound?.Invoke(this, new SelectionSortMinimumFoundEventArgs
                        {
                            Index = k,
                        });
                    }
                }

                BeforeSwap?.Invoke(this, new SelectionSortSwapEventArgs
                {
                    Index1 = i,
                    Index2 = k,
                });

                var temp = _values[i];
                _values[i] = _values[k];
                _values[k] = temp;

                Swapped?.Invoke(this, new SelectionSortSwapEventArgs
                {
                    Index1 = i,
                    Index2 = k,
                });
            }
        }
    }
}