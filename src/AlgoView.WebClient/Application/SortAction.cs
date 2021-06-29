namespace AlgoView.WebClient.Application
{
    public abstract class SortAction<T>
    {
        protected T[] Data { get; }

        protected SortAction(T[] data)
        {
            Data = data;
        }

        public abstract void Execute();

        public abstract void UndoHighlight();
    }
}