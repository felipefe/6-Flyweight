namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Factory = new FlyweightFactory();
            var tasks = new List<Task>();
            var qtdPersonagens = 30;
            SoldadoFlyweight soldier = null;
            HunterFlyweight hunter = null;

            var t1 = new Task(() =>
            {
                for (int i = 1; i <= qtdPersonagens; i++)
                {
                    soldier = (SoldadoFlyweight)Factory.GetPersonagem(Tipo.Soldado);
                    soldier.Nome = $"Soldier{i}";
                    soldier.Atacar();
                }
            });
            tasks.Add(t1);

            var t2 = new Task(() =>
            {
                for (int i = 1; i <= qtdPersonagens; i++)
                {
                    hunter = (HunterFlyweight)Factory.GetPersonagem(Tipo.Caçador);
                    hunter.Nome = $"Hunter{i}";
                    hunter.Atacar();
                }
            });
            tasks.Add(t2);

            //Inicia as tasks e aguarda a execução
            tasks.ForEach(t => t.Start());
            tasks.ForEach(t => t.Wait());

            //Resultado final
            hunter.DanoTotalEquipe();
            soldier.DanoTotalEquipe();
        }
    }
}