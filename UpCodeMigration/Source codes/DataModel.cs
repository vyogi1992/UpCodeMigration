using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCodeMigration.Source_codes
{
    public class TrainData
    {
        public String controlPoint;
        public DateTime timeStamp;
        public int hour;
        public int day;
        public String trainSymbol;

        public TrainData()
        {

        }

        public static TrainData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            TrainData trainData = new TrainData();
            trainData.controlPoint = values[0];
            trainData.timeStamp = Convert.ToDateTime(values[1]);
            trainData.hour = trainData.timeStamp.Hour;
            trainData.day = (int)trainData.timeStamp.DayOfWeek;
            trainData.trainSymbol = values[2];
            return trainData;
        }
    }

    public class ProjectData
    {
        public String subdivision;
        public int projectDays;
        public double minMP;
        public double maxMP;
        public int units;
        public int avgDailyRate;
        public int assumedCurfew;
        public int gangs;
        public int gangsPerDay;
        public double capacity;
        public String controlPoint;
        public int rerouteCost;
        public double trainDelay;
        public String subExt;


        public ProjectData()
        {

        }

        public static ProjectData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            ProjectData projectData = new ProjectData();
            projectData.subdivision = values[0];
            projectData.projectDays = Convert.ToInt32(values[1]);
            projectData.minMP = Convert.ToDouble(values[2]);
            projectData.maxMP = Convert.ToDouble(values[3]);
            projectData.units = Convert.ToInt32(values[4]);
            projectData.avgDailyRate = Convert.ToInt32(values[5]);
            projectData.assumedCurfew = Convert.ToInt32(values[6]);
            projectData.gangs = Convert.ToInt32(values[7]);
            projectData.gangsPerDay = Convert.ToInt32(values[8]);
            projectData.capacity = Convert.ToDouble(values[9]);
            projectData.controlPoint = values[10];
            projectData.rerouteCost = Convert.ToInt32(values[11]);
            projectData.trainDelay = Convert.ToDouble(values[12]);
            projectData.subExt = values[13];


            return projectData;
        }
    }



    public class UntTrainData
    {
        public String symbols;
        
        public UntTrainData()
        {

        }

        public static UntTrainData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            UntTrainData untTrainData = new UntTrainData();
            untTrainData.symbols = values[0];
           
            return untTrainData;
        }
    }


    public class UntTrainArrivals
    {
        public String controlPoint;


        public UntTrainArrivals()
        {

        }

        public static UntTrainArrivals FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            UntTrainArrivals untTrainArrivals = new UntTrainArrivals();
            untTrainArrivals.symbols = values[0];

            return untTrainArrivals;
        }
    }

}
