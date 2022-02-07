using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Designer_Pattern.Bridge.Interfaces;

namespace Bridge_Example.Formatter
{
    public class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("-= {0} ----- =- {1}", key, value);
        }
    }
}
