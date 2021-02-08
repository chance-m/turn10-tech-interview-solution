using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Turn10TestQuestion
{
    public class Mathml
    {
        static int value1, value2;
        static string userName, operation;
        static string[] operations;
        static string[] values;

        static void Main(string[] args)
        {
            

            XmlTextReader xmlReader = new XmlTextReader("math.xml");

            while (xmlReader.Read())//For more functionality, DTO's could be used to allow for more file types in the future.
            {

                if(xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Description")
                {
                    string info = xmlReader.ReadElementContentAsString();
                    //Console.WriteLine("Description is, " + info);
                    operations = info.Split(';');

                    if (operations[1] == "SUM" /*|| values[1] == "SUB" || values[1] == "MULTIPLY" || values[1] == "DIVIDE"*/)
                    {
                        Console.WriteLine(operations[0] + " - " + operations[1]);


                    }                    

                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Value1")
                {
                    //string info = xmlReader.ReadElementContentAsString();
                    //int val1;
                    //Int32.TryParse(info, out value1);
                    int val1 = xmlReader.ReadElementContentAsInt();

                    //Console.WriteLine("Value1 is, " + value1);

                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Value2")
                {
                    string info = xmlReader.ReadElementContentAsString();
                    //val2 = xmlReader.ReadElementContentAsString();
                    //int v2 = Int32.Parse(val2);
                    //Console.WriteLine("Value2 is, " + info);
                }

                
            }


            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }

        //Methods that use the values to calculate
        public double AddValue (double val1, double val2)
        {
            return val1 + val2;
        }

        public double SubtractValue(double val1, double val2)
        {
            return val1 - val2;
        }

        public double MultiplyValue(double val1, double val2)
        {
            return val1 * val2;
        }

        public double DivideValue(double val1, double val2)
        {
            return val1 / val2;
        }

        //This method is used to access the fields outside of the clas.
        public int GetValue(string valNum)
        {
            if (valNum == "value1") {
                return value1;
            } else
            {
                return value2;
            }
        }
    }
}
