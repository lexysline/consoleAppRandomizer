
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        public class Def
        {
            public String definition;
            public String description;
        }

        public class DataForApp
        {
            public DataForApp()
            {
                defs = new List<Def>();
            }
            private List<Def> defs;

            public void CreateExampleDefs()
            {
                defs.Add(new Def{ definition = " ласс", description = "Ц это способ описани€ сущности, определ€ющий состо€ние и поведение, завис€щее от этого состо€ни€, а также правила дл€ взаимодействи€ с данной сущностью (контракт)." });
                defs.Add(new Def{ definition = "ќбъект (экземпл€р)", description = "Ц это отдельный представитель класса, имеющий конкретное состо€ние и поведение, полностью определ€емое классом." });
                defs.Add(new Def{ definition = "»нтерфейс", description = "Ц это набор методов класса, доступных дл€ использовани€ другими классами." });
                defs.Add(new Def{ definition = "»нкапсул€ци€ ", description = " Ц это свойство системы, позвол€ющее объединить данные и методы, работающие с ними, в классе и скрыть детали реализации от пользовател€." });
                defs.Add(new Def{ definition = "јбстрагирование ", description = "Ц это способ выделить набор значимых характеристик объекта, исключа€ из рассмотрени€ незначимые. —оответственно, абстракци€ Ц это набор всех таких характеристик." });
                defs.Add(new Def{ definition = "ѕолиморфизм ", description = " Ц это свойство системы использовать объекты с одинаковым интерфейсом без информации о типе и внутренней структуре объекта." });
                defs.Add(new Def{ definition = "Ќаследование", description = " Ц это свойство системы, позвол€ющее описать новый класс на основе уже существующего с частично или полностью заимствующейс€ функциональностью.  ласс, от которого производитс€ наследование, называетс€ базовым или родительским. Ќовый класс Ц потомком, наследником или производным классом." });
            }
            //load from console
            public bool Load()
            {
                Console.WriteLine("Please enter definition");
                return false;
            }
            //load from file
            public bool Load(String Pathtofile)
            {
                return false;
            }
            
            public Def GetRandomDef()
            {
                Random rnd = new Random();
                int randomDef = rnd.Next(defs.Count());
                return defs[randomDef];
            }
        }
        static void Main(string[] args)
        {
            DataForApp definitions = new DataForApp();
            Def def;
            definitions.CreateExampleDefs();

            ConsoleKeyInfo pressedKey;
            Console.WriteLine("Ќажми любую кнопку.");
            Console.ReadKey(false);
            do
            {
                def = definitions.GetRandomDef();
                Console.WriteLine(def.definition);
                Console.WriteLine("Ќажмите любую кнопку, чтобы посмотреть описание.");
                Console.ReadKey(false);
                Console.WriteLine(def.description);
                Console.WriteLine("Ќажмите любую кнопку, чтобы продолжить или Esc дл€ выхода");
                pressedKey = Console.ReadKey(false);
                Console.Clear();
} while (pressedKey.Key != ConsoleKey.Escape);
        }
    }
}