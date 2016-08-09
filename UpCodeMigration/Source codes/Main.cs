using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UpCodeMigration.Source_codes;


namespace UpCodeMigration
{
    public class Program
    {
        ///<summary>Main function of the project. Please start executing the program from this function. This function calls the necessary functions to complete all steps</summary>
        ///<param name="args">Any commandline arguments</param>
        ///<returns></returns>
        ///<remarks></remarks>
        public static void Main(string[] args)
        {
            ///<summary>Load input files</summary>
            //if (FileLoad.loadInputFiles()) { CommonUtilityFunctions.print("FILE LOAD COMPLETE"); }
            //else { CommonUtilityFunctions.print("FILE LOAD FAILED"); }

            FileLoad.loadTrainData();
            FileLoad.loadProjectData();
            FileLoad.loadUntTrainData();

            ArrivalTimeComputation.computeArrivalTimes();

            CommonUtilityFunctions.print(GlobalVariables.PROJECT_DATA.Count);
            CommonUtilityFunctions.print(GlobalVariables.TRAIN_DATA[0].timeStamp.ToString());
            CommonUtilityFunctions.print(GlobalVariables.UNT_TRAIN_DATA[0].symbols.ToString());



            //FileLoad.computeArrivalTimes(GlobalVariables.UNTOUCHABLES_TABLE, GlobalVariables.PROJECTS_TABLE,GlobalVariables.CAD_TABLE);
            
        }
    }
}
