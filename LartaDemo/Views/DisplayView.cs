using System;

namespace LartaDemo
{
    class DisplayView<T> where T : DifferenceItem
    {
        //DifferenceItem dI;
        //List<DifferenceItem> dIB;
        DifferenceController<T> dC;
        public DisplayView(string filename)
        {
            // Route to Controller
             dC = new DifferenceController<T>(filename);
            //dI = DifferenceController.GetDifference2<T>(filename); //dC.GetDifference<T>();
            outputText();

            //dIB = dC.GetDifferenceDB();
            //outputTextDB();
        }

        //public void outputText()
        //{
        //    Console.WriteLine(dC.displayText());
        //}

        public void outputText()
        {
            foreach(var d in dC.GetResult())
                Console.WriteLine(d.displayText());
        }

    }
}
