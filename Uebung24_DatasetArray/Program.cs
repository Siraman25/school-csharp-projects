using System;

namespace Uebung24_DatasetArray
{
    public class Iris
    {
        public double Data1, Data2, Data3, Data4;
        public string IrisName;

        public Iris(double Data1, double Data2, double Data3, double Data4, string IrisName)
        {
            this.Data1 = Data1;
            this.Data2 = Data2;
            this.Data3 = Data3;
            this.Data4 = Data4;
            this.IrisName = IrisName;
        }

        public Double getData1()
        {
            return Data1;
        }

        public Double getData2()
        {
            return Data2;
        }

        public Double getData3()
        {
            return Data3;
        }

        public Double getData4()
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
        static string[] ArrayReader(string filePath, ref int counter)
        {
            System.IO.StreamReader readData = new System.IO.StreamReader(filePath);
            string[] output, lines;
            string text;
            text = readData.ReadToEnd();
            lines = text.Split(Environment.NewLine);
            output = lines[counter].Split(",");

            if (counter == lines.Length -1) {
                counter = -1;
            }
            else {
                counter++;
            }

            return (output);
        }
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter != -1)
            {
                string[] ArrayCtr = ArrayReader("/home/aris/C#/Uebung24_DatasetArray/Datasets/iris.data", ref counter);
                double data1 = Convert.ToDouble(ArrayCtr[0]);
                double data2 = Convert.ToDouble(ArrayCtr[1]);
                double data3 = Convert.ToDouble(ArrayCtr[2]);
                double data4 = Convert.ToDouble(ArrayCtr[3]);
                string data5 = ArrayCtr[4];

                Iris prova123 = new Iris(data1, data2, data3, data4, data5);
                System.Console.WriteLine(prova123.Stringed());
            }
            System.Console.WriteLine("-----------");
            System.Console.WriteLine("END REACHED");
        }
    }
}
