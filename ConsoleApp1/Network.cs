namespace ConsoleApp1
{
    public class Network
    {
        public Network(int value)
        {
            Value = value;

            for (int i = 1; i <= Value; i++)
            {
                Set.Add(new Element(id: i, connectedElements: new List<int>()));
            }
        }

        public int Value { get; set; }
        public List<Element> Set { get; set; } = [];
        private bool ElementsAreConnected { get; set; } = false;

        public void Connect(int firsValue, int secondValue)
        {
            var foundFirstElement = Find(firsValue);
            var foundSecondElement = Find(secondValue);

            foundFirstElement.ConnectedElements.Add(foundSecondElement.Id);
            foundSecondElement.ConnectedElements.Add(foundFirstElement.Id);

            if (foundSecondElement.ConnectedElements.Count != 0)
                foundFirstElement.ConnectedElements.AddRange(foundSecondElement.ConnectedElements);

            if (foundFirstElement.ConnectedElements.Count != 0)
                foundSecondElement.ConnectedElements.AddRange(foundFirstElement.ConnectedElements);

            foundFirstElement.ConnectedElements = foundFirstElement.ConnectedElements.Distinct().ToList();
            foundSecondElement.ConnectedElements = foundSecondElement.ConnectedElements.Distinct().ToList();
        }

        public bool Query(int firsValue, int secondValue)
        {
            var foundFirstElement = Find(firsValue);
            var foundSecondElement = Find(secondValue);

            CheckIfElementsAreConnected(foundFirstElement!, foundSecondElement!);

            return ElementsAreConnected;
        }

        private Element Find(int value)
        {
            var element = Set.Find(x => x.Id == value);

            if (element == null)
            {
                throw new Exception($"Por favor, escolha números entre 1 e {Value}");
            }

            return element;
        }

        private void CheckIfElementsAreConnected(Element firstElement, Element secondElement)
        {
            foreach (var connectedElement in firstElement!.ConnectedElements)
            {

                if (connectedElement == secondElement.Id)
                {
                    ElementsAreConnected = true;
                    return;
                }
                else if (secondElement!.ConnectedElements.Contains(connectedElement))
                {
                    ElementsAreConnected = true;
                    return;
                }
                else
                {
                    ElementsAreConnected = false;
                }
            }
        }
    }
}
