using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211PearsonLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pearson person1= new Pearson(1, "Ian", "Brooks", 30, "White", true);
            Pearson person2= new Pearson(2,"Gina","James",18,"Green",false);
            Pearson person3= new Pearson(3, "Mike", "Briscoe", 45, "Blue", true);
            Pearson person4= new Pearson(4, "Mary", "Beals", 28, "Yellow", true);
            Console.WriteLine(person2.DisplayPersonInfo());

            
           
            

            Console.WriteLine(person3.ToString());
            Console.WriteLine(person1.ChangeFavouriteColor());


            Console.WriteLine(person4.GetAgeInTenYears());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person3.ToString());



            Console.ReadLine();
        }
    }
}
