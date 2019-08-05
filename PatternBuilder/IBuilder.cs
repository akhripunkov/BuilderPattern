using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
