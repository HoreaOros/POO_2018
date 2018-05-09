namespace Upcasting
{
    internal abstract class InstrumentMuzical
    {
        private int dimensiune;

        public InstrumentMuzical(int dimensiune)
        {
            System.Console.WriteLine("Am creat un instrument muzical");
            this.dimensiune = dimensiune;
        }
        public abstract void AcordeazaInstrument();
    }
    internal abstract class InstrumentCuCorzi: InstrumentMuzical
    {
        private int nrCorzi;
        public InstrumentCuCorzi(int nr, int dim): base(dim)
        {
            System.Console.WriteLine("Am creat un instrument cu corzi");
            nrCorzi = nr;
        }
    }
    internal class Chitara: InstrumentCuCorzi
    {
        public Chitara(int nr, int dim): base(nr, dim)
        {
            System.Console.WriteLine("Am creat o chitara");
        }
        public override void AcordeazaInstrument()
        {
            // base.AcordeazaInstrument(); // nu se mai poate apela daca in clasa de baza metoda e abstracta
            System.Console.WriteLine("Acordez o chitara");
        }
    }
    internal class Vioara: InstrumentCuCorzi
    {
        public Vioara(int nr, int dim): base(nr, dim)
        {
            System.Console.WriteLine("Am creat o  vioara");
        }
        public override void AcordeazaInstrument()
        {
            //base.AcordeazaInstrument();
            System.Console.WriteLine("Acordez o vioara");
        }
    }
}