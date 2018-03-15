namespace Bars
{
    internal class VertBar
    {
        private int v;

        public VertBar(int v)
        {
            this.v = v;
            for (int i = 0; i < v; i++)
            {
                System.Console.WriteLine("|");
            }
        }
    }
}