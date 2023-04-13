using System;
using System.Collections;


namespace ArrayListExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList2 = new ArrayList(100);


            arrayList.Add(25);
            arrayList.Add("Hello");
            arrayList.Add(13.37);
            arrayList.Add(13);
            arrayList.Add(128);
            arrayList.Add(25.3);

            arrayList.Remove(13);

            arrayList.RemoveAt(0);

            Console.WriteLine(arrayList.Count);

            double sum = 0;

            foreach (object obj in arrayList)
            {
                if (obj is int)
                    sum += Convert.ToDouble(obj);
                else if (obj is double)
                    sum += (double)obj;
                else
                    Console.WriteLine(obj);
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
