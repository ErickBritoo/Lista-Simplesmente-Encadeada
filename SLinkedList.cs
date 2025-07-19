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

        public string RemoveFirst()
        {
            if (Head == null) return new InvalidOperationException("Operação Inválida! Lista vazia").ToString();

            Node removed = Head;
            Head = Head.Next;

            removed.SetNext(null);
            Size--;

            return removed.Element;
        }


        public Node? GetHead() => Head;
       
    }
}
