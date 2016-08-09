using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;

namespace UpCodeMigration.Source_codes
{
    ///<summary>Public class that holds all frequently used, general purpose functions</summary>
    ///<remarks></remarks>
    public static class CommonUtilityFunctions
    {

        //public static List<object> getAttribute(List<object> obj,  String attName)
        //{
        //    obj.Select(l => l.attName).ToList();

        //    return List < String >{ };
        //}
        
        ///<summary>Utility function to print a given string in debug console</summary>
        ///<param name="stringValue">The STRING value to be printed</param>
        ///<returns>Prints the given string</returns>
        ///<remarks></remarks>
        public static void print(String stringValue)
        {
            System.Diagnostics.Debug.WriteLine("OUTPUT LINE ::::::: " + stringValue);

        }

        ///<summary>Utility function to print a given integer in debug console</summary>
        ///<param name="intValue">The integer value to be printed</param>
        ///<returns>Prints the given integer</returns>
        ///<remarks></remarks>
        public static void print(int intValue)
        {
            System.Diagnostics.Debug.WriteLine("OUTPUT LINE ::::::: " + intValue);

        }

        ///<summary>Function to read a csv file</summary>
        ///<param name="path"> Full path of the input file</param>
        ///<param name="isFirstRowHeader"> true - if the input file has headers in first row. false - otherwise</param>
        ///<returns>Data table created from the csv file</returns>
        ///<remarks></remarks>
        public static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
        {
            string header = isFirstRowHeader ? "Yes" : "No";

            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
