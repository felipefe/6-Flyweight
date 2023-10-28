using System.ComponentModel;

namespace Name
{
    class FlyweightFactory
    {

        private Dictionary<Tipo, IPersonagemFlyweight> Dictionary;
        public FlyweightFactory()
        {
            Dictionary = new Dictionary<Tipo, IPersonagemFlyweight>();
        }

        public IPersonagemFlyweight GetPersonagem(Tipo tipo)
        {
            IPersonagemFlyweight personagem = null;
            switch (tipo)
            {
                case Tipo.Soldado:
                    Dictionary.TryGetValue(tipo, out personagem);
                    if (personagem == null) personagem = new SoldadoFlyweight();
                    Dictionary.TryAdd(tipo, personagem);
                    break;
                case Tipo.Caçador:
                    Dictionary.TryGetValue(tipo, out personagem);
                    if (personagem == null) personagem = new HunterFlyweight();
                    Dictionary.TryAdd(tipo, personagem);
                    break;
            }
            return personagem;
        }
    }

    public enum Tipo : int
    {
        [Description("Soldado")]
        Soldado = 0,

        [Description("Caçador")]
        Caçador = 1,
    }
}