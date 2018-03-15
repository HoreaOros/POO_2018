namespace Bars
{
    internal class Frame
    {
        HorzBar h1, h2;
        VertBar v;

        public Frame(int v1, int v2)
        {
            h1 = new HorzBar(v1);
            v = new VertBar(v2);
            h2 = new HorzBar(v1);
        }
    }
}