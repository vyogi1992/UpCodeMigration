using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpCodeMigration.Source_codes;

using System.Data;
using System.Data.OleDb;

namespace UpCodeMigration.Source_codes
{
    ///<summary>Class to handle file loads</summary>
    ///<remarks></remarks>
    public static class  FileLoad{

        ///<summary>Function to load input files</summary>
        ///<returns> True if the files are loaded correctly. False if not</returns>
        ///<remarks></remarks>
        public static bool loadInputFiles() {

            ///<summary>Load projects.csv file</summary>
            GlobalVariables.PROJECTS_TABLE  = CommonUtilityFunctions.GetDataTableFromCsv(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.PROJECS_FILENAME, true);

            ///<summary>Load CAD.csv file</summary>
            GlobalVariables.CAD_TABLE = CommonUtilityFunctions.GetDataTableFromCsv(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.PROJECS_FILENAME, false);

            ///<summary>Load untouchables.csv file</summary>
            GlobalVariables.UNTOUCHABLES_TABLE = CommonUtilityFunctions.GetDataTableFromCsv(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.UNTOUCHABLES_FILENAME, false);

            ///<summary>Check the variables and return file load status</summary>
            try
            {
                if (GlobalVariables.PROJECTS_TABLE.IsInitialized & GlobalVariables.CAD_TABLE.IsInitialized && GlobalVariables.UNTOUCHABLES_TABLE.IsInitialized)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        ///<summary>Function to compute arrival times of normal and untouchable trains</summary>
        ///<param name="untouchables_table"></param>
        ///<param name="projects_table"></param>
        ///<param name="cad_table"></param>
        ///<returns>Prints the given string</returns>
        ///<remarks></remarks>
        public static void computeArrivalTimes(DataTable untouchables_table, DataTable projects_table, DataTable cad_table)
        {
            ////String[] unt_train_arrivals= { };

            //List<List<string,List<int,<double>>>> unt_train_arrivals = new List<List<int>>();

            DataTable subdivisions = projects_table.DefaultView.ToTable(false, "Subdivision", "Control point", "Capacity");

            System.Diagnostics.Debug.WriteLine(subdivisions.Rows[1][2]);

            String[] controlPoints = projects_table.AsEnumerable().Select(r => r.Field<string>("Control point")).ToArray();

            System.Diagnostics.Debug.WriteLine(controlPoints[0]);

            //foreach(DataRow row in cad_table.Rows)
            //{
            //    String cp = row[0].ToString().Trim();
            //    if (!controlPoints.Contains(cp))
            //        continue;
            //    if (!unt_train_arrivals.Contains(cp))
            //    {
            //        unt_train_arrivals[cp] = 
            //    }

            //DataView subdivisions_raw = new System.Data.DataView(projects_table);

            ////DataTable subdivisions = subdivisions_raw.ToTable("Selected", false, "Subdivision", "Control point", "Capacity");
            //String[] controlPoints = 

        }
    }
}
