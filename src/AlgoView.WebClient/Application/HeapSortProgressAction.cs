using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class HeapSortProgressAction : SortAction<SortContainerBarData>
    {
        private readonly HeapSortProgressEventArgs _args;

        public HeapSortProgressAction(SortContainerBarData[] data, HeapSortProgressEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            Data[_args.Index].Color = SortContainerBarColor.Pink;
        }

        public override void UndoHighlight()
        {
            Data[_args.Index].Color = SortContainerBarColor.Blue;
        }
    }
}