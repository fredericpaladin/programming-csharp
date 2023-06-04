namespace DataStructures.Lists
{
    public class SingleLinkedListNode<T> where T : struct
    {
        private T _value;
        private SingleLinkedListNode<T> _next;

        public SingleLinkedListNode(T value)
        {
            _value = value;
        }

        public T Value { get { return _value; } }

        public SingleLinkedListNode<T> Next { get { return _next; } set { _next = value; } }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
