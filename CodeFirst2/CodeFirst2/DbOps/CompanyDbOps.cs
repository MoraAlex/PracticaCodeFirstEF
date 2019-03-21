using CodeFirst2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2.DbOps
{
    class CompanyDbOps
    {
        static Hitss_TM2Context db = new Hitss_TM2Context();

        public static List<Company> GetCompanies()
        {
            return db.Companies.ToList();
        }

        public static Company getCompanyById(int id)
        {
            return db.Companies.FirstOrDefault(c => c.Id == id);
        }

        public static bool setCompany(Company company)
        {
            if(!verifyByName(company.Name))
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool verifyByName(string name)
        {
            foreach(Company c in db.Companies.ToList())
            {
                if (c.Name == name)
                    return true;
            }
            return false;
        }
    }
}
