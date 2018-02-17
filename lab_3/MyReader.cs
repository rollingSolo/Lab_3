using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

using System.Threading.Tasks;

namespace lab_3
{
    class MyReader
    {
        private string fileName = "text.csv";
        private List<string[]> data = new List<string[]>();
        


        public string FileName { get => fileName; private set { } }
        public List<string[]> list { get => data; }
        

        public MyReader()
        {
            StreamReader streamReader = new StreamReader(FileName,Encoding.Default);
            string[] streamLines;
            using (streamReader)
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine().Trim();

                    line = line.Replace("\"", "");
                    streamLines = line.Split(';');
                    list.Add(streamLines);
                    
                }
            }

            ShowOutput();
            Calculate();
        }


        public void ShowOutput()
        {
            Console.WriteLine("--------------------Output from csv file------------------");
            //Console.WriteLine("A" + "  " + "B" +'\n');
            foreach (string[] item in list)
            {
                Console.WriteLine(item[0] + "   " + item[1]);
            }
            Console.WriteLine("--------------------End of output--------------------------" + '\n');
        }

        public void Calculate()
        {
            int num1 = 1;
            int num2 = 1;
            Console.WriteLine('\n' + "--------------------Result of Multiplying-----------------------");
            foreach (string[] item in list)
            {
                num1 *= Convert.ToInt32(item[0]);
                num2 *= Convert.ToInt32(item[1]);

            }

            Console.WriteLine($"first column : {num1}" + "\r\n" + $"second column : {num2}");
            
        }






    }
}
