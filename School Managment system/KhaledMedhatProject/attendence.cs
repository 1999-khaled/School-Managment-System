using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaledMedhatProject
{
    class attendence : mainprg
    {
        string[] sname = new string[] { "khaled", "medhat", "jack", "engy", "mariam", "sara", "kaya", "ahmed", "mohamed", "zain" };
        int[] sid = new int[] { 17101227, 17100162, 17100321, 17100534, 17100783, 17100163, 17100847, 17100768, 17100754, 17100935 };
        int s = 0;
        int[] att = new int[10] { 13, 10, 9, 12, 16, 15, 11, 10, 5, 2 };
        public attendence() { }
        public attendence(int id, string name ) :base( id,  name) { }

        public override int attendance() {
            int i; 
            for (i = 0; i <= sname.Length; i++) {
                if (sname[i] == Name && sid[i] == Id)
                {

                    s = att[i];
                    break;
                }
                else { s = 0; }
            }
            return s;   
        }
        public  string tostring() {

            return Convert.ToString(s)+"/16";
        }
    }
}






