using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpCodeMigration.Source_codes;
using System.IO;

using System.Data;
using System.Data.OleDb;

namespace UpCodeMigration.Source_codes
{
    ///<summary>Class to handle file loads</summary>
    ///<remarks></remarks>
    public static class  FileLoad{


        ///<summary>Function to load train details file</summary>
        ///<returns> True if the file is loaded correctly. False if not</returns>
        ///<remarks></remarks>
        public static bool loadTrainData()
        {
            GlobalVariables.TRAIN_DATA = File.ReadAllLines(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.CAD_FILENAME)
                                           .Select(v => TrainData.FromCsv(v))
                                           .ToList();

            if (GlobalVariables.TRAIN_DATA.Count > 0) { return true; }
            else                                      { return false;}
        }



        ///<summary>Function to load project details file</summary>
        ///<returns> True if the file is loaded correctly. False if not</returns>
        ///<remarks></remarks>
        public static bool loadProjectData()
        {
            GlobalVariables.PROJECT_DATA = File.ReadAllLines(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.PROJECTS_FILENAME)
                                           .Skip(1)
                                           .Select(v => ProjectData.FromCsv(v))
                                           .ToList();

            if (GlobalVariables.PROJECT_DATA.Count > 0) { return true; }
            else { return false; }

        }



        ///<summary>Function to load untouchable trains details file</summary>
        ///<returns> True if the file is loaded correctly. False if not</returns>
        ///<remarks></remarks>
        public static bool loadUntTrainData()
        {
            GlobalVariables.UNT_TRAIN_DATA = File.ReadAllLines(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.UNTOUCHABLES_FILENAME)
                                           .Select(v => UntTrainData.FromCsv(v))
                                           .ToList();

            if (GlobalVariables.UNT_TRAIN_DATA.Count > 0) { return true; }
            else { return false; }

        }



        ///<summary>Function to load input files</summary>
        ///<returns> True if the files are loaded correctly. False if not</returns>
        ///<remarks></remarks>
        public static bool loadInputFiles() {

            ///<summary>Load projects.csv file</summary>
            GlobalVariables.PROJECTS_TABLE  = CommonUtilityFunctions.GetDataTableFromCsv(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.PROJECTS_FILENAME, true);

            ///<summary>Load CAD.csv file</summary>
            GlobalVariables.CAD_TABLE = CommonUtilityFunctions.GetDataTableFromCsv(GlobalVariables.BASE_FOLDER_PATH + GlobalVariables.PROJECTS_FILENAME, false);

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

        
    }
}
