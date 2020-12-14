using System;

namespace Uebung24_DatasetArray
{
    public class Iris
    {
        public int Data1, Data2, Data3, Data4;
        public string IrisName;

        public Iris(int Data1, int Data2, int Data3, int Data4, string IrisName)
        {
            this.Data1 = Data1;
            this.Data2 = Data2;
            this.Data3 = Data3;
            this.Data4 = Data4;
            this.IrisName = IrisName;
        }

        public int getData1()
        {
            return Data1;
        }

        public int getData2()
        {
            return Data2;
        }

        public int getData3()
        {
            return Data3;
        }

        public int getData4()
        {
            return Data4;
        }

        public string getIrisName()
        {
            return IrisName;
        }

        public string Stringed()
        {
            return "D1: " + this.getData1() + ", D2: " + this.getData2() + ", D3: " + this.getData3() + ", D4: " + this.getData4() + ", Name: " + this.getIrisName();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iris prova123 = new Iris(55, 44, 33, 22, "Ciao");
            System.Console.WriteLine(prova123.Stringed());
        }
    }
}
