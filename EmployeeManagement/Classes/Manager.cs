using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Manager : Employee
    {
        //manager pay group, hourly/salary
        public string PayGroup { get; set; }

        //can the manager hire anyone?
        public bool CanHire { get; set; }

        //years of experience
        public int Experience { get; set; }

        //is manager eligible for bonus
        public int Bonus { get; set; }


        //constructor for subclass TeamMember
        public Manager(int id, string name, string email, string phone, string address, string position, int salary, string payGroup, bool canHire, int experience, int bonus)
            : base(id, name, email, phone, address, position, salary)
        {
            PayGroup = payGroup;
            CanHire = canHire;
            Experience = experience;
            Bonus = bonus;
        }

        //method to display details
        public override string Display()
        {
            //print base employee details and team member details
            return base.Display() + "  Pay Group: " + PayGroup + " Can Hire: " + CanHire + "  Bonuses: " + Bonus;
        }

        //display details based on given number
        public override string Display(int num)
        {
            if (num == 2)

            {   //print Employee ID, and Position
                return Name + Position;
            }
            else
            {
                //print employee name only
                return Name + "  Pay Group: " + PayGroup + " Can Hire: " + CanHire + "  Bonuses: " + Bonus;
            }

        }
    }
}
