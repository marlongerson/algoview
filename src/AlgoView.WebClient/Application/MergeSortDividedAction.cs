using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class MergeSortDividedAction : SortAction<SortContainerBarData>
    {
        private readonly MergeSortDividedEventArgs _args;

        public MergeSortDividedAction(SortContainerBarData[] data, MergeSortDividedEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            for (var i = _args.Left; i <= _args.Middle; i++)
            {
                Data[i].Color = SortContainerBarColor.Green;
            }

            for (var i = _args.Middle + 1; i <= _args.Right; i++)
            {
                Data[i].Color = SortContainerBarColor.Pink;
            }
        }

        public override void UndoHighlight()
        {
            for (var i = _args.Left; i <= _args.Middle; i++)
            {
                Data[i].Color = SortContainerBarColor.Blue;
            }

            for (var i = _args.Middle + 1; i <= _args.Right; i++)
            {
                Data[i].Color = SortContainerBarColor.Blue;
            }
        }
    }
}