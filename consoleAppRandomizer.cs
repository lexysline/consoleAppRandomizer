
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
            /*
            public Def(String def, String descr)
            {
                definition = def;
                description = descr;
            }
            private String definition;
            private String description;

            public String Definition
            {
                get
                {
                    return definition;
                }
            }
            public String Description
            {
                get
                {
                    return description;
                }
            }*/
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
                defs.Add(new Def{ definition = "Класс", description = "– это способ описания сущности, определяющий состояние и поведение, зависящее от этого состояния, а также правила для взаимодействия с данной сущностью (контракт)." });
                defs.Add(new Def{ definition = "Объект (экземпляр)", description = "– это отдельный представитель класса, имеющий конкретное состояние и поведение, полностью определяемое классом." });
                defs.Add(new Def{ definition = "Интерфейс", description = "– это набор методов класса, доступных для использования другими классами." });
                defs.Add(new Def{ definition = "Инкапсуляция ", description = " – это свойство системы, позволяющее объединить данные и методы, работающие с ними, в классе и скрыть детали реализации от пользователя." });
                defs.Add(new Def{ definition = "Абстрагирование ", description = "– это способ выделить набор значимых характеристик объекта, исключая из рассмотрения незначимые. Соответственно, абстракция – это набор всех таких характеристик." });
                defs.Add(new Def{ definition = "Полиморфизм ", description = " – это свойство системы использовать объекты с одинаковым интерфейсом без информации о типе и внутренней структуре объекта." });
                defs.Add(new Def{ definition = "Наследование", description = " – это свойство системы, позволяющее описать новый класс на основе уже существующего с частично или полностью заимствующейся функциональностью. Класс, от которого производится наследование, называется базовым или родительским. Новый класс – потомком, наследником или производным классом." });
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
            Console.WriteLine("Нажми любую кнопку.");
            Console.ReadKey(false);
            do
            {
                def = definitions.GetRandomDef();
                Console.WriteLine(def.definition);
                Console.WriteLine("Нажмите любую кнопку, чтобы посмотреть описание.");
                Console.ReadKey(false);
                Console.WriteLine(def.description);
                Console.WriteLine("Нажмите любую кнопку, чтобы продолжить или Esc для выхода");
                pressedKey = Console.ReadKey(false);
                Console.Clear();
} while (pressedKey.Key != ConsoleKey.Escape);
        }
    }
}
