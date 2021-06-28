using AlgoView.Algorithms;
using AlgoView.WebClient.Components;

namespace AlgoView.WebClient.Application
{
    public class SelectionSortMinimumFoundAction : SortAction<SortContainerBarData>
    {
        private readonly SelectionSortMinimumFoundEventArgs _args;

        public SelectionSortMinimumFoundAction(SortContainerBarData[] data, SelectionSortMinimumFoundEventArgs args)
            : base(data)
        {
            _args = args;
        }

        public override void Execute()
        {
            Data[_args.Index].Color = SortContainerBarColor.Green;
        }

        public override void Undo()
        {
            Data[_args.Index].Color = SortContainerBarColor.Blue;
        }
    }
}