using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        private static IEnumerable<Wizard> Wizards = Wizard.Wizards.Value;
        public static IEnumerable<string> GetRowlingWizards() {
            IEnumerable<string> query = 
                            from w in Wizards
                            where w.Creator == "J.K. Rowling"
                            select w.Name;

            return query;
        }

        public static IEnumerable<string> GetRowlingWizardsExtension() {
            IEnumerable<string> query = Wizards.Where(w => w.Creator == "J.K. Rowling").Select(w => w.Name); 
            return query;
        }
        
        public static int? GetYearOfFirstSith()
        {
            int? query =
                        (from w in Wizards
                        where w.Name.StartsWith("Darth")
                        orderby w.Year
                        select w.Year).First();
            return query;
        }
        public static int? GetYearOfFirstSithExtension()
        {
            int? query = Wizards.Where(w => w.Name.StartsWith("Darth")).OrderBy(w => w.Year).Select(w => w.Year).First();
            return query;
        }

        public static IEnumerable<(string, int?)> GetWizardsFromHP()
        {
            var query = 
                        from w in Wizards
                        where w.Medium == "Harry Potter"
                        select (w.Name, w.Year);
            return query;
        }

        public static IEnumerable<(string, int?)> GetWizardsFromHPExtension()
        {
            var query = Wizards.Where(w => w.Medium == "Harry Potter").Select(w => (w.Name, w.Year));
            return query;
        }

        public static IEnumerable<string> GetWizardNamesSortedByCreator()
        {
            var query = 
                        from w in Wizards
                        orderby w.Creator descending, w.Name
                        select w.Name;
            return query;
        }
                public static IEnumerable<string> GetWizardNamesSortedByCreatorExtension()
        {
            var query = Wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name);
            return query;
        }

    }
}
