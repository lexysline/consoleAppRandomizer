
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
                defs.Add(new Def{ definition = "�����", description = "� ��� ������ �������� ��������, ������������ ��������� � ���������, ��������� �� ����� ���������, � ����� ������� ��� �������������� � ������ ��������� (��������)." });
                defs.Add(new Def{ definition = "������ (���������)", description = "� ��� ��������� ������������� ������, ������� ���������� ��������� � ���������, ��������� ������������ �������." });
                defs.Add(new Def{ definition = "���������", description = "� ��� ����� ������� ������, ��������� ��� ������������� ������� ��������." });
                defs.Add(new Def{ definition = "������������ ", description = " � ��� �������� �������, ����������� ���������� ������ � ������, ���������� � ����, � ������ � ������ ������ ���������� �� ������������." });
                defs.Add(new Def{ definition = "��������������� ", description = "� ��� ������ �������� ����� �������� ������������� �������, �������� �� ������������ ����������. ��������������, ���������� � ��� ����� ���� ����� �������������." });
                defs.Add(new Def{ definition = "����������� ", description = " � ��� �������� ������� ������������ ������� � ���������� ����������� ��� ���������� � ���� � ���������� ��������� �������." });
                defs.Add(new Def{ definition = "������������", description = " � ��� �������� �������, ����������� ������� ����� ����� �� ������ ��� ������������� � �������� ��� ��������� �������������� �����������������. �����, �� �������� ������������ ������������, ���������� ������� ��� ������������. ����� ����� � ��������, ����������� ��� ����������� �������." });
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
            Console.WriteLine("����� ����� ������.");
            Console.ReadKey(false);
            do
            {
                def = definitions.GetRandomDef();
                Console.WriteLine(def.definition);
                Console.WriteLine("������� ����� ������, ����� ���������� ��������.");
                Console.ReadKey(false);
                Console.WriteLine(def.description);
                Console.WriteLine("������� ����� ������, ����� ���������� ��� Esc ��� ������");
                pressedKey = Console.ReadKey(false);
                Console.Clear();
} while (pressedKey.Key != ConsoleKey.Escape);
        }
    }
}