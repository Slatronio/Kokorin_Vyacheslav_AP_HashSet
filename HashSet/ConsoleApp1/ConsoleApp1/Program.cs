using System;
using System.Collections;
using System.Text;

namespace HtStackSet
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                HashSet<string> set1 = new HashSet<string>();
                HashSet<string> set2 = new HashSet<string>();
                HashSet<string> SET = new HashSet<string>();
                Console.WriteLine("Введите элементы первого множества через пробел:");
                string[] a = Console.ReadLine().Split();
                for (int i = 0; i < a.Length; i++) set1.Add(a[i]);
                Console.WriteLine("Введите элементы второго множества через пробел:");
                a = Console.ReadLine().Split();
                for (int i = 0; i < a.Length; i++) set2.Add(a[i]);
                Console.Clear();

                Console.WriteLine("Множества:");
                foreach (string i in set1) Console.Write(i + " ");
                Console.WriteLine();
                foreach (string i in set2) Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("1. Объединение множеств (UnionWith): ");
                SET = set1;
                SET.UnionWith(set2);
                foreach (string i in SET) Console.Write(i + " ");
                Console.WriteLine();

                Console.WriteLine("2. Пересечение множеств (IntersectWith): ");
                SET = set1;
                SET.IntersectWith(set2);
                foreach (string i in SET) Console.Write(i + " ");
                Console.WriteLine();

                Console.WriteLine("3. Вычитание второго множества из первого (ExceptWith): ");
                SET = set1;
                SET.ExceptWith(set2);
                foreach (string i in SET) Console.Write(i + " ");
                Console.WriteLine();

                Console.WriteLine("4. Симметрическая разница множеств (SymmetricExceptWith): ");
                SET = set1;
                SET.SymmetricExceptWith(set2);
                foreach (string i in SET) Console.Write(i + " ");
                Console.WriteLine();

                Console.WriteLine("5. Определение, имеется ли хотя бы один общий элемент во множествах (Overlaps): ");
                Console.Write(set1.Overlaps(set2));
                Console.WriteLine();

                Console.WriteLine("6. Определение, являются ли множества равными (SetEquals): ");
                Console.Write(set1.SetEquals(set2));
                Console.WriteLine();

                Console.WriteLine("7. Определение, является ли множество 1 подмножеством 2 (IsSubsetOf): ");
                Console.Write(set1.IsSubsetOf(set2));
                Console.WriteLine();

                Console.WriteLine("8. Определение, является ли множество 1 надмножеством 2 (IsSupersetOf): ");
                Console.Write(set1.IsSupersetOf(set2));
                Console.WriteLine();

                Console.WriteLine("9. Определение, является ли множество 1 строгим подмножеством 2 (IsSubsetOf): ");
                Console.Write(set1.IsProperSubsetOf(set2));
                Console.WriteLine();

                Console.WriteLine("10. Определение, является ли множество 1 строгим надмножеством 2 (IsSupersetOf): ");
                Console.Write(set1.IsProperSupersetOf(set2));
                Console.WriteLine();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Нажмите любую кнопку, чтобы ввести новые множества.");
                Console.ReadLine();
            }
        }
    }
}