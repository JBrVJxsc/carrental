using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using CarRentalLibrary.Classes.Objects;
using CarRentalLibrary.DbDataSetTableAdapters;
using CarRentalLoader.Class.Managers;
using DevExpress.XtraEditors;

namespace CarRentalLibrary.Classes.Managers
{
    public class DataBaseManager
    {
        private string dataBaseUrl = "Db.mdb";
        private string dataBaseUser = "Admin";
        private string dataBasePassword = "who";
        public static readonly string connectionStringBase = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=false;";
        public static OleDbConnection connectionOfDataBase = null;
        public static DataBaseManager GlobalDataBaseManager = new DataBaseManager();

        public DataBaseManager()
        {
            try
            {
                string connectionString = string.Empty;
                if (connectionOfDataBase == null)
                {
                    connectionString = connectionStringBase;
                    connectionString += "Data Source=" + dataBaseUrl + ";";
                    connectionString += "User ID=" + dataBaseUser + ";";
                    connectionString += "Jet OLEDB:Database Password=" + dataBasePassword + ";";
                    connectionOfDataBase = new OleDbConnection(connectionString);
                    connectionOfDataBase.Open();
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("建立数据库连接出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenDataBase()
        {
            try
            {
                if (connectionOfDataBase != null)
                {
                    if (connectionOfDataBase.State != ConnectionState.Open)
                    {
                        connectionOfDataBase.Open();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("打开数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseDataBase()
        {
            try
            {
                if (connectionOfDataBase != null)
                {
                    if (connectionOfDataBase.State != ConnectionState.Closed)
                    {
                        connectionOfDataBase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("关闭数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteNonQuery(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            int result = command.ExecuteNonQuery();
            command.Parameters.Clear();
            return result;
        }

        private int ExecuteNonQuery(OleDbTransaction transaction, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, transaction.Connection, transaction, commandString, commandParameters);
            int result = command.ExecuteNonQuery();
            command.Parameters.Clear();
            return result;
        }

        private OleDbDataReader ExecuteReader(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            OleDbDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();
            return reader;
        }

        public DataSet ExecuteDataSet(OleDbConnection connection, string commandString, params OleDbParameter[] commandParameters)
        {
            OleDbCommand command = new OleDbCommand();
            PrepareCommand(command, connection, null, commandString, commandParameters);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            command.Parameters.Clear();
            return dataSet;
        }

        private void PrepareCommand(OleDbCommand command, OleDbConnection connection, OleDbTransaction transaction, string commandString, OleDbParameter[] commandParameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command.Connection = connection;
            command.CommandText = commandString;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            command.CommandType = System.Data.CommandType.Text;
            if (commandParameters != null)
            {
                foreach (OleDbParameter parameter in commandParameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
        }
        
        public int InsertLendObjectToDataTable(LendTableAdapter lendTableAdapter,DbDataSet dbDataSet, LendObject lendObject)
        {
            try
            {
                DataRow dataRow = dbDataSet.Tables[1].NewRow();
                dataRow["LendID"] = lendObject.LendID;
                dataRow["Lender"] = lendObject.Lender;
                dataRow["PersonName"] = lendObject.PersonName;
                dataRow["PersonID"] = lendObject.PersonID;
                dataRow["PersonPhone"] = lendObject.PersonPhone;
                dataRow["CarNumber"] = lendObject.CarNumber;
                dataRow["LendDate"] = lendObject.LendDate;
                dataRow["BackDate"] = lendObject.BackDate;
                dataRow["IsBack"] = lendObject.IsBack;
                dbDataSet.Tables[1].Rows.InsertAt(dataRow, 0);
                return lendTableAdapter.Update(dbDataSet);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将租车记录插入数据表出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int InsertLendObject(LendObject lendObject)
        {
            try
            {
                string sql = global::CarRentalLibrary.Properties.Resources.SQL_Insert_LendObject;
                OleDbParameter parameter0 = new OleDbParameter("@LendID", lendObject.LendID);
                OleDbParameter parameter1 = new OleDbParameter("@Lender", lendObject.Lender);
                OleDbParameter parameter2 = new OleDbParameter("@PersonName", lendObject.PersonName);
                OleDbParameter parameter3 = new OleDbParameter("@PersonID", lendObject.PersonID);
                OleDbParameter parameter4 = new OleDbParameter("@PersonPhone", lendObject.PersonPhone);
                OleDbParameter parameter5 = new OleDbParameter("@CarNumber", lendObject.CarNumber);
                OleDbParameter parameter6 = new OleDbParameter("@LendDate", lendObject.LendDate.ToString());
                OleDbParameter parameter7 = new OleDbParameter("@BackDate", lendObject.BackDate.ToString());
                OleDbParameter parameter8 = new OleDbParameter("@IsBack", lendObject.IsBack);
                return ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将租车记录插入数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public int InsertBackObject(BackObject backObject)
        {
            try
            {
                string sql = global::CarRentalLibrary.Properties.Resources.SQL_Insert_BackObject;
                OleDbParameter parameter0 = new OleDbParameter("@LendID", backObject.LendID);
                OleDbParameter parameter1 = new OleDbParameter("@Lender", backObject.Lender);
                OleDbParameter parameter2 = new OleDbParameter("@BackDate", backObject.BackDate.ToString());
                return ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("将归还记录插入数据库出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public List<LendObject> QueryLend(int number)
        {
            OleDbDataReader reader = null;
            List<LendObject> lendObjectList = null;
            try
            {
                string sql = global::CarRentalLibrary.Properties.Resources.SQL_Select_Lend_By_Top;
                sql = string.Format(sql, number);
                reader = ExecuteReader(connectionOfDataBase, sql);
                lendObjectList = new List<LendObject>();
                while (reader.Read())
                {
                    LendObject lendObject = new LendObject();
                    lendObject.LendID = reader["LendID"].ToString();
                    lendObject.Lender = reader["Lender"].ToString();
                    lendObject.PersonName = reader["PersonName"].ToString();
                    lendObject.PersonID = reader["PersonID"].ToString();
                    lendObject.PersonPhone = reader["PersonPhone"].ToString();
                    lendObject.CarNumber = reader["CarNumber"].ToString();
                    lendObject.LendDate = Convert.ToDateTime(reader["LendDate"]);
                    lendObject.BackDate = Convert.ToDateTime(reader["BackDate"]);
                    lendObject.IsBack = Convert.ToBoolean(reader["IsBack"]);
                    lendObjectList.Add(lendObject);
                }
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("获取租车记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return lendObjectList;
        }

        public int UpdateLendByLendID(LendObject lendObject, string lendID)
        {
            try
            {
                string sql = global::CarRentalLibrary.Properties.Resources.SQL_Update_Lend_By_LendID;
                OleDbParameter parameter0 = new OleDbParameter("@LendID", lendObject.LendID);
                OleDbParameter parameter1 = new OleDbParameter("@Lender", lendObject.Lender);
                OleDbParameter parameter2 = new OleDbParameter("@PersonName", lendObject.PersonName);
                OleDbParameter parameter3 = new OleDbParameter("@PersonID", lendObject.PersonID);
                OleDbParameter parameter4 = new OleDbParameter("@PersonPhone", lendObject.PersonPhone);
                OleDbParameter parameter5 = new OleDbParameter("@CarNumber", lendObject.CarNumber);
                OleDbParameter parameter6 = new OleDbParameter("@LendDate", lendObject.LendDate.ToString());
                OleDbParameter parameter7 = new OleDbParameter("@BackDate", lendObject.BackDate.ToString());
                OleDbParameter parameter8 = new OleDbParameter("@IsBack", lendObject.IsBack);
                OleDbParameter parameter9 = new OleDbParameter("@LendID", lendID);
                return ExecuteNonQuery(connectionOfDataBase, sql, parameter0, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8, parameter9);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("更新租车记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public int UpdateLendIsBack(LendTableAdapter lendTableAdapter,DbDataSet dbDataSet,DataRow dataRow)
        {
            try
            {
                dataRow["IsBack"] = true;
                return lendTableAdapter.Update(dbDataSet);
            }
            catch (Exception e)
            {
                LogManager.GlobalLogManager.CreateLog(e);
                XtraMessageBox.Show("更改数据表中的租车记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
