using System;

namespace LartaDemo
{
    class DisplayView<T> where T : DifferenceItem
    {
        DifferenceController<T> dC;
        public DisplayView(string filename)
        {
            // Route to Controller
            dC = new DifferenceController<T>(filename);
            outputText();
        }

        public void outputText()
        {
            foreach(var d in dC.GetResult())
                Console.WriteLine(d.DisplayText());
        }

    }
}
