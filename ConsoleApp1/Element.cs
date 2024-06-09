namespace ConsoleApp1
{
    public class Element
    {
        public Element(int id, List<int> connectedElements)
        {
            Id = id;
            ConnectedElements = connectedElements;
        }

        public int Id { get; set; }

        public List<int> ConnectedElements { get; set; } = new List<int>();
    }
}
