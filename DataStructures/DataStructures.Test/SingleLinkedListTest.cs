using Xunit;
using DataStructures.Lists;

namespace DataStructures.Test
{
    public class SingleLinkedListTest
    {
        [Fact]
        public void Append()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int length = 10;

            // Act
            for (int i = 0; i < length; i++)
            {
                list.Append(i);
            }

            // Assert
            SingleLinkedListNode<int> current = list.Head;
            for (int i = 0; i < length; i++)
            {
                Assert.NotNull(current);
                Assert.Equal(i, current.Value);

                if (i + 1 < length)
                {
                    // Last node
                    Assert.NotNull(current.Next);
                }
                else
                {
                    // Last node
                    Assert.Null(current.Next);

                }

                // Move to next node
                current = current.Next;
            }
        }

        [Fact]
        public void Prepend()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int length = 10;

            // Act
            for (int i = 0; i < length; i++)
            {
                list.Prepend(i);
            }

            // Assert
            SingleLinkedListNode<int> current = list.Head;
            for (int i = 0; i < length; i++)
            {
                Assert.NotNull(current);
                Assert.Equal(length - i - 1, current.Value);

                if (i + 1 < length)
                {
                    // Last node
                    Assert.NotNull(current.Next);
                }
                else
                {
                    // Last node
                    Assert.Null(current.Next);

                }

                // Move to next node
                current = current.Next;
            }
        }

        [Fact]
        public void Prepend_OneItem()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Prepend(33);

            // Assert
            Assert.NotNull(list.Head);
            Assert.Equal(33, list.Head.Value);
            Assert.Null(list.Head.Next);
        }

        [Fact]
        public void RemoveFirst()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int length = 10;

            for (int i = 0; i < length; i++)
            {
                list.Append(i);
            }

            // Act
            SingleLinkedListNode<int> removed = list.RemoveFirst();

            // Assert
            Assert.Equal(0, removed.Value);

            SingleLinkedListNode<int> current = list.Head;
            for (int i = 0; i < length - 1; i++)
            {
                Assert.NotNull(current);
                Assert.Equal(i + 1, current.Value);

                if (i + 1 < length - 1)
                {
                    // Last node
                    Assert.NotNull(current.Next);
                }
                else
                {
                    // Last node
                    Assert.Null(current.Next);

                }

                // Move to next node
                current = current.Next;
            }
        }
        
        [Fact]
        public void RemoveFirst_OneItem()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Append(33);

            // Act
            SingleLinkedListNode<int> removed = list.RemoveFirst();

            // Assert
            Assert.Equal(33, removed.Value);
            Assert.Null(list.Head);
        }

        [Fact]
        public void RemoveFirst_EmptyList()
        {
            // Arrange (empty list)
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            // Act
            SingleLinkedListNode<int> removed = list.RemoveFirst();

            // Assert
            Assert.Null(removed);
        }

        [Fact]
        public void RemoveLast()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int length = 10;

            for (int i = 0; i < length; i++)
            {
                list.Append(i);
            }

            // Act
            SingleLinkedListNode<int> removed = list.RemoveLast();

            // Assert
            Assert.Equal(9, removed.Value);

            SingleLinkedListNode<int> current = list.Head;
            for (int i = 0; i < length - 1; i++)
            {
                Assert.NotNull(current);
                Assert.Equal(i, current.Value);

                if (i + 1 < length - 1)
                {
                    // Last node
                    Assert.NotNull(current.Next);
                }
                else
                {
                    // Last node
                    Assert.Null(current.Next);

                }

                // Move to next node
                current = current.Next;
            }
        }

        [Fact]
        public void RemoveLast_OneItem()
        {
            // Arrange
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Append(33);

            // Act
            SingleLinkedListNode<int> removed = list.RemoveLast();

            // Assert
            Assert.Equal(33, removed.Value);
            Assert.Null(list.Head);
        }

        [Fact]
        public void RemoveLast_EmptyList()
        {
            // Arrange (empty list)
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            // Act
            SingleLinkedListNode<int> removed = list.RemoveLast();

            // Assert
            Assert.Null(removed);
        }
    }
}
