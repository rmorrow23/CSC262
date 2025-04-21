using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class TeamMember : Employee
    {
        //team members manager
        public string AssignedManager { get; set; }

        //team members assigned team, Finance/SoftwareDevelopment/Sales
        public string AssignedTeam { get; set; }

        //team member work location, Remote/Hybrid/Office
        public string WorkLocation { get; set; }


        //constructor for subclass TeamMember
        public TeamMember(int id, string name, string email, string phone, string address, string position, int salary, string assignedmanager, string assignedteam, string worklocation)
            : base(id, name, email, phone, address, position, salary)
        {
            AssignedManager = assignedmanager;
            AssignedTeam = assignedteam;
            WorkLocation = worklocation;
        }

        //method to display details
        public override string Display()
        {
            //print base employee details and team member details
            return base.Display() + "  Assigned Manager: " + AssignedManager + " Assigned Team: " + AssignedTeam + "  Work Location: " + WorkLocation;
        }

        //display details based on given number
        public override string Display(int num)
        {
            if (num == 2)

            {   //print Employee ID, Name, and Position
                return Name + Position;
            }
            else
            {
                //print employee name only
                return Name + " Assigned Manager: " + AssignedManager + " Assigned Team: " + AssignedTeam + " Location:" ;
            }

        }
    }
}
