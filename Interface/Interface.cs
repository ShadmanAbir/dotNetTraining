using dotnetTrainng.Models;

namespace dotnetTrainng.Interface
{
    public interface Interface
    {
        public int AddTwoNumber(Number number);
        public int SubstractFirstNumberFromSecond(Number number);
        public int MultiplyTwoNumbers { get; set; }
        public int DivideFirstNumberFromSecond { get; set; }
    }
}
