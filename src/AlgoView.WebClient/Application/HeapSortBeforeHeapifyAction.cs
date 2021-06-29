using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class HeapSortBeforeHeapifyAction : SortAction<SortContainerBarData>
    {
        private readonly HeapSortBeforeHeapifyEventArgs _args;

        public HeapSortBeforeHeapifyAction(SortContainerBarData[] data, HeapSortBeforeHeapifyEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            for (var i = _args.Index; i < _args.End; i++)
            {
                Data[i].Color = SortContainerBarColor.Green;
            }
        }

        public override void UndoHighlight()
        {
            for (var i = _args.Index; i < _args.End; i++)
            {
                Data[i].Color = SortContainerBarColor.Blue;
            }
        }
    }
}