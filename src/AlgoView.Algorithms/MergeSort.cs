using System;

namespace AlgoView.Algorithms
{
    public class MergeSort
    {
        private readonly int[] _values;

        public event EventHandler<MergeSortAssignedEventArgs> Swapped;
        public event EventHandler<MergeSortDividedEventArgs> Divided;
        
        public MergeSort(int[] values)
        {
            _values = values;
        }

        public void Sort()
        {
            Sort(0, _values.Length - 1);
        }

        private void Sort(int left, int right)
        {
            if (left < right)
            {
                var mid = (left + right) / 2;
                Divided?.Invoke(this, new MergeSortDividedEventArgs
                {
                    Left = left,
                    Middle = mid,
                    Right = right,
                });

                Sort(left, mid);
                Sort(mid + 1, right);

                Merge(left, mid, right);
            }
        }

        private void Merge(int left, int mid, int right)
        {
            var length1 = mid - left + 1;
            var length2 = right - mid;

            var arr1 = new int[length1];
            var arr2 = new int[length2];

            Array.Copy(_values, left, arr1, 0, length1);
            Array.Copy(_values, mid + 1, arr2, 0, length2);

            var i = 0;
            var j = 0;
            var k = left;

            while (i < length1 && j < length2)
            {
                if (arr1[i] < arr2[j])
                {
                    _values[k] = arr1[i];

                    Swapped?.Invoke(this, new MergeSortAssignedEventArgs
                    {
                        Index = k,
                        Value = arr1[i],
                    });

                    k++;
                    i++;
                }
                else
                {
                    _values[k] = arr2[j];

                    Swapped?.Invoke(this, new MergeSortAssignedEventArgs
                    {
                        Index = k,
                        Value = arr2[j],
                    });

                    k++;
                    j++;
                }
            }

            while (i < length1)
            {
                _values[k] = arr1[i];
                
                Swapped?.Invoke(this, new MergeSortAssignedEventArgs
                {
                    Index = k,
                    Value = arr1[i],
                });

                k++;
                i++;
            }

            while (j < length2)
            {
                _values[k] = arr2[j];
                
                Swapped?.Invoke(this, new MergeSortAssignedEventArgs
                {
                    Index = k,
                    Value = arr2[j],
                });

                k++;
                j++;
            }
        }
    }
}