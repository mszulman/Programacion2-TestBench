namespace ConsoleApp3
{
    public abstract class Mascota
    {
        public string Nombre { get; set; }

        public Mascota(string nombre)
        {
            this.Nombre = nombre;
        }

        public event Hablar Hablo;

        public abstract void DecirAlgo();

        protected void DijeAlgo(string queDije)
        {
            Hablo(this, queDije);
        }
    }
}