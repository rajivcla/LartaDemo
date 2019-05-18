namespace LartaDemo
{
    public abstract class DifferenceItem
    {
        
        public string Name { get; set; }
        public int Difference { get; set; }

        public abstract string displayText();
    }
}
