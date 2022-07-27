using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaledMedhatProject
{
    class Subjects : mainprg 

    {
        string[] sname2 = new string[] { "khaled", "medhat", "jack", "engy", "mariam", "sara", "kaya", "ahmed", "mohamed", "zain" };
int[] sid2 = new int[] { 17101227, 17100162, 17100321, 17100534, 17100783, 17100163, 17100847, 17100768, 17100754, 17100935 };
int s2 = 0;
int[] sub = new int[10] { 6, 6, 4, 5, 7, 6, 6, 4, 5, 6 };
        string[] SuB = new string[] {"math5" };
public Subjects() { }
public Subjects(int id, string name) :base( id,  name) { }

public override int Sub()
{
    int k;
    for (k = 0; k <= sname2.Length; k++)
    {
        if (sname2[k] == Name && sid2[k] == Id)
        {

            s2 = sub[k];
            break;
        }
        else { s2 = 0; }
    }
    return s2;
}
        public int numsub() {
            int k;
            int s = 0;
            for (k = 0; k <= sname2.Length; k++)
            {
                if (sname2[k] == Name && sid2[k] == Id)
                {

                    s= Convert.ToInt32( SuB[k]);
                    break;
                }
                else { s = 0; }
            }
            return s;

        }
public string tostring()
{

    return Convert.ToString(s2) + "/6";
}
    }
}

