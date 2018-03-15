using System;
namespace Hello_World
{
    internal class World
    {
        private string id;
        private Guid gid;
        

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v">id-ul lumii</param>
        public World(string v)
        {
            id = v;
            gid = Guid.NewGuid();
        }

        public Guid GID
        {
            get
            {
                return gid;
            }
        }

        internal void SayHello(bool v)
        {
            string s;
            s = "Hello";
            if (v)
            {
                s += " from " + id;
            }
            Console.WriteLine(s);
        }

        /// <summary>
        /// Hello method
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}