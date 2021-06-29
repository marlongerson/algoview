using System;
using System.Linq;

namespace AlgoView.Algorithms
{
    public class HeapSort
    {
        private readonly int[] _values;

        public event EventHandler<HeapSortProgressEventArgs> Progress;
        public event EventHandler<HeapSortSwapEventArgs> Swapped;
        public event EventHandler<HeapSortBeforeHeapifyEventArgs> BeforeHeapify;

        public HeapSort(int[] values)
        {
            _values = values;
        }

        public void Sort()
        {
            for (var i = _values.Length / 2 - 1; i >= 0; i--)
            {
                Progress?.Invoke(this, new HeapSortProgressEventArgs
                {
                    Index = i,
                });

                Heapify(i, _values.Length);
            }

            for (var i = _values.Length - 1; i >= 0; i--)
            {
                Progress?.Invoke(this, new HeapSortProgressEventArgs
                {
                    Index = i,
                });

                var temp = _values[0];
                _values[0] = _values[i];
                _values[i] = temp;

                Swapped?.Invoke(this, new HeapSortSwapEventArgs
                {
                    Index1 = 0,
                    Index2 = i,
                });

                BeforeHeapify?.Invoke(this, new HeapSortBeforeHeapifyEventArgs
                {
                    Index = 0,
                    End = i,
                });

                Heapify(0, i);
            }
        }

        private void Heapify(int i, int end)
        {
            var left = i * 2 + 1;
            var right = i * 2 + 2;
            var k = i;

            if (left < end && _values[left] > _values[k])
            {
                k = left;
            }

            if (right < end && _values[right] > _values[k])
            {
                k = right;
            }

            if (k != i)
            {
                var temp = _values[k];
                _values[k] = _values[i];
                _values[i] = temp;

                Swapped?.Invoke(this, new HeapSortSwapEventArgs
                {
                    Index1 = k,
                    Index2 = i,
                });

                BeforeHeapify?.Invoke(this, new HeapSortBeforeHeapifyEventArgs
                {
                    Index = k,
                    End = end,
                });

                Heapify(k, end);
            }
        }
    }
}