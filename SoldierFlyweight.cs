namespace Name
{
    public class SoldadoFlyweight : IPersonagemFlyweight
    {
        public string Nome { get; set; }  
        public string Defesa { get; private set; }  
        private int PoderAtaque { get; set; }  
        private int TotalAtaque { get; set;}
        private Random r;

        public SoldadoFlyweight()
        {
            Defesa = "Capacete, Armadura";
            TotalAtaque = 0;
            r = new Random();
        }

        public void Atacar()
        {
            PoderAtaque = r.Next(10, 50);
            TotalAtaque += PoderAtaque;
            Console.WriteLine($"Soldado {Nome}: Ataque -------> + {PoderAtaque}");
        }

        public void DanoTotalEquipe()
        {
            Console.WriteLine($"Dano Total Ataque Soldados: {TotalAtaque}");
        }
    }
}