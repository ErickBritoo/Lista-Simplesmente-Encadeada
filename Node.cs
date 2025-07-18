namespace Lista
{
    internal class Node
    {
        public string Element { get; private set; }
        public Node? Next { get; private set; }

        public Node(string element, Node next)
        {
            Element = element;
            Next = next;
        }

        public void SetElement(string element)
        {
            if (!string.IsNullOrEmpty(element))
                Element = element;
        }
        public void SetNext(Node next)
        {
            Next = next;
        }

        public override string ToString()
        {
            if (Next != null)
                return $"Elemento: {Element} Próximo: {Next.Element}";
            else
                return $"Elemento: {Element}\nFim da Lista";
        }
    }
}
