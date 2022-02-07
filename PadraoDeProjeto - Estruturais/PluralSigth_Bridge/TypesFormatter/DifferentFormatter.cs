using Designer_Pattern.Bridge.Interfaces;

namespace Bridge_Example.Formatter
{
    public class DifferentFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0} == // ==   :  {1}", key, value);
        }
    }
}