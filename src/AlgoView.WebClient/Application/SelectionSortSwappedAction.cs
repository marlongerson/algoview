using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class SelectionSortSwappedAction : SortAction<SortContainerBarData>
    {
        private readonly SelectionSortSwapEventArgs _args;

        public SelectionSortSwappedAction(SortContainerBarData[] data, SelectionSortSwapEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            var temp = Data[_args.Index1].Value;
            Data[_args.Index1].Value = Data[_args.Index2].Value;
            Data[_args.Index2].Value = temp;

            Data[_args.Index1].Color = SortContainerBarColor.Green;
            Data[_args.Index2].Color = SortContainerBarColor.Green;
        }

        public override void UndoHighlight()
        {

            Data[_args.Index1].Color = SortContainerBarColor.Blue;
            Data[_args.Index2].Color = SortContainerBarColor.Blue;
        }
    }
}