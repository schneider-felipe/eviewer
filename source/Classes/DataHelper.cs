using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eViewer.Classes
{
    public static class DataHelper
    {
        private static string _filename;
        private static DataTable _dataTable;

        public static DataTable DataSource
        {
            get {
                if ((_filename != null) && (DataHelper._dataTable == null))
                {
                    DataHelper.DataSourceLoad();
                    return DataHelper._dataTable;
                }
                else
                    return DataHelper._dataTable; 
            }
        }

        public static void DataSourceLoad()
        {
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", _filename);
            var adapter = new System.Data.OleDb.OleDbDataAdapter("select * from [Leiaute$]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "excelData");
            DataHelper._dataTable = new DataTable();
            DataHelper._dataTable = ds.Tables["excelData"];
        }

        public static string Filename
        {
            get { return DataHelper._filename; }
            set 
            { 
                DataHelper._filename = value;
                DataHelper.DataSourceLoad();                
            }
        }
    }
}