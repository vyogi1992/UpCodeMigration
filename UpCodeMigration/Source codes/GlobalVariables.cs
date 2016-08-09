using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace UpCodeMigration.Source_codes
{
    ///<summary>Partial class that holds all global variables and constants</summary>
    ///<remarks></remarks>
    public static partial class GlobalVariables
    {
        ///<summary>Declare input folder base path</summary>
        public static String BASE_FOLDER_PATH = "C:/Users/Yogeswaran V/Desktop/UP/C#/Input files/";

        ///<summary>Declare input file names</summary>
        public static String PROJECTS_FILENAME = "projects.csv";
        public static String UNTOUCHABLES_FILENAME = "untouchables.csv";
        public static String CAD_FILENAME = "CAD.csv";

        public static List<TrainData> TRAIN_DATA;
        public static List<ProjectData> PROJECT_DATA;
        public static List<UntTrainData> UNT_TRAIN_DATA;

        ///<summary>Declare data tables for 3 input files</summary>
        public static DataTable PROJECTS_TABLE = null;
        public static DataTable CAD_TABLE = null;
        public static DataTable UNTOUCHABLES_TABLE = null;

        ///<summary>Declare global constants</summary>
        public static int PEAK_PRODUCTION = 312;
        public static int GANG_DAILY_COST = 71928;
        public static int[] GANG_OT_COST = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10275, 20551, 30826};
        public static int GANG_FIXED_COST = 0;
        public static int CONT_DAILY_COST = 13157;
        public static int CONT_FIXED_COST = 59497;
        public static int QC_UNLOAD_DAYS = 0;

        public static Dictionary<int, string> WEEKDAY_MAP = new Dictionary<int, string>()
        {
            {-1, "Average"},
            {0, "Monday"},
            {1, "Tuesday"},
            {2, "Wednesday"},
            {3, "Thursday"},
            {4, "Friday"},
            {5, "Saturday"},
            {6, "Sunday"}
        };

        public static Dictionary<int, double> MULTIPLIER = new Dictionary<int, double>()
        {
            {5,1},
            {6,1},
            {7,1},
            {8,1},
            {9,1},
            {10,1},
            {11,0.75},
            {12,0.75}
        };
    }   
}

