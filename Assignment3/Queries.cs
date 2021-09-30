using System.Collections.Generic;
using System;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {

        static void Main(string[] args){

        }

        public static IEnumerable<string> returnLinqInventedByRowling(){
            var wizards = Wizard.Wizards.Value;
            return from c in wizards
                    where c.Creator.Equals("Rowling")
                    select c.Name;
        }

        public static IEnumerable<string> returnLambdaInventedByRowling(){
            var wizards = Wizard.Wizards.Value;
                return wizards.Where(s => s.Creator.Equals("Rowling")).Select(w=> w.Name);
        }
        public static IEnumerable<string> returnLinqFirstSithLord(){
            var wizards = Wizard.Wizards.Value;
            return from c in wizards
                where c.Creator.Equals("George Lucas")
                orderby(c.Year)
                select c.Name;
        }

        public static IEnumerable<string> returnLambdaFirstSithLord(){
            var wizards = Wizard.Wizards.Value;
                return wizards.Where(s => s.Creator.Equals("George Lucas")).OrderBy(s => s.Year).Select(s=> s.Name);
        }
    }

}
