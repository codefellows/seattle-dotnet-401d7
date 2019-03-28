using LinkedList;
using System.Collections;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertNodeToHeadOfLinkedList()
        {
            //Arrange
            LList<int> linked = new LList<int>();

            //Act
            linked.Insert(10);
            linked.Insert(11);

            //Assert
            Assert.Equal(11, linked.Head.Value);
        }

        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            //Arrange
            LList<string> list = new LList<string>();

            // Act

            // Assert
            Assert.Null(list.Head);
        }

        [Fact]
        public void ValueCanBeFound()
        {
            // Arrange
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            // Act
            bool isFound = list.Includes(8);

            // Assert
            Assert.True(isFound);
            //Assert.Equal()


        }

        [Fact]
        public void ValueCannotBeFound()
        {
            // Arrange
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            // Act
            bool isFound = list.Includes(22);

            // Assert
            Assert.False(isFound);
        }

        [Fact]
        public void TestAppendMethod()
        {
            LList<int> list = new LList<int>();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Append(23);

            Assert.True(list.Includes(23));

        }

        [Fact]
        public void CanInsertBeforeHead()
        {
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.InsertBefore(4, 1);

            Assert.Equal(1, list.Head.Value);

        }


        [Fact]
        public void CanInsertBefore()
        {
            // Arrange
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.InsertBefore(8, 1);

            Assert.Equal(1, list.Head.Next.Value);

        }

        [Fact]
        public void CannotInsertIfDoesNotExist()
        {
            // Arrange
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            // Act
            list.InsertBefore(9, 1);

            // Assert
            Assert.False(list.Includes(1));

        }

        [Fact]
        public void CanInsertAfterTail()
        {
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.InsertAfter(15, 1);

            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }

            Assert.Equal(1, list.Current.Value);

        }

        [Fact]
        public void CanInsertAfterInMiddle()
        {
            // Arrange
            int value = 0;
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            // Act
            list.InsertAfter(8, 1);

            while (list.Current.Next != null)
            {
                if (list.Current.Value == 8)
                {
                    value = list.Current.Next.Value;
                }
                list.Current = list.Current.Next;
            }

            // Assert
            Assert.Equal(1, value);
        }

        [Fact]
        public void CannotInsertAfterIfDoesNotExist()
        {
            // Arrange
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);

            list.InsertAfter(9, 1);

            Assert.False(list.Includes(1));

        }

        [Fact]
        public void CanReturnPrintedNodes()
        {
            LList<int> list = new LList<int>();
            list.Insert(15);
            list.Insert(8);
            list.Insert(4);
            string answer = "";
            IEnumerable items = list.Print();
            foreach (var item in items)
            {
                answer += item;
            }

            string expected = "4815";
            Assert.Equal(expected, answer);

        }

    }
}
