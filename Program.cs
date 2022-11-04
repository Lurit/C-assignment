using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RACHAEL_S_ASSIGNMENT_2
{
    public delegate int StudentDetails(string x,int y);
    class Program
    {

        private string getStudentName;
        private int getStudentId;
        private string address;
        public string StudentAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
          
        }
       
        static void Main(string[] args)
        {
            Program m = new Program();
            m.getStudentName = "JOHN";
            Console.WriteLine("The student's name is: " +m.getStudentName);
            m.getStudentId = 001;
            Console.WriteLine("The student's ID is: " + m.getStudentId);
            m.StudentAddress = "Kampala";
            Console.WriteLine("The student's Address is: " + m.StudentAddress);
            Dictionary<string, string> w = new Dictionary<string, string>();
            w.Add("id", "001");
            w.Add("name", "JOHN");
            w.Add("address", "Kampala");
            ICollection n=w.Keys;
            Console.WriteLine("Keys \t Values");
            Console.WriteLine("----------------------");
            IDictionaryEnumerator objDictionayEnumerator =
w.GetEnumerator();
            while (objDictionayEnumerator.MoveNext())
            {
                Console.WriteLine(objDictionayEnumerator.Key.ToString()
                + "\t\t" + objDictionayEnumerator.Value);
            } 
         }
    }
}
