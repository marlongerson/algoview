using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class SelectionSortProgressAction : SortAction<SortContainerBarData>
    {
        private readonly SelectionSortProgressEventArgs _args;

        public SelectionSortProgressAction(SortContainerBarData[] data, SelectionSortProgressEventArgs args)
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