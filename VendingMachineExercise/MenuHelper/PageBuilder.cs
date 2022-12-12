using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    public class PageBuilder // Klass för att bygga ihop själva menyn med en top, en mid och en bottom part
    {

        public PageBuilder() 
        {
            
        }

        public void Build(string top, string[] content, string bottom) // Metod för att bygga ihop och appenda de tre delarna till en
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(top);

            foreach (var item in content) // Appendar varje individuell string ur arrayen till stringbuilder objektet
            {
                sb.AppendLine(item);
            }

            sb.Append(bottom);

            Console.WriteLine(sb.ToString());
        }

        public string BuildTop() // Metod för att sätta ihop top delen och använder sig StringBuilder
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('*', 25);
            stringBuilder.Append(" Welcome to Shop-A-Holic Vending Machine ");
            stringBuilder.Append('*', 25);
            stringBuilder.AppendLine("\n");
            return stringBuilder.ToString();
        }


        public string BuildBottom() // Metod för att sätta ihop bottom delen och använder sig StringBuilder
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n");
            stringBuilder.Append('*', 91);
            
            
            return stringBuilder.ToString();
        }
    }
             
}

