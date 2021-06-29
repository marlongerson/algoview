using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class MergeSortAssignedAction : SortAction<SortContainerBarData>
    {
        private readonly MergeSortAssignedEventArgs _args;

        public MergeSortAssignedAction(SortContainerBarData[] data, MergeSortAssignedEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            Data[_args.Index].Value = _args.Value;
            Data[_args.Index].Color = SortContainerBarColor.Orange;
        }

        public override void UndoHighlight()
        {
            Data[_args.Index].Color = SortContainerBarColor.Blue;
        }
    }
}