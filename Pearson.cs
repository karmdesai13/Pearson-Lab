using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211PearsonLab
{
    internal class Pearson
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favouriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavouriteColor { get => favouriteColor; set => favouriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Pearson( int id, string firstName, string lastName, int age, string favouriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavouriteColor = favouriteColor;
            IsWorking = isWorking;
                
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID:" + id + "\n";
            formatted += "First Name:" + firstName + "\n";
            formatted += "Last Name:" + lastName + "\n";
            formatted += "Age:" + age + "\n";
            formatted += "Favourite Color:" + favouriteColor + "\n";
            formatted += "Working:" + isWorking;



            return formatted;
        }

        public string DisplayPersonInfo()
        {
            string line = "";

            line += id + ":" + firstName + ""+lastName + " favourite color is" + favouriteColor;

            return line;
        }

        public string ChangeFavouriteColor()
        {
            string line = "";

            line += id + ":" + firstName +  ""+lastName + " favourite color is:White";

            return line;
        }

        public string GetAgeInTenYears()
        {
            string line = "";

            line += firstName + lastName + "Age in 10 years is:" + (age + 10);

            return line;
        }
    }
}
 