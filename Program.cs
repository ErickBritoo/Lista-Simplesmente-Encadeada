namespace Lista
{
    class Program
    {
        static void Main()
        {
            SLinkedList lista = new SLinkedList();

            Node node1 = new("A", null);
            Node node2 = new("B", null);
            Node node3 = new("C", null);

            lista.AddFirst(node1);
            lista.AddFirst(node2);
            lista.AddFirst(node3);

            Node? atual = lista.GetHead();
            while(atual != null)
            {
                Console.WriteLine(atual);
                atual = atual.Next;
            }
        }
    }
}