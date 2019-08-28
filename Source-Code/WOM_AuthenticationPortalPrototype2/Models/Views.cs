using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DBL;

/******************************************************************
'* DATE: 2019-06-11 3:50:27 PM
'* Derived from: WOM_SalesCoach
******************************************************************/

namespace DBL { 
    public class Views 
{
    public enum Sorting
    {
        Ascending,
        Descending,
    }

    public enum Equals
    {
        EqualTo,
        NotEquals,
    }


    public enum ViewList
    {
        viewPageViewCount
    }

    #region " - Class viewPageViewCount - definition " 
    public partial class viewPageViewCount
    {
        #region " - Sub NEW - definition "
        public viewPageViewCount(System.Int32 _keyID)
        {
            if (_keyID > 0)
            {
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand Command = new SqlCommand("SELECT [PageID], [SumOfViewCount] From [viewPageViewCount] Where [PageID]  = @Key", connection))
                    {
                        Command.CommandType = CommandType.Text;
                        Command.Parameters.Add(new SqlParameter("@Key", _keyID));
                        connection.Open();
                        IDataReader dR = Command.ExecuteReader();
                        if (dR.Read())
                        {
                            if (dR[Columns.PageID] == DBNull.Value)
                            {
                                PageID = (System.Int32)dR[Columns.PageID];
                            }
                            if (dR[Columns.SumOfViewCount] == DBNull.Value)
                            {
                                SumOfViewCount = (System.Int32)dR[Columns.SumOfViewCount];
                            }
                        }
                        dR.Close();
                        dR = null;
                        connection.Close();
                    }
                }
            }
        }
        #endregion			

        #region "- Operators -"
        public static bool operator ==(viewPageViewCount lhs, viewPageViewCount rhs)
        {
            if (lhs.PageID == rhs.PageID && lhs.SumOfViewCount == rhs.SumOfViewCount)
                return true;
            else
                return false;

        }

        public static bool operator !=(viewPageViewCount lhs, viewPageViewCount rhs)
        {
            if (lhs.PageID == rhs.PageID && lhs.SumOfViewCount == rhs.SumOfViewCount)
                return false;
            else
                return true;
        }

        #endregion

        #region " - Variable Declarations - definition "
        private System.Int32 _PageID;
        public System.Int32 PageID
        {
            get
            {
                return _PageID;
            }
            set
            {
                _PageID = value;
            }
        }
        private System.Int32 _SumOfViewCount;
        public System.Int32 SumOfViewCount
        {
            get
            {
                return _SumOfViewCount;
            }
            set
            {
                _SumOfViewCount = value;
            }
        }
        #endregion

        #region " - Column Definitions - definition "

        class Columns
        {
            public const string PageID = "PageID";

            public const string SumOfViewCount = "SumOfViewCount";


            public enum ColumnNames
            {
                PageID,
                SumOfViewCount,
            }

            public static string GetColumnName(ColumnNames ColumnEnum)
            {
                switch (ColumnEnum)
                {
                    case ColumnNames.PageID:
                        return PageID;
                    case ColumnNames.SumOfViewCount:
                        return SumOfViewCount;
                    default:
                        return PageID;
                }
            }



        }
        #endregion

        #region " - Type Definitions - definition "
        class Types
        {

            public static System.Type PageID = typeof(System.Int32);

            public static System.Type SumOfViewCount = typeof(System.Int32);
        }
        #endregion
        #region " - Reads - definition"
        class Read
        {

            public static System.Int32 PageID(System.Int32 PageID)
            {
                System.Int32 value;

                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    string strSQL = "SELECT TOP 1 [PageID] FROM [viewPageViewCount] WHERE [PageID] = @Key";
                    using (SqlCommand Command = new SqlCommand(strSQL, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        Command.Parameters.Add(new SqlParameter("@Key", PageID));
                        connection.Open();
                        try
                        {
                            value = (int)Command.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                            value = -1;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return value;
            }
            public static System.Int32 SumOfViewCount(System.Int32 SumOfViewCount)
            {
                System.Int32 value;

                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    string strSQL = "SELECT TOP 1 [SumOfViewCount] FROM [viewPageViewCount] WHERE [PageID] = @Key";
                    using (SqlCommand Command = new SqlCommand(strSQL, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        Command.Parameters.Add(new SqlParameter("@Key", SumOfViewCount));
                        connection.Open();
                        try
                        {
                            value = (int)Command.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                            value = -1;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return value;
            }

        }
        #endregion

        #region "- SELECTS - definition "
        class Select {
            public static List<viewPageViewCount> SelectAll()
            {
                return SelectRows(SelectBaseSQL(), null);
            }

            public static List<viewPageViewCount> SelectAll(Columns.ColumnNames Column, Sorting SortOrder)
            {
                string strSQL = SelectBaseSQL();
                strSQL += " ORDER BY " + Column;
                if (SortOrder == Sorting.Ascending)
                    strSQL += " ASC";
                if (SortOrder == Sorting.Descending)
                    strSQL += " DESC";
                return SelectRows(strSQL, null);
            }
            private static string SelectBaseSQL()
            {
                return "SELECT [PageID], [SumOfViewCount] From [viewPageViewCount]";
            }

            private static List<viewPageViewCount> SelectRows(string SQLString, Dictionary<Columns.ColumnNames, Object> ParameterDictionary)
            {
                List<viewPageViewCount> returnValue = new List<viewPageViewCount>();
                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    using (SqlCommand Command = new SqlCommand(SQLString, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        if (ParameterDictionary != null)
                        {
                            int i = 1;
                            foreach (Columns.ColumnNames key in ParameterDictionary.Keys)
                            {
                                if (ParameterDictionary[key].GetType() == typeof(string)) //TODO: TEST THIS?
                                {
                                    Command.Parameters.Add(new SqlParameter("@SearchValue" + i.ToString(), ParameterDictionary[key].ToString().Replace("*", "%")));
                                }
                                else
                                {
                                    Command.Parameters.Add(new SqlParameter("@SearchValue" + i.ToString(), ParameterDictionary[key]));
                                }
                                i += 1;
                            }
                        }
                        connection.Open();

                        try
                        {
                            IDataReader dR = Command.ExecuteReader();
                            do
                            {
                                viewPageViewCount MyviewPageViewCount = new viewPageViewCount(0);
                                if (dR[Columns.PageID] == DBNull.Value)
                                {
                                    MyviewPageViewCount.PageID = (System.Int32)dR[Columns.PageID];
                                }
                                if (dR[Columns.SumOfViewCount] == DBNull.Value)
                                {
                                    MyviewPageViewCount.SumOfViewCount = (System.Int32)dR[Columns.SumOfViewCount];
                                }
                            } while (dR.Read());
                            dR.Close();
                            dR = null;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<viewPageViewCount> Search(IDictionary<string, Object> SearchValues)
            {
                List<viewPageViewCount> returnValue = new List<viewPageViewCount>();
                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    string strSQL = "SELECT [PageID], [SumOfViewCount] FROM viewPageViewCount";
                    if (SearchValues.Count > 0)
                    {
                        strSQL += " WHERE ";
                        int i = 1;
                        foreach (string key in SearchValues.Keys)
                        {
                            if (SearchValues[key].GetType() == typeof(string))
                            {
                                strSQL += key + " LIKE @" + key;
                            }
                            else
                            {
                                strSQL += key + " = @" + key;
                            }
                            if (i < SearchValues.Count)
                                strSQL += " AND ";
                            i += 1;
                        }
                    }

                    using (SqlCommand Command = new SqlCommand(strSQL, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        int i = 1;
                        foreach (string key in SearchValues.Keys)
                        {
                            if (SearchValues[key].GetType() == typeof(string))
                            {
                                Command.Parameters.Add(new SqlParameter("@SearchValue" + i.ToString(), SearchValues[key].ToString().Replace("*", "%")));
                            }
                            else
                            {
                                Command.Parameters.Add(new SqlParameter("@SearchValue" + i.ToString(), SearchValues[key]));
                            }
                            i += 1;
                        }
                        connection.Open();
                        try
                        {
                            IDataReader dR = Command.ExecuteReader();
                            do
                            {
                                viewPageViewCount MyviewPageViewCount = new viewPageViewCount(0);
                                if (dR[Columns.PageID] == DBNull.Value)
                                {
                                    MyviewPageViewCount.PageID = (System.Int32)dR[Columns.PageID];
                                }
                                if (dR[Columns.SumOfViewCount] == DBNull.Value)
                                {
                                    MyviewPageViewCount.SumOfViewCount = (System.Int32)dR[Columns.SumOfViewCount];
                                }
                                returnValue.Add(MyviewPageViewCount);
                            } while (dR.Read());
                            dR.Close();
                            dR = null;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }



            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                { strSQL += Columns.GetColumnName(Column); }
                if (Equals == Equals.NotEquals)
                { strSQL += "NOT " + Columns.GetColumnName(Column); }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";

                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);



                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value, Columns.ColumnNames SortByColumn, Sorting SortOrder)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column);
                }
                if (Equals == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";
                strSQL += " ORDER BY " + SortByColumn;
                if (SortOrder == Sorting.Ascending)
                {
                    strSQL += " ASC";
                }
                if (SortOrder == Sorting.Descending)
                {
                    strSQL += " DESC";
                }
                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);
                ;
                ;
                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value, Columns.ColumnNames Column2, Equals Equals2, Object Value2)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                { strSQL += Columns.GetColumnName(Column); }
                if (Equals == Equals.NotEquals)
                { strSQL += "NOT " + Columns.GetColumnName(Column); }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";
                strSQL += " AND ";
                if (Equals2 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column2);
                }
                if (Equals2 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column2);
                }
                if (Value2.GetType() == typeof(string))
                {
                    Value2.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue2";

                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);
                Parameters.Add(Column2, Value2);


                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value, Columns.ColumnNames Column2, Equals Equals2, Object Value2, Columns.ColumnNames SortByColumn, Sorting SortOrder)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column);
                }
                if (Equals == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";
                strSQL += " AND ";
                if (Equals2 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column2);
                }
                if (Equals2 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column2);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value2.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue2";
                strSQL += " ORDER BY " + SortByColumn;
                if (SortOrder == Sorting.Ascending)
                {
                    strSQL += " ASC";
                }
                if (SortOrder == Sorting.Descending)
                {
                    strSQL += " DESC";
                }
                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);
                Parameters.Add(Column2, Value2);
                ;
                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value, Columns.ColumnNames Column2, Equals Equals2, Object Value2, Columns.ColumnNames Column3, Equals Equals3, Object Value3)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                { strSQL += Columns.GetColumnName(Column); }
                if (Equals == Equals.NotEquals)
                { strSQL += "NOT " + Columns.GetColumnName(Column); }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";
                strSQL += " AND ";
                if (Equals2 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column2);
                }
                if (Equals2 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column2);
                }
                if (Value2.GetType() == typeof(string))
                {
                    Value2.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue2";
                strSQL += " AND ";
                if (Equals3 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column3);
                }
                if (Equals3 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column3);
                }
                if (Value3.GetType() == typeof(string))
                {
                    Value3.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                { strSQL += " = "; }
                strSQL += "@SearchValue3";

                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);
                Parameters.Add(Column2, Value2);
                Parameters.Add(Column3, Value3);

                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectWhere(Columns.ColumnNames Column, Equals Equals, Object Value, Columns.ColumnNames Column2, Equals Equals2, Object Value2, Columns.ColumnNames Column3, Equals Equals3, Object Value3, Columns.ColumnNames SortByColumn, Sorting SortOrder)
            {
                string strSQL = "SELECT [PageID], [SumOfViewCount] FROM [viewPageViewCount]";
                strSQL += " WHERE ";
                if (Equals == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column);
                }
                if (Equals == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue1";
                strSQL += " AND ";
                if (Equals2 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column2);
                }
                if (Equals2 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column2);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value2.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue2";
                strSQL += " AND ";
                if (Equals3 == Equals.EqualTo)
                {
                    strSQL += Columns.GetColumnName(Column3);
                }
                if (Equals3 == Equals.NotEquals)
                {
                    strSQL += "NOT " + Columns.GetColumnName(Column3);
                }
                if (Value.GetType() == typeof(string))
                {
                    Value3.ToString().Replace("*", "%");
                    strSQL += " LIKE ";
                }
                else
                {
                    strSQL += " = ";
                }
                strSQL += "@SearchValue3";
                strSQL += " ORDER BY " + SortByColumn;
                if (SortOrder == Sorting.Ascending)
                {
                    strSQL += " ASC";
                }
                if (SortOrder == Sorting.Descending)
                {
                    strSQL += " DESC";
                }
                Dictionary<Columns.ColumnNames, Object> Parameters = new Dictionary<Columns.ColumnNames, Object>();
                Parameters.Add(Column, Value);
                Parameters.Add(Column2, Value2);
                Parameters.Add(Column3, Value3);
                return SelectRows(strSQL, Parameters);
            }

            public static List<viewPageViewCount> SelectDynamicList(string WhereClause, string SortOrder)
            {
                List<viewPageViewCount> RetVal = new List<viewPageViewCount>();
                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    string strSQL = "SELECT * FROM [viewPageViewCount]";
                    if (!WhereClause.Equals(null))
                    {
                        strSQL += " WHERE " + WhereClause;
                    }
                    if (!SortOrder.Equals(null))
                    {
                        strSQL += " ORDER BY " + SortOrder;
                    }
                    using (SqlCommand Command = new SqlCommand(strSQL, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            IDataReader dR = Command.ExecuteReader();
                            do
                            {
                                var newRow = new viewPageViewCount(0);
                                if (dR[Columns.PageID] != DBNull.Value)
                                    newRow.PageID = (System.Int32)dR[Columns.PageID];
                                if (dR[Columns.SumOfViewCount] != DBNull.Value)
                                    newRow.SumOfViewCount = (System.Int32)dR[Columns.SumOfViewCount];
                                RetVal.Add(newRow);
                            } while (dR.Read());
                            dR.Close();
                            dR = null;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return RetVal;
            }

            public static List<viewPageViewCount> SelectDynamicList(string WhereClause, string SortOrder, int NumRows)
            {
                List<viewPageViewCount> RetVal = new List<viewPageViewCount>();
                using (SqlConnection connection = new SqlConnection(DBL.Lookups.GetConnString()))
                {
                    string strSQL = "SELECT * " + NumRows + " FROM [viewPageViewCount]";
                    if (!WhereClause.Equals(null))
                        strSQL += " WHERE " + WhereClause;
                    if (!SortOrder.Equals(null))
                        strSQL += " ORDER BY " + SortOrder;
                    using (SqlCommand Command = new SqlCommand(strSQL, connection))
                    {
                        Command.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            IDataReader dR = Command.ExecuteReader();
                            do
                            {
                                viewPageViewCount newRow = new viewPageViewCount(0);
                                if (dR[Columns.PageID] != DBNull.Value)
                                    newRow.PageID = (System.Int32)dR[Columns.PageID];
                                if (dR[Columns.SumOfViewCount] != DBNull.Value)
                                    newRow.SumOfViewCount = (System.Int32)dR[Columns.SumOfViewCount];
                                RetVal.Add(newRow);
                            } while (dR.Read());
                            dR.Close();
                            dR = null;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return RetVal;
            }
            #endregion


            #endregion
        }
    }
}
}

