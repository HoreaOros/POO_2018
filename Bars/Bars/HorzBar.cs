namespace Bars
{
    internal class HorzBar
    {
        private int v;

        public HorzBar(int v)
        {
            this.v = v;
            
            System.Console.Write("+");
            for (int i = 0; i < v; i++)
            {
                System.Console.Write("-");
            }

            System.Console.WriteLine("+");
        }
    }
}