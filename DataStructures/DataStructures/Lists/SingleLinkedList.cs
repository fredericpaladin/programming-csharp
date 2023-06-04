namespace DataStructures.Lists
{
    public class SingleLinkedList<T> where T : struct
    {
        private SingleLinkedListNode<T> _head;

        public SingleLinkedList()
        {
        }

        public SingleLinkedListNode<T> Head { get { return _head; } }

        public void Append(T value)
        {
            // Create the new node
            SingleLinkedListNode<T> node = new SingleLinkedListNode<T>(value);

            if (_head == null)
            {
                // Fist node: set the head
                _head = node;
            }
            else
            {
                // Subsequent nodes: loop through the list until we find the last node (where "next" is null)
                SingleLinkedListNode<T> current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }
        }

        public void Prepend(T value)
        {
            // Create the new node
            SingleLinkedListNode<T> node = new SingleLinkedListNode<T>(value);

            if (_head == null)
            {
                // Fist node: set the head
                _head = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }
        }

        public SingleLinkedListNode<T> RemoveFirst()
        {
            if (_head == null)
            {
                return null;
            }

            SingleLinkedListNode<T> head = _head;

            // Set the new head
            _head = _head.Next;

            // Return the removed node
            return head;
        }

        public SingleLinkedListNode<T> RemoveLast()
        {
            if (_head == null)
            {
                return null;
            }

            if (_head.Next == null)
            {
                SingleLinkedListNode<T> head = _head;
                _head = null;
                return head;
            }

            // Loop through the list until we find the last node (where "next" is null)
            SingleLinkedListNode<T> current = _head;
            SingleLinkedListNode<T> previous = current;
            while (current.Next != null)
            {
                previous = current; // Keep track of the previous node
                current = current.Next;
            }

            // Unlink the previous node
            previous.Next = null;

            // Return the removed node
            return current;
        }

        public void RemoveAll()
        {
            _head = null;
        }
    }
}
