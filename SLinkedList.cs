namespace Lista
{
    internal class SLinkedList
    {
        protected Node? Head;
        protected int Size;
        
        public SLinkedList()
        {
            Head = null;
            Size = 0;
        }

        public void AddFirst(Node element)
        {
            element.SetNext(next: Head);
            Head = element;
            Size++;
        }

        public Node? GetHead() => Head;
       
    }
}
