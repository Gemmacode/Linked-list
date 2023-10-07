namespace Week1
{
    public class GemmaNode<T>
    {
        public T Data;
        public GemmaNode<T>? Next;

        public GemmaNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}