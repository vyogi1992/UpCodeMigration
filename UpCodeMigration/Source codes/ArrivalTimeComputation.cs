using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCodeMigration.Source_codes
{
    public class ArrivalTimeComputation
    {
        public static ArrayList getSubdivisions()
        {
            ArrayList subdivisions = new ArrayList();
            foreach(ProjectData a in GlobalVariables.PROJECT_DATA)
            {
                ArrayList temp = new ArrayList();
                temp.Add(a.subdivision);
                temp.Add(a.controlPoint);
                temp.Add(a.capacity);
                subdivisions.Add(temp);
            }
            return subdivisions;
        }


        public static ArrayList getControlPoints(ArrayList subdivisions)
        {
            ArrayList controlPoints = new ArrayList();
            foreach (ArrayList a in subdivisions)
                controlPoints.Add(a[1]);
            return controlPoints;
        }

        ///<summary>Function to compute arrival times of normal and untouchable trains</summary>
        ///<param name="untouchables_table"></param>
        ///<param name="projects_table"></param>
        ///<param name="cad_table"></param>
        ///<returns>Prints the given string</returns>
        ///<remarks></remarks>
        public static void computeArrivalTimes()
        {
            ArrayList subdivisions = getSubdivisions();
            ArrayList controlPoints = getControlPoints(subdivisions);
            ArrayList unt_train_arrivals = new ArrayList();

            foreach (TrainData td in GlobalVariables.TRAIN_DATA)
            {
                String cp = td.controlPoint.Trim();
                if (!controlPoints.Contains(cp))
                    continue;
                if (!unt_train_arrivals.Contains(cp))
                {

                }
            }
        }
    }
}
