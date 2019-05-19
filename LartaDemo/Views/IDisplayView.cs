using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public interface IDisplayView<T>
    {
        void OutputText(List<T> result);
        string DisplayText(string name, int difference);
    }
}
