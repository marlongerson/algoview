using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class BubbleSortProgressAction : SortAction<SortContainerBarData>
    {
        private readonly BubbleSortProgressEventArgs _args;

        public BubbleSortProgressAction(SortContainerBarData[] data, BubbleSortProgressEventArgs args)
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