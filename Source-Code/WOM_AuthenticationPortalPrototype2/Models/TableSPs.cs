using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

/*******************************************************************
'* Code Generated Automatically using GlobalCodeGen and CodeRush! 
'* AUTHOR: InterGlobal Solutions

'* DATE: 2019-06-11 3:50:29 PM
'* Derived from: WOM_SalesCoach
'******************************************************************/
namespace DBL
{
    public partial class Tables
    {

        public class SPTypes
        {
            public const string SelectRow = "Select";
            public const string SelectBy = "SelectBy";
            public const string SelectAll = "SelectAll";
            public const string SelectDynamic = "SelectDynamic";
            public const string SelectPaged = "SelectPaged";
            public const string Delete = "Delete";
            public const string DeleteBy = "DeleteBy";
            public const string DeleteDynamic = "DeleteDynamic";
            public const string Insert = "Insert";
            public const string Update = "Update";
            public const string InsertUpdate = "InsertUpdate";
        }

        public class SPHelpers
        {
            public static string BuildWhereCondition(SPHelpers.WhereCondition[] ParmArray)
            {
                string StrWhere = null;
                bool ShowComma = false;
                foreach (SPHelpers.WhereCondition Parm in ParmArray)
                {
                    if (Parm.Column != "")
                    {
                        if (ShowComma)
                            StrWhere += ", ";
                        switch (Parm.Comparison)
                        {
                            case Tables.Equals.IsEqualTo:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " LIKE '" + Parm.ParmValue.ToString() + "'";
                                    else
                                        StrWhere += Parm.Column + " = " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.NotEquals:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += "Not(" + Parm.Column + " LIKE '" + Parm.ParmValue.ToString().Replace("*", "%") + "')";
                                    else
                                        StrWhere += "Not(" + Parm.Column + " = " + Parm.ParmValue.ToString() + ")";
                                    break;
                                }

                            case Tables.Equals.Contains:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " LIKE '%" + Parm.ParmValue.ToString().Replace("*", "%") + "%'";
                                    else
                                        StrWhere += Parm.Column + " IN (" + Parm.ParmValue.ToString() + ")";
                                    break;
                                }

                            case Tables.Equals.EndsWith:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " LIKE '%" + Parm.ParmValue.ToString().Replace("*", "%") + "'";
                                    else
                                        StrWhere += Parm.Column + " <= " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.LessThanEquals:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " < '" + Parm.ParmValue.ToString().Replace("*", "%") + "'";
                                    else
                                        StrWhere += Parm.Column + " <= " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.LessThan:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " < '" + Parm.ParmValue.ToString().Replace("*", "%") + "'";
                                    else
                                        StrWhere += Parm.Column + " < " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.StartsWith:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " LIKE '" + Parm.ParmValue.ToString().Replace("*", "%") + "%'";
                                    else
                                        StrWhere += Parm.Column + " >= " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.GreaterThanEquals:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " > '" + Parm.ParmValue.ToString().Replace("*", "%") + "'";
                                    else
                                        StrWhere += Parm.Column + " >= " + Parm.ParmValue.ToString();
                                    break;
                                }

                            case Tables.Equals.GreaterThan:
                                {
                                    if ((Parm.ParmValue) is string)
                                        StrWhere += Parm.Column + " > '" + Parm.ParmValue.ToString().Replace("*", "%") + "'";
                                    else
                                        StrWhere += Parm.Column + " > " + Parm.ParmValue.ToString();
                                    break;
                                }

                            default:
                                {
                                    break;
                                }
                        }
                    }
                    ShowComma = true;
                }
                return StrWhere;
            }

            public static string BuildOrderByExpression(OrderByExpression[] ParmArray)
            {
                string StrOrder = null;
                bool ShowComma = false;
                foreach (OrderByExpression Parm in ParmArray)
                {
                    if (Parm.Column != null)
                    {
                        if (ShowComma)
                            StrOrder += ", ";
                        switch (Parm.Direction)
                        {
                            case Sorting.Descending:
                                {
                                    StrOrder += Parm.Column + " DESC";
                                    break;
                                }

                            default:
                                {
                                    StrOrder += Parm.Column + " ASC";
                                    break;
                                }
                        }
                    }
                }
                return StrOrder;
            }

            public class WhereCondition
            {
                private string _Column;
                public string Column
                {
                    get
                    {
                        return _Column;
                    }
                    set
                    {
                        _Column = value;
                    }
                }

                private object _ParmValue;
                public object ParmValue
                {
                    get
                    {
                        return _ParmValue;
                    }
                    set
                    {
                        _ParmValue = value;
                    }
                }

                private Equals _Comparison;
                public Equals Comparison
                {
                    get
                    {
                        return _Comparison;
                    }
                    set
                    {
                        _Comparison = value;
                    }
                }

                public WhereCondition(string Column, Tables.Equals Comparison, object Value)
                {
                    _Column = Column;
                    _ParmValue = Value;
                    _Comparison = Comparison;
                }
            }

            public class OrderByExpression
            {
                private string _Column;
                public string Column
                {
                    get
                    {
                        return _Column;
                    }
                    set
                    {
                        _Column = value;
                    }
                }

                private Sorting _Direction;
                public Sorting Direction
                {
                    get
                    {
                        return _Direction;
                    }
                    set
                    {
                        _Direction = value;
                    }
                }

                public OrderByExpression(string Column, Sorting SortDirection)
                {
                    _Column = Column;
                    _Direction = SortDirection;
                }
            }
        }




        #region " - Class datClass"
        public partial class datClass
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClass_";
            }


            #region  - Constructors -

            public datClass(System.String ClassCode)
            {
                SetDefaults();
                if (ClassCode != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ClassCode", ClassCode));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    _ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    _CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassName)))
                                    _ClassName = dR.GetString((int)Columns.ColumnNames.ClassName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassDescription)))
                                    _ClassDescription = dR.GetString((int)Columns.ColumnNames.ClassDescription);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    _CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    _StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    _EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClass> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClass> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClass> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClass> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClass> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClass> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClass> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClass> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClass> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClass> returnValue = new List<datClass>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClass MydatClass = new datClass();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MydatClass.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatClass.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassName)))
                                    MydatClass.ClassName = dR.GetString((int)Columns.ColumnNames.ClassName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassDescription)))
                                    MydatClass.ClassDescription = dR.GetString((int)Columns.ColumnNames.ClassDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatClass.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    MydatClass.StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    MydatClass.EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClass.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatClass);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClass> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClass> returnValue = new List<datClass>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClass MydatClass = new datClass();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MydatClass.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatClass.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassName)))
                                    MydatClass.ClassName = dR.GetString((int)Columns.ColumnNames.ClassName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassDescription)))
                                    MydatClass.ClassDescription = dR.GetString((int)Columns.ColumnNames.ClassDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatClass.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    MydatClass.StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    MydatClass.EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClass.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatClass);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClass MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ClassCode != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String ClassCode, System.String CourseCode, System.String ClassName, System.String ClassDescription, System.DateTime CreatedDate, System.DateTime StartDate, System.DateTime EndDate, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (ClassCode != string.Empty)
                    ReturnValue = Insert(CourseCode, ClassName, ClassDescription, CreatedDate, StartDate, EndDate, isActive);
                else
                {
                    datClass MyLib = new datClass();

                    MyLib.ClassCode = ClassCode;

                    MyLib.CourseCode = CourseCode;

                    MyLib.ClassName = ClassName;

                    MyLib.ClassDescription = ClassDescription;

                    MyLib.CreatedDate = CreatedDate;

                    MyLib.StartDate = StartDate;

                    MyLib.EndDate = EndDate;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClass _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClass Old = new datClass(_MyLib.ClassCode);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));

                        command.Parameters.Add(new SqlParameter("@CourseCode", _MyLib.CourseCode));

                        command.Parameters.Add(new SqlParameter("@ClassName", _MyLib.ClassName));

                        command.Parameters.Add(new SqlParameter("@ClassDescription", _MyLib.ClassDescription));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));

                        command.Parameters.Add(new SqlParameter("@StartDate", _MyLib.StartDate));

                        command.Parameters.Add(new SqlParameter("@EndDate", _MyLib.EndDate));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClass  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String ClassCode)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ClassCode", ClassCode));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClass> returnValue = new List<datClass>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClass _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CourseCode", _MyLib.CourseCode));
                        command.Parameters.Add(new SqlParameter("@ClassName", _MyLib.ClassName));
                        command.Parameters.Add(new SqlParameter("@ClassDescription", _MyLib.ClassDescription));
                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));
                        command.Parameters.Add(new SqlParameter("@StartDate", _MyLib.StartDate));
                        command.Parameters.Add(new SqlParameter("@EndDate", _MyLib.EndDate));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String CourseCode, System.String ClassName, System.String ClassDescription, System.DateTime CreatedDate, System.DateTime StartDate, System.DateTime EndDate, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CourseCode", CourseCode));

                        command.Parameters.Add(new SqlParameter("@ClassName", ClassName));

                        command.Parameters.Add(new SqlParameter("@ClassDescription", ClassDescription));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", CreatedDate));

                        command.Parameters.Add(new SqlParameter("@StartDate", StartDate));

                        command.Parameters.Add(new SqlParameter("@EndDate", EndDate));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datClient"
        public partial class datClient
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClient_";
            }


            #region  - Constructors -

            public datClient(System.Int32 ClientID)
            {
                SetDefaults();
                if (ClientID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ClientID", ClientID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    _ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyName)))
                                    _CompanyName = dR.GetString((int)Columns.ColumnNames.CompanyName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyDetail)))
                                    _CompanyDetail = dR.GetString((int)Columns.ColumnNames.CompanyDetail);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.WebsiteName)))
                                    _WebsiteName = dR.GetString((int)Columns.ColumnNames.WebsiteName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.RegisterDate)))
                                    _RegisterDate = dR.GetDateTime((int)Columns.ColumnNames.RegisterDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    _IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProfileLink)))
                                    _ProfileLink = dR.GetString((int)Columns.ColumnNames.ProfileLink);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.BusinessType)))
                                    _BusinessType = dR.GetString((int)Columns.ColumnNames.BusinessType);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClient> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClient> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClient> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClient> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClient> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClient> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClient> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClient> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClient> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClient> returnValue = new List<datClient>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClient MydatClient = new datClient();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    MydatClient.ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyName)))
                                    MydatClient.CompanyName = dR.GetString((int)Columns.ColumnNames.CompanyName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyDetail)))
                                    MydatClient.CompanyDetail = dR.GetString((int)Columns.ColumnNames.CompanyDetail);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.WebsiteName)))
                                    MydatClient.WebsiteName = dR.GetString((int)Columns.ColumnNames.WebsiteName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.RegisterDate)))
                                    MydatClient.RegisterDate = dR.GetDateTime((int)Columns.ColumnNames.RegisterDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatClient.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProfileLink)))
                                    MydatClient.ProfileLink = dR.GetString((int)Columns.ColumnNames.ProfileLink);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.BusinessType)))
                                    MydatClient.BusinessType = dR.GetString((int)Columns.ColumnNames.BusinessType);


                                returnValue.Add(MydatClient);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClient> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClient> returnValue = new List<datClient>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClient MydatClient = new datClient();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    MydatClient.ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyName)))
                                    MydatClient.CompanyName = dR.GetString((int)Columns.ColumnNames.CompanyName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CompanyDetail)))
                                    MydatClient.CompanyDetail = dR.GetString((int)Columns.ColumnNames.CompanyDetail);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.WebsiteName)))
                                    MydatClient.WebsiteName = dR.GetString((int)Columns.ColumnNames.WebsiteName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.RegisterDate)))
                                    MydatClient.RegisterDate = dR.GetDateTime((int)Columns.ColumnNames.RegisterDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatClient.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProfileLink)))
                                    MydatClient.ProfileLink = dR.GetString((int)Columns.ColumnNames.ProfileLink);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.BusinessType)))
                                    MydatClient.BusinessType = dR.GetString((int)Columns.ColumnNames.BusinessType);


                                returnValue.Add(MydatClient);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClient MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ClientID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ClientID, System.String CompanyName, System.String CompanyDetail, System.String WebsiteName, System.DateTime RegisterDate, System.Boolean IsActive, System.String ProfileLink, System.String BusinessType)
            {
                int ReturnValue = 0;
                if (ClientID == 0)
                    ReturnValue = Insert(CompanyName, CompanyDetail, WebsiteName, RegisterDate, IsActive, ProfileLink, BusinessType);
                else
                {
                    datClient MyLib = new datClient();

                    MyLib.ClientID = ClientID;

                    MyLib.CompanyName = CompanyName;

                    MyLib.CompanyDetail = CompanyDetail;

                    MyLib.WebsiteName = WebsiteName;

                    MyLib.RegisterDate = RegisterDate;

                    MyLib.IsActive = IsActive;

                    MyLib.ProfileLink = ProfileLink;

                    MyLib.BusinessType = BusinessType;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClient _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClient Old = new datClient(_MyLib.ClientID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ClientID", _MyLib.ClientID));

                        command.Parameters.Add(new SqlParameter("@CompanyName", _MyLib.CompanyName));

                        command.Parameters.Add(new SqlParameter("@CompanyDetail", _MyLib.CompanyDetail));

                        command.Parameters.Add(new SqlParameter("@WebsiteName", _MyLib.WebsiteName));

                        command.Parameters.Add(new SqlParameter("@RegisterDate", _MyLib.RegisterDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));

                        command.Parameters.Add(new SqlParameter("@ProfileLink", _MyLib.ProfileLink));

                        command.Parameters.Add(new SqlParameter("@BusinessType", _MyLib.BusinessType));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClient  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ClientID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ClientID", ClientID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClient> returnValue = new List<datClient>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClient _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CompanyName", _MyLib.CompanyName));
                        command.Parameters.Add(new SqlParameter("@CompanyDetail", _MyLib.CompanyDetail));
                        command.Parameters.Add(new SqlParameter("@WebsiteName", _MyLib.WebsiteName));
                        command.Parameters.Add(new SqlParameter("@RegisterDate", _MyLib.RegisterDate));
                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));
                        command.Parameters.Add(new SqlParameter("@ProfileLink", _MyLib.ProfileLink));
                        command.Parameters.Add(new SqlParameter("@BusinessType", _MyLib.BusinessType));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String CompanyName, System.String CompanyDetail, System.String WebsiteName, System.DateTime RegisterDate, System.Boolean IsActive, System.String ProfileLink, System.String BusinessType)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CompanyName", CompanyName));

                        command.Parameters.Add(new SqlParameter("@CompanyDetail", CompanyDetail));

                        command.Parameters.Add(new SqlParameter("@WebsiteName", WebsiteName));

                        command.Parameters.Add(new SqlParameter("@RegisterDate", RegisterDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", IsActive));

                        command.Parameters.Add(new SqlParameter("@ProfileLink", ProfileLink));

                        command.Parameters.Add(new SqlParameter("@BusinessType", BusinessType));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datClientResponsesMain"
        public partial class datClientResponsesMain
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClientResponsesMain_";
            }


            #region  - Constructors -

            public datClientResponsesMain(System.Int32 clientResponseID)
            {
                SetDefaults();
                if (clientResponseID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@clientResponseID", clientResponseID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    _clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    _clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtStarted)))
                                    _dtStarted = dR.GetDateTime((int)Columns.ColumnNames.dtStarted);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.numberCorrect)))
                                    _numberCorrect = dR.GetInt32((int)Columns.ColumnNames.numberCorrect);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClientResponsesMain> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClientResponsesMain> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesMain> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesMain> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClientResponsesMain> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClientResponsesMain> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClientResponsesMain> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClientResponsesMain> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClientResponsesMain> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClientResponsesMain> returnValue = new List<datClientResponsesMain>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesMain MydatClientResponsesMain = new datClientResponsesMain();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesMain.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    MydatClientResponsesMain.clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtStarted)))
                                    MydatClientResponsesMain.dtStarted = dR.GetDateTime((int)Columns.ColumnNames.dtStarted);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClientResponsesMain.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.numberCorrect)))
                                    MydatClientResponsesMain.numberCorrect = dR.GetInt32((int)Columns.ColumnNames.numberCorrect);


                                returnValue.Add(MydatClientResponsesMain);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClientResponsesMain> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClientResponsesMain> returnValue = new List<datClientResponsesMain>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesMain MydatClientResponsesMain = new datClientResponsesMain();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesMain.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    MydatClientResponsesMain.clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtStarted)))
                                    MydatClientResponsesMain.dtStarted = dR.GetDateTime((int)Columns.ColumnNames.dtStarted);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClientResponsesMain.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.numberCorrect)))
                                    MydatClientResponsesMain.numberCorrect = dR.GetInt32((int)Columns.ColumnNames.numberCorrect);


                                returnValue.Add(MydatClientResponsesMain);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClientResponsesMain MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.clientResponseID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 clientResponseID, System.Int32 clientID, System.DateTime dtStarted, System.Boolean isActive, System.Int32 numberCorrect)
            {
                int ReturnValue = 0;
                if (clientResponseID == 0)
                    ReturnValue = Insert(clientID, dtStarted, isActive, numberCorrect);
                else
                {
                    datClientResponsesMain MyLib = new datClientResponsesMain();

                    MyLib.clientResponseID = clientResponseID;

                    MyLib.clientID = clientID;

                    MyLib.dtStarted = dtStarted;

                    MyLib.isActive = isActive;

                    MyLib.numberCorrect = numberCorrect;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClientResponsesMain _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClientResponsesMain Old = new datClientResponsesMain(_MyLib.clientResponseID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@clientResponseID", _MyLib.clientResponseID));

                        command.Parameters.Add(new SqlParameter("@clientID", _MyLib.clientID));

                        command.Parameters.Add(new SqlParameter("@dtStarted", _MyLib.dtStarted));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        command.Parameters.Add(new SqlParameter("@numberCorrect", _MyLib.numberCorrect));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClientResponsesMain  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 clientResponseID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@clientResponseID", clientResponseID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClientResponsesMain> returnValue = new List<datClientResponsesMain>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClientResponsesMain _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@clientID", _MyLib.clientID));
                        command.Parameters.Add(new SqlParameter("@dtStarted", _MyLib.dtStarted));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        command.Parameters.Add(new SqlParameter("@numberCorrect", _MyLib.numberCorrect));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 clientID, System.DateTime dtStarted, System.Boolean isActive, System.Int32 numberCorrect)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@clientID", clientID));

                        command.Parameters.Add(new SqlParameter("@dtStarted", dtStarted));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));

                        command.Parameters.Add(new SqlParameter("@numberCorrect", numberCorrect));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datClientResponsesOptions"
        public partial class datClientResponsesOptions
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClientResponsesOptions_";
            }


            #region  - Constructors -

            public datClientResponsesOptions(System.Int32 responseID)
            {
                SetDefaults();
                if (responseID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@responseID", responseID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    _responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    _clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SurveyQuestionID)))
                                    _SurveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.SurveyQuestionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    _optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClientResponsesOptions> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClientResponsesOptions> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesOptions> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesOptions> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClientResponsesOptions> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClientResponsesOptions> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClientResponsesOptions> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClientResponsesOptions> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClientResponsesOptions> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClientResponsesOptions> returnValue = new List<datClientResponsesOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesOptions MydatClientResponsesOptions = new datClientResponsesOptions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    MydatClientResponsesOptions.responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesOptions.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SurveyQuestionID)))
                                    MydatClientResponsesOptions.SurveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.SurveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    MydatClientResponsesOptions.optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);


                                returnValue.Add(MydatClientResponsesOptions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClientResponsesOptions> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClientResponsesOptions> returnValue = new List<datClientResponsesOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesOptions MydatClientResponsesOptions = new datClientResponsesOptions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    MydatClientResponsesOptions.responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesOptions.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SurveyQuestionID)))
                                    MydatClientResponsesOptions.SurveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.SurveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    MydatClientResponsesOptions.optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);


                                returnValue.Add(MydatClientResponsesOptions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClientResponsesOptions MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.responseID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 responseID, System.Int32 clientResponseID, System.Int32 SurveyQuestionID, System.Int32 optionID)
            {
                int ReturnValue = 0;
                if (responseID == 0)
                    ReturnValue = Insert(clientResponseID, SurveyQuestionID, optionID);
                else
                {
                    datClientResponsesOptions MyLib = new datClientResponsesOptions();

                    MyLib.responseID = responseID;

                    MyLib.clientResponseID = clientResponseID;

                    MyLib.SurveyQuestionID = SurveyQuestionID;

                    MyLib.optionID = optionID;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClientResponsesOptions _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClientResponsesOptions Old = new datClientResponsesOptions(_MyLib.responseID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@responseID", _MyLib.responseID));

                        command.Parameters.Add(new SqlParameter("@clientResponseID", _MyLib.clientResponseID));

                        command.Parameters.Add(new SqlParameter("@SurveyQuestionID", _MyLib.SurveyQuestionID));

                        command.Parameters.Add(new SqlParameter("@optionID", _MyLib.optionID));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClientResponsesOptions  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 responseID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@responseID", responseID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClientResponsesOptions> returnValue = new List<datClientResponsesOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClientResponsesOptions _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@clientResponseID", _MyLib.clientResponseID));
                        command.Parameters.Add(new SqlParameter("@SurveyQuestionID", _MyLib.SurveyQuestionID));
                        command.Parameters.Add(new SqlParameter("@optionID", _MyLib.optionID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 clientResponseID, System.Int32 SurveyQuestionID, System.Int32 optionID)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@clientResponseID", clientResponseID));

                        command.Parameters.Add(new SqlParameter("@SurveyQuestionID", SurveyQuestionID));

                        command.Parameters.Add(new SqlParameter("@optionID", optionID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datClientResponsesText"
        public partial class datClientResponsesText
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClientResponsesText_";
            }


            #region  - Constructors -

            public datClientResponsesText(System.Int32 responseID)
            {
                SetDefaults();
                if (responseID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@responseID", responseID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    _responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    _clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    _surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseText)))
                                    _responseText = dR.GetString((int)Columns.ColumnNames.responseText);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClientResponsesText> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClientResponsesText> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesText> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientResponsesText> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClientResponsesText> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClientResponsesText> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClientResponsesText> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClientResponsesText> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClientResponsesText> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClientResponsesText> returnValue = new List<datClientResponsesText>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesText MydatClientResponsesText = new datClientResponsesText();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    MydatClientResponsesText.responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesText.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    MydatClientResponsesText.surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseText)))
                                    MydatClientResponsesText.responseText = dR.GetString((int)Columns.ColumnNames.responseText);


                                returnValue.Add(MydatClientResponsesText);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClientResponsesText> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClientResponsesText> returnValue = new List<datClientResponsesText>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientResponsesText MydatClientResponsesText = new datClientResponsesText();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseID)))
                                    MydatClientResponsesText.responseID = dR.GetInt32((int)Columns.ColumnNames.responseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientResponseID)))
                                    MydatClientResponsesText.clientResponseID = dR.GetInt32((int)Columns.ColumnNames.clientResponseID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    MydatClientResponsesText.surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.responseText)))
                                    MydatClientResponsesText.responseText = dR.GetString((int)Columns.ColumnNames.responseText);


                                returnValue.Add(MydatClientResponsesText);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClientResponsesText MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.responseID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 responseID, System.Int32 clientResponseID, System.Int32 surveyQuestionID, System.String responseText)
            {
                int ReturnValue = 0;
                if (responseID == 0)
                    ReturnValue = Insert(clientResponseID, surveyQuestionID, responseText);
                else
                {
                    datClientResponsesText MyLib = new datClientResponsesText();

                    MyLib.responseID = responseID;

                    MyLib.clientResponseID = clientResponseID;

                    MyLib.surveyQuestionID = surveyQuestionID;

                    MyLib.responseText = responseText;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClientResponsesText _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClientResponsesText Old = new datClientResponsesText(_MyLib.responseID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@responseID", _MyLib.responseID));

                        command.Parameters.Add(new SqlParameter("@clientResponseID", _MyLib.clientResponseID));

                        command.Parameters.Add(new SqlParameter("@surveyQuestionID", _MyLib.surveyQuestionID));

                        command.Parameters.Add(new SqlParameter("@responseText", _MyLib.responseText));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClientResponsesText  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 responseID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@responseID", responseID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClientResponsesText> returnValue = new List<datClientResponsesText>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClientResponsesText _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@clientResponseID", _MyLib.clientResponseID));
                        command.Parameters.Add(new SqlParameter("@surveyQuestionID", _MyLib.surveyQuestionID));
                        command.Parameters.Add(new SqlParameter("@responseText", _MyLib.responseText));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 clientResponseID, System.Int32 surveyQuestionID, System.String responseText)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@clientResponseID", clientResponseID));

                        command.Parameters.Add(new SqlParameter("@surveyQuestionID", surveyQuestionID));

                        command.Parameters.Add(new SqlParameter("@responseText", responseText));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datClientSocialMedia"
        public partial class datClientSocialMedia
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datClientSocialMedia_";
            }


            #region  - Constructors -

            public datClientSocialMedia(System.Int32 ID)
            {
                SetDefaults();
                if (ID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ID", ID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    _ID = dR.GetInt32((int)Columns.ColumnNames.ID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    _clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smTypeID)))
                                    _smTypeID = dR.GetInt32((int)Columns.ColumnNames.smTypeID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.URLstring)))
                                    _URLstring = dR.GetString((int)Columns.ColumnNames.URLstring);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    _DisplayOrder = dR.GetByte((int)Columns.ColumnNames.DisplayOrder);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datClientSocialMedia> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datClientSocialMedia> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientSocialMedia> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datClientSocialMedia> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datClientSocialMedia> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datClientSocialMedia> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datClientSocialMedia> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datClientSocialMedia> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datClientSocialMedia> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datClientSocialMedia> returnValue = new List<datClientSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientSocialMedia MydatClientSocialMedia = new datClientSocialMedia();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    MydatClientSocialMedia.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    MydatClientSocialMedia.clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smTypeID)))
                                    MydatClientSocialMedia.smTypeID = dR.GetInt32((int)Columns.ColumnNames.smTypeID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.URLstring)))
                                    MydatClientSocialMedia.URLstring = dR.GetString((int)Columns.ColumnNames.URLstring);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClientSocialMedia.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MydatClientSocialMedia.DisplayOrder = dR.GetByte((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MydatClientSocialMedia);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datClientSocialMedia> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datClientSocialMedia> returnValue = new List<datClientSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datClientSocialMedia MydatClientSocialMedia = new datClientSocialMedia();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    MydatClientSocialMedia.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.clientID)))
                                    MydatClientSocialMedia.clientID = dR.GetInt32((int)Columns.ColumnNames.clientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smTypeID)))
                                    MydatClientSocialMedia.smTypeID = dR.GetInt32((int)Columns.ColumnNames.smTypeID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.URLstring)))
                                    MydatClientSocialMedia.URLstring = dR.GetString((int)Columns.ColumnNames.URLstring);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatClientSocialMedia.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MydatClientSocialMedia.DisplayOrder = dR.GetByte((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MydatClientSocialMedia);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datClientSocialMedia MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ID, System.Int32 clientID, System.Int32 smTypeID, System.String URLstring, System.Boolean isActive, System.Int32 DisplayOrder)
            {
                int ReturnValue = 0;
                if (ID == 0)
                    ReturnValue = Insert(clientID, smTypeID, URLstring, isActive, DisplayOrder);
                else
                {
                    datClientSocialMedia MyLib = new datClientSocialMedia();

                    MyLib.ID = ID;

                    MyLib.clientID = clientID;

                    MyLib.smTypeID = smTypeID;

                    MyLib.URLstring = URLstring;

                    MyLib.isActive = isActive;

                    MyLib.DisplayOrder = DisplayOrder;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datClientSocialMedia _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datClientSocialMedia Old = new datClientSocialMedia(_MyLib.ID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", _MyLib.ID));

                        command.Parameters.Add(new SqlParameter("@clientID", _MyLib.clientID));

                        command.Parameters.Add(new SqlParameter("@smTypeID", _MyLib.smTypeID));

                        command.Parameters.Add(new SqlParameter("@URLstring", _MyLib.URLstring));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datClientSocialMedia  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", ID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datClientSocialMedia> returnValue = new List<datClientSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datClientSocialMedia _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@clientID", _MyLib.clientID));
                        command.Parameters.Add(new SqlParameter("@smTypeID", _MyLib.smTypeID));
                        command.Parameters.Add(new SqlParameter("@URLstring", _MyLib.URLstring));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 clientID, System.Int32 smTypeID, System.String URLstring, System.Boolean isActive, System.Int32 DisplayOrder)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@clientID", clientID));

                        command.Parameters.Add(new SqlParameter("@smTypeID", smTypeID));

                        command.Parameters.Add(new SqlParameter("@URLstring", URLstring));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datCoach"
        public partial class datCoach
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datCoach_";
            }


            #region  - Constructors -

            public datCoach(System.Int32 CoachID)
            {
                SetDefaults();
                if (CoachID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@CoachID", CoachID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    _CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    _DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    _StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    _EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    _IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datCoach> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datCoach> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCoach> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCoach> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datCoach> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datCoach> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datCoach> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datCoach> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datCoach> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datCoach> returnValue = new List<datCoach>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCoach MydatCoach = new datCoach();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    MydatCoach.CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    MydatCoach.DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    MydatCoach.StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    MydatCoach.EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatCoach.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);


                                returnValue.Add(MydatCoach);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datCoach> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datCoach> returnValue = new List<datCoach>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCoach MydatCoach = new datCoach();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    MydatCoach.CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    MydatCoach.DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StartDate)))
                                    MydatCoach.StartDate = dR.GetDateTime((int)Columns.ColumnNames.StartDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EndDate)))
                                    MydatCoach.EndDate = dR.GetDateTime((int)Columns.ColumnNames.EndDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatCoach.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);


                                returnValue.Add(MydatCoach);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datCoach MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.CoachID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 CoachID, System.String DesignationID, System.DateTime StartDate, System.DateTime EndDate, System.Boolean IsActive)
            {
                int ReturnValue = 0;
                if (CoachID == 0)
                    ReturnValue = Insert(DesignationID, StartDate, EndDate, IsActive);
                else
                {
                    datCoach MyLib = new datCoach();

                    MyLib.CoachID = CoachID;

                    MyLib.DesignationID = DesignationID;

                    MyLib.StartDate = StartDate;

                    MyLib.EndDate = EndDate;

                    MyLib.IsActive = IsActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datCoach _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datCoach Old = new datCoach(_MyLib.CoachID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CoachID", _MyLib.CoachID));

                        command.Parameters.Add(new SqlParameter("@DesignationID", _MyLib.DesignationID));

                        command.Parameters.Add(new SqlParameter("@StartDate", _MyLib.StartDate));

                        command.Parameters.Add(new SqlParameter("@EndDate", _MyLib.EndDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datCoach  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 CoachID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CoachID", CoachID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datCoach> returnValue = new List<datCoach>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datCoach _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@DesignationID", _MyLib.DesignationID));
                        command.Parameters.Add(new SqlParameter("@StartDate", _MyLib.StartDate));
                        command.Parameters.Add(new SqlParameter("@EndDate", _MyLib.EndDate));
                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String DesignationID, System.DateTime StartDate, System.DateTime EndDate, System.Boolean IsActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@DesignationID", DesignationID));

                        command.Parameters.Add(new SqlParameter("@StartDate", StartDate));

                        command.Parameters.Add(new SqlParameter("@EndDate", EndDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", IsActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datCourse"
        public partial class datCourse
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datCourse_";
            }


            #region  - Constructors -

            public datCourse(System.String CourseCode)
            {
                SetDefaults();
                if (CourseCode != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@CourseCode", CourseCode));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    _CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseName)))
                                    _CourseName = dR.GetString((int)Columns.ColumnNames.CourseName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseDescription)))
                                    _CourseDescription = dR.GetString((int)Columns.ColumnNames.CourseDescription);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    _CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datCourse> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datCourse> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCourse> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCourse> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datCourse> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datCourse> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datCourse> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datCourse> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datCourse> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datCourse> returnValue = new List<datCourse>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCourse MydatCourse = new datCourse();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatCourse.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseName)))
                                    MydatCourse.CourseName = dR.GetString((int)Columns.ColumnNames.CourseName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseDescription)))
                                    MydatCourse.CourseDescription = dR.GetString((int)Columns.ColumnNames.CourseDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatCourse.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatCourse.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatCourse);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datCourse> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datCourse> returnValue = new List<datCourse>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCourse MydatCourse = new datCourse();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatCourse.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseName)))
                                    MydatCourse.CourseName = dR.GetString((int)Columns.ColumnNames.CourseName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseDescription)))
                                    MydatCourse.CourseDescription = dR.GetString((int)Columns.ColumnNames.CourseDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatCourse.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatCourse.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatCourse);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datCourse MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.CourseCode != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String CourseCode, System.String CourseName, System.String CourseDescription, System.DateTime CreatedDate, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (CourseCode != string.Empty)
                    ReturnValue = Insert(CourseName, CourseDescription, CreatedDate, isActive);
                else
                {
                    datCourse MyLib = new datCourse();

                    MyLib.CourseCode = CourseCode;

                    MyLib.CourseName = CourseName;

                    MyLib.CourseDescription = CourseDescription;

                    MyLib.CreatedDate = CreatedDate;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datCourse _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datCourse Old = new datCourse(_MyLib.CourseCode);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CourseCode", _MyLib.CourseCode));

                        command.Parameters.Add(new SqlParameter("@CourseName", _MyLib.CourseName));

                        command.Parameters.Add(new SqlParameter("@CourseDescription", _MyLib.CourseDescription));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datCourse  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String CourseCode)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CourseCode", CourseCode));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datCourse> returnValue = new List<datCourse>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datCourse _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CourseName", _MyLib.CourseName));
                        command.Parameters.Add(new SqlParameter("@CourseDescription", _MyLib.CourseDescription));
                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String CourseName, System.String CourseDescription, System.DateTime CreatedDate, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CourseName", CourseName));

                        command.Parameters.Add(new SqlParameter("@CourseDescription", CourseDescription));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", CreatedDate));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datCurriculum"
        public partial class datCurriculum
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datCurriculum_";
            }


            #region  - Constructors -

            public datCurriculum(System.Int32 CurriculumID)
            {
                SetDefaults();
                if (CurriculumID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@CurriculumID", CurriculumID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    _CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    _CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datCurriculum> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datCurriculum> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCurriculum> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datCurriculum> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datCurriculum> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datCurriculum> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datCurriculum> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datCurriculum> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datCurriculum> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datCurriculum> returnValue = new List<datCurriculum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCurriculum MydatCurriculum = new datCurriculum();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    MydatCurriculum.CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatCurriculum.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatCurriculum.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatCurriculum);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datCurriculum> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datCurriculum> returnValue = new List<datCurriculum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datCurriculum MydatCurriculum = new datCurriculum();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    MydatCurriculum.CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CourseCode)))
                                    MydatCurriculum.CourseCode = dR.GetString((int)Columns.ColumnNames.CourseCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatCurriculum.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MydatCurriculum);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datCurriculum MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.CurriculumID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 CurriculumID, System.String CourseCode, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (CurriculumID == 0)
                    ReturnValue = Insert(CourseCode, isActive);
                else
                {
                    datCurriculum MyLib = new datCurriculum();

                    MyLib.CurriculumID = CurriculumID;

                    MyLib.CourseCode = CourseCode;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datCurriculum _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datCurriculum Old = new datCurriculum(_MyLib.CurriculumID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CurriculumID", _MyLib.CurriculumID));

                        command.Parameters.Add(new SqlParameter("@CourseCode", _MyLib.CourseCode));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datCurriculum  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 CurriculumID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CurriculumID", CurriculumID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datCurriculum> returnValue = new List<datCurriculum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datCurriculum _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CourseCode", _MyLib.CourseCode));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String CourseCode, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CourseCode", CourseCode));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datForums"
        public partial class datForums
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datForums_";
            }


            #region  - Constructors -

            public datForums(System.Int32 ForumID)
            {
                SetDefaults();
                if (ForumID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ForumID", ForumID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    _ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumName)))
                                    _ForumName = dR.GetString((int)Columns.ColumnNames.ForumName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    _IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    _IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSticky)))
                                    _IsSticky = dR.GetBoolean((int)Columns.ColumnNames.IsSticky);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsPrivate)))
                                    _IsPrivate = dR.GetBoolean((int)Columns.ColumnNames.IsPrivate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.UserCreated)))
                                    _UserCreated = dR.GetString((int)Columns.ColumnNames.UserCreated);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    _CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    _ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datForums> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datForums> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datForums> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datForums> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datForums> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datForums> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datForums> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datForums> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datForums> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datForums> returnValue = new List<datForums>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datForums MydatForums = new datForums();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MydatForums.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumName)))
                                    MydatForums.ForumName = dR.GetString((int)Columns.ColumnNames.ForumName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatForums.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    MydatForums.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSticky)))
                                    MydatForums.IsSticky = dR.GetBoolean((int)Columns.ColumnNames.IsSticky);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsPrivate)))
                                    MydatForums.IsPrivate = dR.GetBoolean((int)Columns.ColumnNames.IsPrivate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.UserCreated)))
                                    MydatForums.UserCreated = dR.GetString((int)Columns.ColumnNames.UserCreated);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatForums.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    MydatForums.ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);


                                returnValue.Add(MydatForums);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datForums> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datForums> returnValue = new List<datForums>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datForums MydatForums = new datForums();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MydatForums.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumName)))
                                    MydatForums.ForumName = dR.GetString((int)Columns.ColumnNames.ForumName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatForums.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    MydatForums.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSticky)))
                                    MydatForums.IsSticky = dR.GetBoolean((int)Columns.ColumnNames.IsSticky);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsPrivate)))
                                    MydatForums.IsPrivate = dR.GetBoolean((int)Columns.ColumnNames.IsPrivate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.UserCreated)))
                                    MydatForums.UserCreated = dR.GetString((int)Columns.ColumnNames.UserCreated);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CreatedDate)))
                                    MydatForums.CreatedDate = dR.GetDateTime((int)Columns.ColumnNames.CreatedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    MydatForums.ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);


                                returnValue.Add(MydatForums);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datForums MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ForumID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ForumID, System.String ForumName, System.Boolean IsActive, System.Boolean IsApproved, System.Boolean IsSticky, System.Boolean IsPrivate, System.String UserCreated, System.DateTime CreatedDate, System.DateTime ExpiryDate)
            {
                int ReturnValue = 0;
                if (ForumID == 0)
                    ReturnValue = Insert(ForumName, IsActive, IsApproved, IsSticky, IsPrivate, UserCreated, CreatedDate, ExpiryDate);
                else
                {
                    datForums MyLib = new datForums();

                    MyLib.ForumID = ForumID;

                    MyLib.ForumName = ForumName;

                    MyLib.IsActive = IsActive;

                    MyLib.IsApproved = IsApproved;

                    MyLib.IsSticky = IsSticky;

                    MyLib.IsPrivate = IsPrivate;

                    MyLib.UserCreated = UserCreated;

                    MyLib.CreatedDate = CreatedDate;

                    MyLib.ExpiryDate = ExpiryDate;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datForums _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datForums Old = new datForums(_MyLib.ForumID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ForumID", _MyLib.ForumID));

                        command.Parameters.Add(new SqlParameter("@ForumName", _MyLib.ForumName));

                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));

                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));

                        command.Parameters.Add(new SqlParameter("@IsSticky", _MyLib.IsSticky));

                        command.Parameters.Add(new SqlParameter("@IsPrivate", _MyLib.IsPrivate));

                        command.Parameters.Add(new SqlParameter("@UserCreated", _MyLib.UserCreated));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));

                        command.Parameters.Add(new SqlParameter("@ExpiryDate", _MyLib.ExpiryDate));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datForums  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ForumID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ForumID", ForumID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datForums> returnValue = new List<datForums>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datForums _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@ForumName", _MyLib.ForumName));
                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));
                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));
                        command.Parameters.Add(new SqlParameter("@IsSticky", _MyLib.IsSticky));
                        command.Parameters.Add(new SqlParameter("@IsPrivate", _MyLib.IsPrivate));
                        command.Parameters.Add(new SqlParameter("@UserCreated", _MyLib.UserCreated));
                        command.Parameters.Add(new SqlParameter("@CreatedDate", _MyLib.CreatedDate));
                        command.Parameters.Add(new SqlParameter("@ExpiryDate", _MyLib.ExpiryDate));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String ForumName, System.Boolean IsActive, System.Boolean IsApproved, System.Boolean IsSticky, System.Boolean IsPrivate, System.String UserCreated, System.DateTime CreatedDate, System.DateTime ExpiryDate)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@ForumName", ForumName));

                        command.Parameters.Add(new SqlParameter("@IsActive", IsActive));

                        command.Parameters.Add(new SqlParameter("@IsApproved", IsApproved));

                        command.Parameters.Add(new SqlParameter("@IsSticky", IsSticky));

                        command.Parameters.Add(new SqlParameter("@IsPrivate", IsPrivate));

                        command.Parameters.Add(new SqlParameter("@UserCreated", UserCreated));

                        command.Parameters.Add(new SqlParameter("@CreatedDate", CreatedDate));

                        command.Parameters.Add(new SqlParameter("@ExpiryDate", ExpiryDate));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datPerson"
        public partial class datPerson
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datPerson_";
            }


            #region  - Constructors -

            public datPerson(System.Int32 PersonID)
            {
                SetDefaults();
                if (PersonID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@PersonID", PersonID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    _PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.FirstName)))
                                    _FirstName = dR.GetString((int)Columns.ColumnNames.FirstName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.LastName)))
                                    _LastName = dR.GetString((int)Columns.ColumnNames.LastName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Gender)))
                                    _Gender = dR.GetString((int)Columns.ColumnNames.Gender);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PhoneNumber)))
                                    _PhoneNumber = dR.GetString((int)Columns.ColumnNames.PhoneNumber);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress)))
                                    _StreetAddress = dR.GetString((int)Columns.ColumnNames.StreetAddress);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress2)))
                                    _StreetAddress2 = dR.GetString((int)Columns.ColumnNames.StreetAddress2);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.City)))
                                    _City = dR.GetString((int)Columns.ColumnNames.City);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Prov)))
                                    _Prov = dR.GetString((int)Columns.ColumnNames.Prov);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostalCode)))
                                    _PostalCode = dR.GetString((int)Columns.ColumnNames.PostalCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DateOfBirth)))
                                    _DateOfBirth = dR.GetDateTime((int)Columns.ColumnNames.DateOfBirth);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datPerson> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datPerson> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datPerson> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datPerson> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datPerson> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datPerson> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datPerson> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datPerson> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datPerson> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datPerson> returnValue = new List<datPerson>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datPerson MydatPerson = new datPerson();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    MydatPerson.PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.FirstName)))
                                    MydatPerson.FirstName = dR.GetString((int)Columns.ColumnNames.FirstName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.LastName)))
                                    MydatPerson.LastName = dR.GetString((int)Columns.ColumnNames.LastName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Gender)))
                                    MydatPerson.Gender = dR.GetString((int)Columns.ColumnNames.Gender);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PhoneNumber)))
                                    MydatPerson.PhoneNumber = dR.GetString((int)Columns.ColumnNames.PhoneNumber);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress)))
                                    MydatPerson.StreetAddress = dR.GetString((int)Columns.ColumnNames.StreetAddress);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress2)))
                                    MydatPerson.StreetAddress2 = dR.GetString((int)Columns.ColumnNames.StreetAddress2);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.City)))
                                    MydatPerson.City = dR.GetString((int)Columns.ColumnNames.City);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Prov)))
                                    MydatPerson.Prov = dR.GetString((int)Columns.ColumnNames.Prov);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostalCode)))
                                    MydatPerson.PostalCode = dR.GetString((int)Columns.ColumnNames.PostalCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DateOfBirth)))
                                    MydatPerson.DateOfBirth = dR.GetDateTime((int)Columns.ColumnNames.DateOfBirth);


                                returnValue.Add(MydatPerson);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datPerson> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datPerson> returnValue = new List<datPerson>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datPerson MydatPerson = new datPerson();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    MydatPerson.PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.FirstName)))
                                    MydatPerson.FirstName = dR.GetString((int)Columns.ColumnNames.FirstName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.LastName)))
                                    MydatPerson.LastName = dR.GetString((int)Columns.ColumnNames.LastName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Gender)))
                                    MydatPerson.Gender = dR.GetString((int)Columns.ColumnNames.Gender);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PhoneNumber)))
                                    MydatPerson.PhoneNumber = dR.GetString((int)Columns.ColumnNames.PhoneNumber);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress)))
                                    MydatPerson.StreetAddress = dR.GetString((int)Columns.ColumnNames.StreetAddress);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StreetAddress2)))
                                    MydatPerson.StreetAddress2 = dR.GetString((int)Columns.ColumnNames.StreetAddress2);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.City)))
                                    MydatPerson.City = dR.GetString((int)Columns.ColumnNames.City);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Prov)))
                                    MydatPerson.Prov = dR.GetString((int)Columns.ColumnNames.Prov);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostalCode)))
                                    MydatPerson.PostalCode = dR.GetString((int)Columns.ColumnNames.PostalCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DateOfBirth)))
                                    MydatPerson.DateOfBirth = dR.GetDateTime((int)Columns.ColumnNames.DateOfBirth);


                                returnValue.Add(MydatPerson);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datPerson MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.PersonID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 PersonID, System.String FirstName, System.String LastName, System.String Gender, System.String PhoneNumber, System.String StreetAddress, System.String StreetAddress2, System.String City, System.String Prov, System.String PostalCode, System.DateTime DateOfBirth)
            {
                int ReturnValue = 0;
                if (PersonID == 0)
                    ReturnValue = Insert(FirstName, LastName, Gender, PhoneNumber, StreetAddress, StreetAddress2, City, Prov, PostalCode, DateOfBirth);
                else
                {
                    datPerson MyLib = new datPerson();

                    MyLib.PersonID = PersonID;

                    MyLib.FirstName = FirstName;

                    MyLib.LastName = LastName;

                    MyLib.Gender = Gender;

                    MyLib.PhoneNumber = PhoneNumber;

                    MyLib.StreetAddress = StreetAddress;

                    MyLib.StreetAddress2 = StreetAddress2;

                    MyLib.City = City;

                    MyLib.Prov = Prov;

                    MyLib.PostalCode = PostalCode;

                    MyLib.DateOfBirth = DateOfBirth;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datPerson _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datPerson Old = new datPerson(_MyLib.PersonID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PersonID", _MyLib.PersonID));

                        command.Parameters.Add(new SqlParameter("@FirstName", _MyLib.FirstName));

                        command.Parameters.Add(new SqlParameter("@LastName", _MyLib.LastName));

                        command.Parameters.Add(new SqlParameter("@Gender", _MyLib.Gender));

                        command.Parameters.Add(new SqlParameter("@PhoneNumber", _MyLib.PhoneNumber));

                        command.Parameters.Add(new SqlParameter("@StreetAddress", _MyLib.StreetAddress));

                        command.Parameters.Add(new SqlParameter("@StreetAddress2", _MyLib.StreetAddress2));

                        command.Parameters.Add(new SqlParameter("@City", _MyLib.City));

                        command.Parameters.Add(new SqlParameter("@Prov", _MyLib.Prov));

                        command.Parameters.Add(new SqlParameter("@PostalCode", _MyLib.PostalCode));

                        command.Parameters.Add(new SqlParameter("@DateOfBirth", _MyLib.DateOfBirth));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datPerson  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 PersonID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PersonID", PersonID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datPerson> returnValue = new List<datPerson>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datPerson _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@FirstName", _MyLib.FirstName));
                        command.Parameters.Add(new SqlParameter("@LastName", _MyLib.LastName));
                        command.Parameters.Add(new SqlParameter("@Gender", _MyLib.Gender));
                        command.Parameters.Add(new SqlParameter("@PhoneNumber", _MyLib.PhoneNumber));
                        command.Parameters.Add(new SqlParameter("@StreetAddress", _MyLib.StreetAddress));
                        command.Parameters.Add(new SqlParameter("@StreetAddress2", _MyLib.StreetAddress2));
                        command.Parameters.Add(new SqlParameter("@City", _MyLib.City));
                        command.Parameters.Add(new SqlParameter("@Prov", _MyLib.Prov));
                        command.Parameters.Add(new SqlParameter("@PostalCode", _MyLib.PostalCode));
                        command.Parameters.Add(new SqlParameter("@DateOfBirth", _MyLib.DateOfBirth));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String FirstName, System.String LastName, System.String Gender, System.String PhoneNumber, System.String StreetAddress, System.String StreetAddress2, System.String City, System.String Prov, System.String PostalCode, System.DateTime DateOfBirth)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@FirstName", FirstName));

                        command.Parameters.Add(new SqlParameter("@LastName", LastName));

                        command.Parameters.Add(new SqlParameter("@Gender", Gender));

                        command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));

                        command.Parameters.Add(new SqlParameter("@StreetAddress", StreetAddress));

                        command.Parameters.Add(new SqlParameter("@StreetAddress2", StreetAddress2));

                        command.Parameters.Add(new SqlParameter("@City", City));

                        command.Parameters.Add(new SqlParameter("@Prov", Prov));

                        command.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));

                        command.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datPosts"
        public partial class datPosts
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datPosts_";
            }


            #region  - Constructors -

            public datPosts(System.Int32 PostID)
            {
                SetDefaults();
                if (PostID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@PostID", PostID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostID)))
                                    _PostID = dR.GetInt32((int)Columns.ColumnNames.PostID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    _ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ParentID)))
                                    _ParentID = dR.GetInt32((int)Columns.ColumnNames.ParentID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SubjectLine)))
                                    _SubjectLine = dR.GetString((int)Columns.ColumnNames.SubjectLine);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostedDate)))
                                    _PostedDate = dR.GetDateTime((int)Columns.ColumnNames.PostedDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    _IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    _IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    _PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datPosts> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datPosts> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datPosts> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datPosts> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datPosts> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datPosts> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datPosts> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datPosts> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datPosts> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datPosts> returnValue = new List<datPosts>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datPosts MydatPosts = new datPosts();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostID)))
                                    MydatPosts.PostID = dR.GetInt32((int)Columns.ColumnNames.PostID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MydatPosts.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ParentID)))
                                    MydatPosts.ParentID = dR.GetInt32((int)Columns.ColumnNames.ParentID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SubjectLine)))
                                    MydatPosts.SubjectLine = dR.GetString((int)Columns.ColumnNames.SubjectLine);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostedDate)))
                                    MydatPosts.PostedDate = dR.GetDateTime((int)Columns.ColumnNames.PostedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatPosts.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    MydatPosts.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    MydatPosts.PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);


                                returnValue.Add(MydatPosts);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datPosts> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datPosts> returnValue = new List<datPosts>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datPosts MydatPosts = new datPosts();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostID)))
                                    MydatPosts.PostID = dR.GetInt32((int)Columns.ColumnNames.PostID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MydatPosts.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ParentID)))
                                    MydatPosts.ParentID = dR.GetInt32((int)Columns.ColumnNames.ParentID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SubjectLine)))
                                    MydatPosts.SubjectLine = dR.GetString((int)Columns.ColumnNames.SubjectLine);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PostedDate)))
                                    MydatPosts.PostedDate = dR.GetDateTime((int)Columns.ColumnNames.PostedDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    MydatPosts.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    MydatPosts.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PersonID)))
                                    MydatPosts.PersonID = dR.GetInt32((int)Columns.ColumnNames.PersonID);


                                returnValue.Add(MydatPosts);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datPosts MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.PostID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 PostID, System.Int32 ForumID, System.Int32 ParentID, System.String SubjectLine, System.DateTime PostedDate, System.Boolean IsActive, System.Boolean IsApproved, System.Int32 PersonID)
            {
                int ReturnValue = 0;
                if (PostID == 0)
                    ReturnValue = Insert(ForumID, ParentID, SubjectLine, PostedDate, IsActive, IsApproved, PersonID);
                else
                {
                    datPosts MyLib = new datPosts();

                    MyLib.PostID = PostID;

                    MyLib.ForumID = ForumID;

                    MyLib.ParentID = ParentID;

                    MyLib.SubjectLine = SubjectLine;

                    MyLib.PostedDate = PostedDate;

                    MyLib.IsActive = IsActive;

                    MyLib.IsApproved = IsApproved;

                    MyLib.PersonID = PersonID;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datPosts _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datPosts Old = new datPosts(_MyLib.PostID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PostID", _MyLib.PostID));

                        command.Parameters.Add(new SqlParameter("@ForumID", _MyLib.ForumID));

                        command.Parameters.Add(new SqlParameter("@ParentID", _MyLib.ParentID));

                        command.Parameters.Add(new SqlParameter("@SubjectLine", _MyLib.SubjectLine));

                        command.Parameters.Add(new SqlParameter("@PostedDate", _MyLib.PostedDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));

                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));

                        command.Parameters.Add(new SqlParameter("@PersonID", _MyLib.PersonID));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datPosts  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 PostID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PostID", PostID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datPosts> returnValue = new List<datPosts>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datPosts _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@ForumID", _MyLib.ForumID));
                        command.Parameters.Add(new SqlParameter("@ParentID", _MyLib.ParentID));
                        command.Parameters.Add(new SqlParameter("@SubjectLine", _MyLib.SubjectLine));
                        command.Parameters.Add(new SqlParameter("@PostedDate", _MyLib.PostedDate));
                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));
                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));
                        command.Parameters.Add(new SqlParameter("@PersonID", _MyLib.PersonID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 ForumID, System.Int32 ParentID, System.String SubjectLine, System.DateTime PostedDate, System.Boolean IsActive, System.Boolean IsApproved, System.Int32 PersonID)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@ForumID", ForumID));

                        command.Parameters.Add(new SqlParameter("@ParentID", ParentID));

                        command.Parameters.Add(new SqlParameter("@SubjectLine", SubjectLine));

                        command.Parameters.Add(new SqlParameter("@PostedDate", PostedDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", IsActive));

                        command.Parameters.Add(new SqlParameter("@IsApproved", IsApproved));

                        command.Parameters.Add(new SqlParameter("@PersonID", PersonID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datQuestionOptions"
        public partial class datQuestionOptions
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datQuestionOptions_";
            }


            #region  - Constructors -

            public datQuestionOptions(System.Int32 optionID)
            {
                SetDefaults();
                if (optionID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@optionID", optionID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    _optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    _questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionText)))
                                    _optionText = dR.GetString((int)Columns.ColumnNames.optionText);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    _displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.defaultOption)))
                                    _defaultOption = dR.GetInt32((int)Columns.ColumnNames.defaultOption);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isCorrect)))
                                    _isCorrect = dR.GetBoolean((int)Columns.ColumnNames.isCorrect);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datQuestionOptions> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datQuestionOptions> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datQuestionOptions> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datQuestionOptions> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datQuestionOptions> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datQuestionOptions> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datQuestionOptions> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datQuestionOptions> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datQuestionOptions> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datQuestionOptions> returnValue = new List<datQuestionOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datQuestionOptions MydatQuestionOptions = new datQuestionOptions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    MydatQuestionOptions.optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MydatQuestionOptions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionText)))
                                    MydatQuestionOptions.optionText = dR.GetString((int)Columns.ColumnNames.optionText);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    MydatQuestionOptions.displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.defaultOption)))
                                    MydatQuestionOptions.defaultOption = dR.GetInt32((int)Columns.ColumnNames.defaultOption);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isCorrect)))
                                    MydatQuestionOptions.isCorrect = dR.GetBoolean((int)Columns.ColumnNames.isCorrect);


                                returnValue.Add(MydatQuestionOptions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datQuestionOptions> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datQuestionOptions> returnValue = new List<datQuestionOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datQuestionOptions MydatQuestionOptions = new datQuestionOptions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionID)))
                                    MydatQuestionOptions.optionID = dR.GetInt32((int)Columns.ColumnNames.optionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MydatQuestionOptions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.optionText)))
                                    MydatQuestionOptions.optionText = dR.GetString((int)Columns.ColumnNames.optionText);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    MydatQuestionOptions.displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.defaultOption)))
                                    MydatQuestionOptions.defaultOption = dR.GetInt32((int)Columns.ColumnNames.defaultOption);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isCorrect)))
                                    MydatQuestionOptions.isCorrect = dR.GetBoolean((int)Columns.ColumnNames.isCorrect);


                                returnValue.Add(MydatQuestionOptions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datQuestionOptions MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.optionID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 optionID, System.Int32 questionID, System.String optionText, System.Int32 displayOrder, System.Int32 defaultOption, System.Boolean isCorrect)
            {
                int ReturnValue = 0;
                if (optionID == 0)
                    ReturnValue = Insert(questionID, optionText, displayOrder, defaultOption, isCorrect);
                else
                {
                    datQuestionOptions MyLib = new datQuestionOptions();

                    MyLib.optionID = optionID;

                    MyLib.questionID = questionID;

                    MyLib.optionText = optionText;

                    MyLib.displayOrder = displayOrder;

                    MyLib.defaultOption = defaultOption;

                    MyLib.isCorrect = isCorrect;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datQuestionOptions _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datQuestionOptions Old = new datQuestionOptions(_MyLib.optionID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@optionID", _MyLib.optionID));

                        command.Parameters.Add(new SqlParameter("@questionID", _MyLib.questionID));

                        command.Parameters.Add(new SqlParameter("@optionText", _MyLib.optionText));

                        command.Parameters.Add(new SqlParameter("@displayOrder", _MyLib.displayOrder));

                        command.Parameters.Add(new SqlParameter("@defaultOption", _MyLib.defaultOption));

                        command.Parameters.Add(new SqlParameter("@isCorrect", _MyLib.isCorrect));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datQuestionOptions  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 optionID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@optionID", optionID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datQuestionOptions> returnValue = new List<datQuestionOptions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datQuestionOptions _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@questionID", _MyLib.questionID));
                        command.Parameters.Add(new SqlParameter("@optionText", _MyLib.optionText));
                        command.Parameters.Add(new SqlParameter("@displayOrder", _MyLib.displayOrder));
                        command.Parameters.Add(new SqlParameter("@defaultOption", _MyLib.defaultOption));
                        command.Parameters.Add(new SqlParameter("@isCorrect", _MyLib.isCorrect));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 questionID, System.String optionText, System.Int32 displayOrder, System.Int32 defaultOption, System.Boolean isCorrect)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@questionID", questionID));

                        command.Parameters.Add(new SqlParameter("@optionText", optionText));

                        command.Parameters.Add(new SqlParameter("@displayOrder", displayOrder));

                        command.Parameters.Add(new SqlParameter("@defaultOption", defaultOption));

                        command.Parameters.Add(new SqlParameter("@isCorrect", isCorrect));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datSurveyQuestions"
        public partial class datSurveyQuestions
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datSurveyQuestions_";
            }


            #region  - Constructors -

            public datSurveyQuestions(System.Int32 questionID)
            {
                SetDefaults();
                if (questionID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@questionID", questionID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    _questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    _questionType = dR.GetString((int)Columns.ColumnNames.questionType);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionText)))
                                    _questionText = dR.GetString((int)Columns.ColumnNames.questionText);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasOtherOption)))
                                    _hasOtherOption = dR.GetBoolean((int)Columns.ColumnNames.hasOtherOption);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datSurveyQuestions> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datSurveyQuestions> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datSurveyQuestions> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datSurveyQuestions> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datSurveyQuestions> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datSurveyQuestions> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datSurveyQuestions> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datSurveyQuestions> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datSurveyQuestions> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datSurveyQuestions> returnValue = new List<datSurveyQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datSurveyQuestions MydatSurveyQuestions = new datSurveyQuestions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MydatSurveyQuestions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    MydatSurveyQuestions.questionType = dR.GetString((int)Columns.ColumnNames.questionType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionText)))
                                    MydatSurveyQuestions.questionText = dR.GetString((int)Columns.ColumnNames.questionText);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasOtherOption)))
                                    MydatSurveyQuestions.hasOtherOption = dR.GetBoolean((int)Columns.ColumnNames.hasOtherOption);


                                returnValue.Add(MydatSurveyQuestions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datSurveyQuestions> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datSurveyQuestions> returnValue = new List<datSurveyQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datSurveyQuestions MydatSurveyQuestions = new datSurveyQuestions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MydatSurveyQuestions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    MydatSurveyQuestions.questionType = dR.GetString((int)Columns.ColumnNames.questionType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionText)))
                                    MydatSurveyQuestions.questionText = dR.GetString((int)Columns.ColumnNames.questionText);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasOtherOption)))
                                    MydatSurveyQuestions.hasOtherOption = dR.GetBoolean((int)Columns.ColumnNames.hasOtherOption);


                                returnValue.Add(MydatSurveyQuestions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datSurveyQuestions MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.questionID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 questionID, System.String questionType, System.String questionText, System.Boolean hasOtherOption)
            {
                int ReturnValue = 0;
                if (questionID == 0)
                    ReturnValue = Insert(questionType, questionText, hasOtherOption);
                else
                {
                    datSurveyQuestions MyLib = new datSurveyQuestions();

                    MyLib.questionID = questionID;

                    MyLib.questionType = questionType;

                    MyLib.questionText = questionText;

                    MyLib.hasOtherOption = hasOtherOption;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datSurveyQuestions _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datSurveyQuestions Old = new datSurveyQuestions(_MyLib.questionID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@questionID", _MyLib.questionID));

                        command.Parameters.Add(new SqlParameter("@questionType", _MyLib.questionType));

                        command.Parameters.Add(new SqlParameter("@questionText", _MyLib.questionText));

                        command.Parameters.Add(new SqlParameter("@hasOtherOption", _MyLib.hasOtherOption));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datSurveyQuestions  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 questionID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@questionID", questionID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datSurveyQuestions> returnValue = new List<datSurveyQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datSurveyQuestions _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@questionType", _MyLib.questionType));
                        command.Parameters.Add(new SqlParameter("@questionText", _MyLib.questionText));
                        command.Parameters.Add(new SqlParameter("@hasOtherOption", _MyLib.hasOtherOption));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String questionType, System.String questionText, System.Boolean hasOtherOption)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@questionType", questionType));

                        command.Parameters.Add(new SqlParameter("@questionText", questionText));

                        command.Parameters.Add(new SqlParameter("@hasOtherOption", hasOtherOption));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class datSurveys"
        public partial class datSurveys
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_datSurveys_";
            }


            #region  - Constructors -

            public datSurveys(System.Int32 surveyID)
            {
                SetDefaults();
                if (surveyID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@surveyID", surveyID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    _surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyName)))
                                    _surveyName = dR.GetString((int)Columns.ColumnNames.surveyName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtEffective)))
                                    _dtEffective = dR.GetDateTime((int)Columns.ColumnNames.dtEffective);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtExpiry)))
                                    _dtExpiry = dR.GetDateTime((int)Columns.ColumnNames.dtExpiry);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.reqToPass)))
                                    _reqToPass = dR.GetInt32((int)Columns.ColumnNames.reqToPass);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<datSurveys> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<datSurveys> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datSurveys> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<datSurveys> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<datSurveys> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<datSurveys> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<datSurveys> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<datSurveys> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<datSurveys> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<datSurveys> returnValue = new List<datSurveys>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datSurveys MydatSurveys = new datSurveys();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    MydatSurveys.surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyName)))
                                    MydatSurveys.surveyName = dR.GetString((int)Columns.ColumnNames.surveyName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatSurveys.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtEffective)))
                                    MydatSurveys.dtEffective = dR.GetDateTime((int)Columns.ColumnNames.dtEffective);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtExpiry)))
                                    MydatSurveys.dtExpiry = dR.GetDateTime((int)Columns.ColumnNames.dtExpiry);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.reqToPass)))
                                    MydatSurveys.reqToPass = dR.GetInt32((int)Columns.ColumnNames.reqToPass);


                                returnValue.Add(MydatSurveys);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<datSurveys> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<datSurveys> returnValue = new List<datSurveys>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                datSurveys MydatSurveys = new datSurveys();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    MydatSurveys.surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyName)))
                                    MydatSurveys.surveyName = dR.GetString((int)Columns.ColumnNames.surveyName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MydatSurveys.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtEffective)))
                                    MydatSurveys.dtEffective = dR.GetDateTime((int)Columns.ColumnNames.dtEffective);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtExpiry)))
                                    MydatSurveys.dtExpiry = dR.GetDateTime((int)Columns.ColumnNames.dtExpiry);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.reqToPass)))
                                    MydatSurveys.reqToPass = dR.GetInt32((int)Columns.ColumnNames.reqToPass);


                                returnValue.Add(MydatSurveys);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(datSurveys MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.surveyID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 surveyID, System.String surveyName, System.Boolean isActive, System.DateTime dtEffective, System.DateTime dtExpiry, System.Int32 reqToPass)
            {
                int ReturnValue = 0;
                if (surveyID == 0)
                    ReturnValue = Insert(surveyName, isActive, dtEffective, dtExpiry, reqToPass);
                else
                {
                    datSurveys MyLib = new datSurveys();

                    MyLib.surveyID = surveyID;

                    MyLib.surveyName = surveyName;

                    MyLib.isActive = isActive;

                    MyLib.dtEffective = dtEffective;

                    MyLib.dtExpiry = dtExpiry;

                    MyLib.reqToPass = reqToPass;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(datSurveys _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    datSurveys Old = new datSurveys(_MyLib.surveyID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@surveyID", _MyLib.surveyID));

                        command.Parameters.Add(new SqlParameter("@surveyName", _MyLib.surveyName));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        command.Parameters.Add(new SqlParameter("@dtEffective", _MyLib.dtEffective));

                        command.Parameters.Add(new SqlParameter("@dtExpiry", _MyLib.dtExpiry));

                        command.Parameters.Add(new SqlParameter("@reqToPass", _MyLib.reqToPass));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE datSurveys  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 surveyID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@surveyID", surveyID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<datSurveys> returnValue = new List<datSurveys>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(datSurveys _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@surveyName", _MyLib.surveyName));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        command.Parameters.Add(new SqlParameter("@dtEffective", _MyLib.dtEffective));
                        command.Parameters.Add(new SqlParameter("@dtExpiry", _MyLib.dtExpiry));
                        command.Parameters.Add(new SqlParameter("@reqToPass", _MyLib.reqToPass));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String surveyName, System.Boolean isActive, System.DateTime dtEffective, System.DateTime dtExpiry, System.Int32 reqToPass)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@surveyName", surveyName));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));

                        command.Parameters.Add(new SqlParameter("@dtEffective", dtEffective));

                        command.Parameters.Add(new SqlParameter("@dtExpiry", dtExpiry));

                        command.Parameters.Add(new SqlParameter("@reqToPass", reqToPass));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class jncClassForum"
        public partial class jncClassForum
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_jncClassForum_";
            }


            #region  - Constructors -

            public jncClassForum(System.Int32 ItemID)
            {
                SetDefaults();
                if (ItemID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ItemID", ItemID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ItemID)))
                                    _ItemID = dR.GetInt32((int)Columns.ColumnNames.ItemID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    _ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    _ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<jncClassForum> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<jncClassForum> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncClassForum> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncClassForum> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<jncClassForum> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<jncClassForum> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<jncClassForum> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<jncClassForum> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<jncClassForum> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<jncClassForum> returnValue = new List<jncClassForum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncClassForum MyjncClassForum = new jncClassForum();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ItemID)))
                                    MyjncClassForum.ItemID = dR.GetInt32((int)Columns.ColumnNames.ItemID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MyjncClassForum.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncClassForum.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);


                                returnValue.Add(MyjncClassForum);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<jncClassForum> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<jncClassForum> returnValue = new List<jncClassForum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncClassForum MyjncClassForum = new jncClassForum();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ItemID)))
                                    MyjncClassForum.ItemID = dR.GetInt32((int)Columns.ColumnNames.ItemID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ForumID)))
                                    MyjncClassForum.ForumID = dR.GetInt32((int)Columns.ColumnNames.ForumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncClassForum.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);


                                returnValue.Add(MyjncClassForum);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(jncClassForum MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ItemID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ItemID, System.Int32 ForumID, System.String ClassCode)
            {
                int ReturnValue = 0;
                if (ItemID == 0)
                    ReturnValue = Insert(ForumID, ClassCode);
                else
                {
                    jncClassForum MyLib = new jncClassForum();

                    MyLib.ItemID = ItemID;

                    MyLib.ForumID = ForumID;

                    MyLib.ClassCode = ClassCode;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(jncClassForum _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    jncClassForum Old = new jncClassForum(_MyLib.ItemID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ItemID", _MyLib.ItemID));

                        command.Parameters.Add(new SqlParameter("@ForumID", _MyLib.ForumID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE jncClassForum  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ItemID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ItemID", ItemID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<jncClassForum> returnValue = new List<jncClassForum>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(jncClassForum _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@ForumID", _MyLib.ForumID));
                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 ForumID, System.String ClassCode)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@ForumID", ForumID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", ClassCode));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class jncClassStudents"
        public partial class jncClassStudents
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_jncClassStudents_";
            }


            #region  - Constructors -

            public jncClassStudents(System.Int32 StudentProgressID)
            {
                SetDefaults();
                if (StudentProgressID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@StudentProgressID", StudentProgressID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StudentProgressID)))
                                    _StudentProgressID = dR.GetInt32((int)Columns.ColumnNames.StudentProgressID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    _ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    _ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Marks)))
                                    _Marks = dR.GetByte((int)Columns.ColumnNames.Marks);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasStarted)))
                                    _hasStarted = dR.GetBoolean((int)Columns.ColumnNames.hasStarted);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasCompleted)))
                                    _hasCompleted = dR.GetBoolean((int)Columns.ColumnNames.hasCompleted);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<jncClassStudents> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<jncClassStudents> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncClassStudents> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncClassStudents> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<jncClassStudents> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<jncClassStudents> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<jncClassStudents> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<jncClassStudents> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<jncClassStudents> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<jncClassStudents> returnValue = new List<jncClassStudents>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncClassStudents MyjncClassStudents = new jncClassStudents();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StudentProgressID)))
                                    MyjncClassStudents.StudentProgressID = dR.GetInt32((int)Columns.ColumnNames.StudentProgressID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    MyjncClassStudents.ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncClassStudents.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Marks)))
                                    MyjncClassStudents.Marks = dR.GetByte((int)Columns.ColumnNames.Marks);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasStarted)))
                                    MyjncClassStudents.hasStarted = dR.GetBoolean((int)Columns.ColumnNames.hasStarted);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasCompleted)))
                                    MyjncClassStudents.hasCompleted = dR.GetBoolean((int)Columns.ColumnNames.hasCompleted);


                                returnValue.Add(MyjncClassStudents);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<jncClassStudents> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<jncClassStudents> returnValue = new List<jncClassStudents>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncClassStudents MyjncClassStudents = new jncClassStudents();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.StudentProgressID)))
                                    MyjncClassStudents.StudentProgressID = dR.GetInt32((int)Columns.ColumnNames.StudentProgressID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClientID)))
                                    MyjncClassStudents.ClientID = dR.GetInt32((int)Columns.ColumnNames.ClientID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncClassStudents.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Marks)))
                                    MyjncClassStudents.Marks = dR.GetByte((int)Columns.ColumnNames.Marks);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasStarted)))
                                    MyjncClassStudents.hasStarted = dR.GetBoolean((int)Columns.ColumnNames.hasStarted);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.hasCompleted)))
                                    MyjncClassStudents.hasCompleted = dR.GetBoolean((int)Columns.ColumnNames.hasCompleted);


                                returnValue.Add(MyjncClassStudents);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(jncClassStudents MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.StudentProgressID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 StudentProgressID, System.Int32 ClientID, System.String ClassCode, System.Int32 Marks, System.Boolean hasStarted, System.Boolean hasCompleted)
            {
                int ReturnValue = 0;
                if (StudentProgressID == 0)
                    ReturnValue = Insert(ClientID, ClassCode, Marks, hasStarted, hasCompleted);
                else
                {
                    jncClassStudents MyLib = new jncClassStudents();

                    MyLib.StudentProgressID = StudentProgressID;

                    MyLib.ClientID = ClientID;

                    MyLib.ClassCode = ClassCode;

                    MyLib.Marks = Marks;

                    MyLib.hasStarted = hasStarted;

                    MyLib.hasCompleted = hasCompleted;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(jncClassStudents _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    jncClassStudents Old = new jncClassStudents(_MyLib.StudentProgressID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@StudentProgressID", _MyLib.StudentProgressID));

                        command.Parameters.Add(new SqlParameter("@ClientID", _MyLib.ClientID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));

                        command.Parameters.Add(new SqlParameter("@Marks", _MyLib.Marks));

                        command.Parameters.Add(new SqlParameter("@hasStarted", _MyLib.hasStarted));

                        command.Parameters.Add(new SqlParameter("@hasCompleted", _MyLib.hasCompleted));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE jncClassStudents  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 StudentProgressID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@StudentProgressID", StudentProgressID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<jncClassStudents> returnValue = new List<jncClassStudents>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(jncClassStudents _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@ClientID", _MyLib.ClientID));
                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));
                        command.Parameters.Add(new SqlParameter("@Marks", _MyLib.Marks));
                        command.Parameters.Add(new SqlParameter("@hasStarted", _MyLib.hasStarted));
                        command.Parameters.Add(new SqlParameter("@hasCompleted", _MyLib.hasCompleted));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 ClientID, System.String ClassCode, System.Int32 Marks, System.Boolean hasStarted, System.Boolean hasCompleted)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@ClientID", ClientID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", ClassCode));

                        command.Parameters.Add(new SqlParameter("@Marks", Marks));

                        command.Parameters.Add(new SqlParameter("@hasStarted", hasStarted));

                        command.Parameters.Add(new SqlParameter("@hasCompleted", hasCompleted));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class jncCoachClasses"
        public partial class jncCoachClasses
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_jncCoachClasses_";
            }


            #region  - Constructors -

            public jncCoachClasses(System.Int32 TeachingID)
            {
                SetDefaults();
                if (TeachingID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@TeachingID", TeachingID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.TeachingID)))
                                    _TeachingID = dR.GetInt32((int)Columns.ColumnNames.TeachingID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    _CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    _ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Role)))
                                    _Role = dR.GetString((int)Columns.ColumnNames.Role);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<jncCoachClasses> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<jncCoachClasses> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncCoachClasses> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncCoachClasses> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<jncCoachClasses> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<jncCoachClasses> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<jncCoachClasses> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<jncCoachClasses> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<jncCoachClasses> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<jncCoachClasses> returnValue = new List<jncCoachClasses>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncCoachClasses MyjncCoachClasses = new jncCoachClasses();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.TeachingID)))
                                    MyjncCoachClasses.TeachingID = dR.GetInt32((int)Columns.ColumnNames.TeachingID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    MyjncCoachClasses.CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncCoachClasses.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Role)))
                                    MyjncCoachClasses.Role = dR.GetString((int)Columns.ColumnNames.Role);


                                returnValue.Add(MyjncCoachClasses);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<jncCoachClasses> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<jncCoachClasses> returnValue = new List<jncCoachClasses>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncCoachClasses MyjncCoachClasses = new jncCoachClasses();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.TeachingID)))
                                    MyjncCoachClasses.TeachingID = dR.GetInt32((int)Columns.ColumnNames.TeachingID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CoachID)))
                                    MyjncCoachClasses.CoachID = dR.GetInt32((int)Columns.ColumnNames.CoachID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ClassCode)))
                                    MyjncCoachClasses.ClassCode = dR.GetString((int)Columns.ColumnNames.ClassCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Role)))
                                    MyjncCoachClasses.Role = dR.GetString((int)Columns.ColumnNames.Role);


                                returnValue.Add(MyjncCoachClasses);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(jncCoachClasses MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.TeachingID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 TeachingID, System.Int32 CoachID, System.String ClassCode, System.String Role)
            {
                int ReturnValue = 0;
                if (TeachingID == 0)
                    ReturnValue = Insert(CoachID, ClassCode, Role);
                else
                {
                    jncCoachClasses MyLib = new jncCoachClasses();

                    MyLib.TeachingID = TeachingID;

                    MyLib.CoachID = CoachID;

                    MyLib.ClassCode = ClassCode;

                    MyLib.Role = Role;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(jncCoachClasses _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    jncCoachClasses Old = new jncCoachClasses(_MyLib.TeachingID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TeachingID", _MyLib.TeachingID));

                        command.Parameters.Add(new SqlParameter("@CoachID", _MyLib.CoachID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));

                        command.Parameters.Add(new SqlParameter("@Role", _MyLib.Role));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE jncCoachClasses  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 TeachingID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TeachingID", TeachingID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<jncCoachClasses> returnValue = new List<jncCoachClasses>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(jncCoachClasses _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CoachID", _MyLib.CoachID));
                        command.Parameters.Add(new SqlParameter("@ClassCode", _MyLib.ClassCode));
                        command.Parameters.Add(new SqlParameter("@Role", _MyLib.Role));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 CoachID, System.String ClassCode, System.String Role)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CoachID", CoachID));

                        command.Parameters.Add(new SqlParameter("@ClassCode", ClassCode));

                        command.Parameters.Add(new SqlParameter("@Role", Role));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class jncCurriculumSection"
        public partial class jncCurriculumSection
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_jncCurriculumSection_";
            }


            #region  - Constructors -

            public jncCurriculumSection(System.Int32 SectionID)
            {
                SetDefaults();
                if (SectionID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@SectionID", SectionID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SectionID)))
                                    _SectionID = dR.GetInt32((int)Columns.ColumnNames.SectionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    _CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    _PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<jncCurriculumSection> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<jncCurriculumSection> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncCurriculumSection> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncCurriculumSection> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<jncCurriculumSection> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<jncCurriculumSection> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<jncCurriculumSection> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<jncCurriculumSection> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<jncCurriculumSection> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<jncCurriculumSection> returnValue = new List<jncCurriculumSection>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncCurriculumSection MyjncCurriculumSection = new jncCurriculumSection();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SectionID)))
                                    MyjncCurriculumSection.SectionID = dR.GetInt32((int)Columns.ColumnNames.SectionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    MyjncCurriculumSection.CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    MyjncCurriculumSection.PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);


                                returnValue.Add(MyjncCurriculumSection);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<jncCurriculumSection> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<jncCurriculumSection> returnValue = new List<jncCurriculumSection>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncCurriculumSection MyjncCurriculumSection = new jncCurriculumSection();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.SectionID)))
                                    MyjncCurriculumSection.SectionID = dR.GetInt32((int)Columns.ColumnNames.SectionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CurriculumID)))
                                    MyjncCurriculumSection.CurriculumID = dR.GetInt32((int)Columns.ColumnNames.CurriculumID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    MyjncCurriculumSection.PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);


                                returnValue.Add(MyjncCurriculumSection);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(jncCurriculumSection MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.SectionID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 SectionID, System.Int32 CurriculumID, System.Int32 PageID)
            {
                int ReturnValue = 0;
                if (SectionID == 0)
                    ReturnValue = Insert(CurriculumID, PageID);
                else
                {
                    jncCurriculumSection MyLib = new jncCurriculumSection();

                    MyLib.SectionID = SectionID;

                    MyLib.CurriculumID = CurriculumID;

                    MyLib.PageID = PageID;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(jncCurriculumSection _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    jncCurriculumSection Old = new jncCurriculumSection(_MyLib.SectionID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@SectionID", _MyLib.SectionID));

                        command.Parameters.Add(new SqlParameter("@CurriculumID", _MyLib.CurriculumID));

                        command.Parameters.Add(new SqlParameter("@PageID", _MyLib.PageID));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE jncCurriculumSection  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 SectionID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@SectionID", SectionID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<jncCurriculumSection> returnValue = new List<jncCurriculumSection>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(jncCurriculumSection _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CurriculumID", _MyLib.CurriculumID));
                        command.Parameters.Add(new SqlParameter("@PageID", _MyLib.PageID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 CurriculumID, System.Int32 PageID)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CurriculumID", CurriculumID));

                        command.Parameters.Add(new SqlParameter("@PageID", PageID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class jncUsersToPeople"
        public partial class jncUsersToPeople
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_jncUsersToPeople_";
            }


            #region  - Constructors -

            public jncUsersToPeople(System.String id)
            {
                SetDefaults();
                if (id != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@id", id));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.id)))
                                    _id = dR.GetString((int)Columns.ColumnNames.id);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.personID)))
                                    _personID = dR.GetInt32((int)Columns.ColumnNames.personID);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<jncUsersToPeople> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<jncUsersToPeople> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncUsersToPeople> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<jncUsersToPeople> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<jncUsersToPeople> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<jncUsersToPeople> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<jncUsersToPeople> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<jncUsersToPeople> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<jncUsersToPeople> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<jncUsersToPeople> returnValue = new List<jncUsersToPeople>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncUsersToPeople MyjncUsersToPeople = new jncUsersToPeople();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.id)))
                                    MyjncUsersToPeople.id = dR.GetString((int)Columns.ColumnNames.id);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.personID)))
                                    MyjncUsersToPeople.personID = dR.GetInt32((int)Columns.ColumnNames.personID);


                                returnValue.Add(MyjncUsersToPeople);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<jncUsersToPeople> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<jncUsersToPeople> returnValue = new List<jncUsersToPeople>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                jncUsersToPeople MyjncUsersToPeople = new jncUsersToPeople();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.id)))
                                    MyjncUsersToPeople.id = dR.GetString((int)Columns.ColumnNames.id);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.personID)))
                                    MyjncUsersToPeople.personID = dR.GetInt32((int)Columns.ColumnNames.personID);


                                returnValue.Add(MyjncUsersToPeople);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(jncUsersToPeople MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.id != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String id, System.Int32 personID)
            {
                int ReturnValue = 0;
                if (id != string.Empty)
                    ReturnValue = Insert(personID);
                else
                {
                    jncUsersToPeople MyLib = new jncUsersToPeople();

                    MyLib.id = id;

                    MyLib.personID = personID;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(jncUsersToPeople _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    jncUsersToPeople Old = new jncUsersToPeople(_MyLib.id);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@id", _MyLib.id));

                        command.Parameters.Add(new SqlParameter("@personID", _MyLib.personID));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE jncUsersToPeople  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String id)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@id", id));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<jncUsersToPeople> returnValue = new List<jncUsersToPeople>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(jncUsersToPeople _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@personID", _MyLib.personID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 personID)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@personID", personID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class linkSurveysQuestions"
        public partial class linkSurveysQuestions
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_linkSurveysQuestions_";
            }


            #region  - Constructors -

            public linkSurveysQuestions(System.Int32 surveyQuestionID)
            {
                SetDefaults();
                if (surveyQuestionID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@surveyQuestionID", surveyQuestionID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    _surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    _surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    _questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    _displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<linkSurveysQuestions> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<linkSurveysQuestions> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<linkSurveysQuestions> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<linkSurveysQuestions> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<linkSurveysQuestions> SelectWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<linkSurveysQuestions> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<linkSurveysQuestions> SelectAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<linkSurveysQuestions> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<linkSurveysQuestions> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<linkSurveysQuestions> returnValue = new List<linkSurveysQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                linkSurveysQuestions MylinkSurveysQuestions = new linkSurveysQuestions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    MylinkSurveysQuestions.surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    MylinkSurveysQuestions.surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MylinkSurveysQuestions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    MylinkSurveysQuestions.displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);


                                returnValue.Add(MylinkSurveysQuestions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<linkSurveysQuestions> SelectRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<linkSurveysQuestions> returnValue = new List<linkSurveysQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                linkSurveysQuestions MylinkSurveysQuestions = new linkSurveysQuestions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyQuestionID)))
                                    MylinkSurveysQuestions.surveyQuestionID = dR.GetInt32((int)Columns.ColumnNames.surveyQuestionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.surveyID)))
                                    MylinkSurveysQuestions.surveyID = dR.GetInt32((int)Columns.ColumnNames.surveyID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionID)))
                                    MylinkSurveysQuestions.questionID = dR.GetInt32((int)Columns.ColumnNames.questionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.displayOrder)))
                                    MylinkSurveysQuestions.displayOrder = dR.GetInt32((int)Columns.ColumnNames.displayOrder);


                                returnValue.Add(MylinkSurveysQuestions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(linkSurveysQuestions MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.surveyQuestionID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 surveyQuestionID, System.Int32 surveyID, System.Int32 questionID, System.Int32 displayOrder)
            {
                int ReturnValue = 0;
                if (surveyQuestionID == 0)
                    ReturnValue = Insert(surveyID, questionID, displayOrder);
                else
                {
                    linkSurveysQuestions MyLib = new linkSurveysQuestions();

                    MyLib.surveyQuestionID = surveyQuestionID;

                    MyLib.surveyID = surveyID;

                    MyLib.questionID = questionID;

                    MyLib.displayOrder = displayOrder;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(linkSurveysQuestions _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    linkSurveysQuestions Old = new linkSurveysQuestions(_MyLib.surveyQuestionID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@surveyQuestionID", _MyLib.surveyQuestionID));

                        command.Parameters.Add(new SqlParameter("@surveyID", _MyLib.surveyID));

                        command.Parameters.Add(new SqlParameter("@questionID", _MyLib.questionID));

                        command.Parameters.Add(new SqlParameter("@displayOrder", _MyLib.displayOrder));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE linkSurveysQuestions  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 surveyQuestionID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@surveyQuestionID", surveyQuestionID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<linkSurveysQuestions> returnValue = new List<linkSurveysQuestions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(linkSurveysQuestions _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@surveyID", _MyLib.surveyID));
                        command.Parameters.Add(new SqlParameter("@questionID", _MyLib.questionID));
                        command.Parameters.Add(new SqlParameter("@displayOrder", _MyLib.displayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 surveyID, System.Int32 questionID, System.Int32 displayOrder)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@surveyID", surveyID));

                        command.Parameters.Add(new SqlParameter("@questionID", questionID));

                        command.Parameters.Add(new SqlParameter("@displayOrder", displayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpCountry"
        public partial class lkpCountry
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpCountry_";
            }


            #region  - Constructors -

            public lkpCountry(System.String CountryID)
            {
                SetDefaults();
                if (CountryID != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@CountryID", CountryID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    _CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryName)))
                                    _CountryName = dR.GetString((int)Columns.ColumnNames.CountryName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    _DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpCountry> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpCountry> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpCountry> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpCountry> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpCountry> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpCountry> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpCountry> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpCountry> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpCountry> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpCountry> returnValue = new List<lkpCountry>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpCountry MylkpCountry = new lkpCountry();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    MylkpCountry.CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryName)))
                                    MylkpCountry.CountryName = dR.GetString((int)Columns.ColumnNames.CountryName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpCountry.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpCountry);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpCountry> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpCountry> returnValue = new List<lkpCountry>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpCountry MylkpCountry = new lkpCountry();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    MylkpCountry.CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryName)))
                                    MylkpCountry.CountryName = dR.GetString((int)Columns.ColumnNames.CountryName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpCountry.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpCountry);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpCountry MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.CountryID != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String CountryID, System.String CountryName, System.Int32 DisplayOrder)
            {
                int ReturnValue = 0;
                if (CountryID != string.Empty)
                    ReturnValue = Insert(CountryName, DisplayOrder);
                else
                {
                    lkpCountry MyLib = new lkpCountry();

                    MyLib.CountryID = CountryID;

                    MyLib.CountryName = CountryName;

                    MyLib.DisplayOrder = DisplayOrder;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpCountry _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpCountry Old = new lkpCountry(_MyLib.CountryID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CountryID", _MyLib.CountryID));

                        command.Parameters.Add(new SqlParameter("@CountryName", _MyLib.CountryName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpCountry  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String CountryID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CountryID", CountryID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpCountry> returnValue = new List<lkpCountry>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpCountry _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@CountryName", _MyLib.CountryName));
                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String CountryName, System.Int32 DisplayOrder)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@CountryName", CountryName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpDesignation"
        public partial class lkpDesignation
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpDesignation_";
            }


            #region  - Constructors -

            public lkpDesignation(System.String DesignationID)
            {
                SetDefaults();
                if (DesignationID != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@DesignationID", DesignationID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    _DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationName)))
                                    _DesignationName = dR.GetString((int)Columns.ColumnNames.DesignationName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    _DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpDesignation> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpDesignation> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpDesignation> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpDesignation> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpDesignation> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpDesignation> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpDesignation> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpDesignation> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpDesignation> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpDesignation> returnValue = new List<lkpDesignation>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpDesignation MylkpDesignation = new lkpDesignation();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    MylkpDesignation.DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationName)))
                                    MylkpDesignation.DesignationName = dR.GetString((int)Columns.ColumnNames.DesignationName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpDesignation.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpDesignation);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpDesignation> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpDesignation> returnValue = new List<lkpDesignation>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpDesignation MylkpDesignation = new lkpDesignation();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationID)))
                                    MylkpDesignation.DesignationID = dR.GetString((int)Columns.ColumnNames.DesignationID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DesignationName)))
                                    MylkpDesignation.DesignationName = dR.GetString((int)Columns.ColumnNames.DesignationName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpDesignation.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpDesignation);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpDesignation MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.DesignationID != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String DesignationID, System.String DesignationName, System.Int32 DisplayOrder)
            {
                int ReturnValue = 0;
                if (DesignationID != string.Empty)
                    ReturnValue = Insert(DesignationName, DisplayOrder);
                else
                {
                    lkpDesignation MyLib = new lkpDesignation();

                    MyLib.DesignationID = DesignationID;

                    MyLib.DesignationName = DesignationName;

                    MyLib.DisplayOrder = DisplayOrder;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpDesignation _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpDesignation Old = new lkpDesignation(_MyLib.DesignationID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@DesignationID", _MyLib.DesignationID));

                        command.Parameters.Add(new SqlParameter("@DesignationName", _MyLib.DesignationName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpDesignation  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String DesignationID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@DesignationID", DesignationID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpDesignation> returnValue = new List<lkpDesignation>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpDesignation _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@DesignationName", _MyLib.DesignationName));
                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String DesignationName, System.Int32 DisplayOrder)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@DesignationName", DesignationName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpGender"
        public partial class lkpGender
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpGender_";
            }


            #region  - Constructors -

            public lkpGender(System.String GenderID)
            {
                SetDefaults();
                if (GenderID != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@GenderID", GenderID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderID)))
                                    _GenderID = dR.GetString((int)Columns.ColumnNames.GenderID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderName)))
                                    _GenderName = dR.GetString((int)Columns.ColumnNames.GenderName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    _DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpGender> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpGender> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpGender> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpGender> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpGender> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpGender> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpGender> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpGender> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpGender> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpGender> returnValue = new List<lkpGender>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpGender MylkpGender = new lkpGender();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderID)))
                                    MylkpGender.GenderID = dR.GetString((int)Columns.ColumnNames.GenderID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderName)))
                                    MylkpGender.GenderName = dR.GetString((int)Columns.ColumnNames.GenderName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpGender.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpGender);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpGender> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpGender> returnValue = new List<lkpGender>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpGender MylkpGender = new lkpGender();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderID)))
                                    MylkpGender.GenderID = dR.GetString((int)Columns.ColumnNames.GenderID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.GenderName)))
                                    MylkpGender.GenderName = dR.GetString((int)Columns.ColumnNames.GenderName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.DisplayOrder)))
                                    MylkpGender.DisplayOrder = dR.GetInt32((int)Columns.ColumnNames.DisplayOrder);


                                returnValue.Add(MylkpGender);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpGender MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.GenderID != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String GenderID, System.String GenderName, System.Int32 DisplayOrder)
            {
                int ReturnValue = 0;
                if (GenderID != string.Empty)
                    ReturnValue = Insert(GenderName, DisplayOrder);
                else
                {
                    lkpGender MyLib = new lkpGender();

                    MyLib.GenderID = GenderID;

                    MyLib.GenderName = GenderName;

                    MyLib.DisplayOrder = DisplayOrder;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpGender _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpGender Old = new lkpGender(_MyLib.GenderID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@GenderID", _MyLib.GenderID));

                        command.Parameters.Add(new SqlParameter("@GenderName", _MyLib.GenderName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpGender  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String GenderID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@GenderID", GenderID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpGender> returnValue = new List<lkpGender>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpGender _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@GenderName", _MyLib.GenderName));
                        command.Parameters.Add(new SqlParameter("@DisplayOrder", _MyLib.DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String GenderName, System.Int32 DisplayOrder)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@GenderName", GenderName));

                        command.Parameters.Add(new SqlParameter("@DisplayOrder", DisplayOrder));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpProvinces"
        public partial class lkpProvinces
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpProvinces_";
            }


            #region  - Constructors -

            public lkpProvinces(System.String ProvinceCode)
            {
                SetDefaults();
                if (ProvinceCode != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ProvinceCode", ProvinceCode));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceCode)))
                                    _ProvinceCode = dR.GetString((int)Columns.ColumnNames.ProvinceCode);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceName)))
                                    _ProvinceName = dR.GetString((int)Columns.ColumnNames.ProvinceName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    _CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpProvinces> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpProvinces> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpProvinces> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpProvinces> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpProvinces> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpProvinces> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpProvinces> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpProvinces> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpProvinces> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpProvinces> returnValue = new List<lkpProvinces>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpProvinces MylkpProvinces = new lkpProvinces();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceCode)))
                                    MylkpProvinces.ProvinceCode = dR.GetString((int)Columns.ColumnNames.ProvinceCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceName)))
                                    MylkpProvinces.ProvinceName = dR.GetString((int)Columns.ColumnNames.ProvinceName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    MylkpProvinces.CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);


                                returnValue.Add(MylkpProvinces);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpProvinces> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpProvinces> returnValue = new List<lkpProvinces>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpProvinces MylkpProvinces = new lkpProvinces();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceCode)))
                                    MylkpProvinces.ProvinceCode = dR.GetString((int)Columns.ColumnNames.ProvinceCode);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ProvinceName)))
                                    MylkpProvinces.ProvinceName = dR.GetString((int)Columns.ColumnNames.ProvinceName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.CountryID)))
                                    MylkpProvinces.CountryID = dR.GetString((int)Columns.ColumnNames.CountryID);


                                returnValue.Add(MylkpProvinces);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpProvinces MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ProvinceCode != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String ProvinceCode, System.String ProvinceName, System.String CountryID)
            {
                int ReturnValue = 0;
                if (ProvinceCode != string.Empty)
                    ReturnValue = Insert(ProvinceName, CountryID);
                else
                {
                    lkpProvinces MyLib = new lkpProvinces();

                    MyLib.ProvinceCode = ProvinceCode;

                    MyLib.ProvinceName = ProvinceName;

                    MyLib.CountryID = CountryID;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpProvinces _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpProvinces Old = new lkpProvinces(_MyLib.ProvinceCode);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ProvinceCode", _MyLib.ProvinceCode));

                        command.Parameters.Add(new SqlParameter("@ProvinceName", _MyLib.ProvinceName));

                        command.Parameters.Add(new SqlParameter("@CountryID", _MyLib.CountryID));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpProvinces  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String ProvinceCode)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ProvinceCode", ProvinceCode));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpProvinces> returnValue = new List<lkpProvinces>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpProvinces _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@ProvinceName", _MyLib.ProvinceName));
                        command.Parameters.Add(new SqlParameter("@CountryID", _MyLib.CountryID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String ProvinceName, System.String CountryID)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@ProvinceName", ProvinceName));

                        command.Parameters.Add(new SqlParameter("@CountryID", CountryID));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpSocialMedia"
        public partial class lkpSocialMedia
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpSocialMedia_";
            }


            #region  - Constructors -

            public lkpSocialMedia(System.Int32 smID)
            {
                SetDefaults();
                if (smID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@smID", smID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smID)))
                                    _smID = dR.GetInt32((int)Columns.ColumnNames.smID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smName)))
                                    _smName = dR.GetString((int)Columns.ColumnNames.smName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smIconURL)))
                                    _smIconURL = dR.GetString((int)Columns.ColumnNames.smIconURL);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpSocialMedia> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpSocialMedia> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpSocialMedia> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpSocialMedia> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpSocialMedia> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpSocialMedia> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpSocialMedia> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpSocialMedia> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpSocialMedia> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpSocialMedia> returnValue = new List<lkpSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpSocialMedia MylkpSocialMedia = new lkpSocialMedia();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smID)))
                                    MylkpSocialMedia.smID = dR.GetInt32((int)Columns.ColumnNames.smID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smName)))
                                    MylkpSocialMedia.smName = dR.GetString((int)Columns.ColumnNames.smName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smIconURL)))
                                    MylkpSocialMedia.smIconURL = dR.GetString((int)Columns.ColumnNames.smIconURL);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MylkpSocialMedia.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MylkpSocialMedia);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpSocialMedia> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpSocialMedia> returnValue = new List<lkpSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpSocialMedia MylkpSocialMedia = new lkpSocialMedia();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smID)))
                                    MylkpSocialMedia.smID = dR.GetInt32((int)Columns.ColumnNames.smID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smName)))
                                    MylkpSocialMedia.smName = dR.GetString((int)Columns.ColumnNames.smName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.smIconURL)))
                                    MylkpSocialMedia.smIconURL = dR.GetString((int)Columns.ColumnNames.smIconURL);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MylkpSocialMedia.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MylkpSocialMedia);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpSocialMedia MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.smID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 smID, System.String smName, System.String smIconURL, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (smID == 0)
                    ReturnValue = Insert(smName, smIconURL, isActive);
                else
                {
                    lkpSocialMedia MyLib = new lkpSocialMedia();

                    MyLib.smID = smID;

                    MyLib.smName = smName;

                    MyLib.smIconURL = smIconURL;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpSocialMedia _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpSocialMedia Old = new lkpSocialMedia(_MyLib.smID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@smID", _MyLib.smID));

                        command.Parameters.Add(new SqlParameter("@smName", _MyLib.smName));

                        command.Parameters.Add(new SqlParameter("@smIconURL", _MyLib.smIconURL));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpSocialMedia  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 smID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@smID", smID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpSocialMedia> returnValue = new List<lkpSocialMedia>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpSocialMedia _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@smName", _MyLib.smName));
                        command.Parameters.Add(new SqlParameter("@smIconURL", _MyLib.smIconURL));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String smName, System.String smIconURL, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@smName", smName));

                        command.Parameters.Add(new SqlParameter("@smIconURL", smIconURL));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class lkpSurveyQuestionTypes"
        public partial class lkpSurveyQuestionTypes
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_lkpSurveyQuestionTypes_";
            }


            #region  - Constructors -

            public lkpSurveyQuestionTypes(System.String questionType)
            {
                SetDefaults();
                if (questionType != string.Empty)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@questionType", questionType));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    _questionType = dR.GetString((int)Columns.ColumnNames.questionType);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.qtDescription)))
                                    _qtDescription = dR.GetString((int)Columns.ColumnNames.qtDescription);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<lkpSurveyQuestionTypes> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<lkpSurveyQuestionTypes> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpSurveyQuestionTypes> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<lkpSurveyQuestionTypes> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<lkpSurveyQuestionTypes> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<lkpSurveyQuestionTypes> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<lkpSurveyQuestionTypes> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<lkpSurveyQuestionTypes> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<lkpSurveyQuestionTypes> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<lkpSurveyQuestionTypes> returnValue = new List<lkpSurveyQuestionTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpSurveyQuestionTypes MylkpSurveyQuestionTypes = new lkpSurveyQuestionTypes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    MylkpSurveyQuestionTypes.questionType = dR.GetString((int)Columns.ColumnNames.questionType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.qtDescription)))
                                    MylkpSurveyQuestionTypes.qtDescription = dR.GetString((int)Columns.ColumnNames.qtDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MylkpSurveyQuestionTypes.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MylkpSurveyQuestionTypes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<lkpSurveyQuestionTypes> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<lkpSurveyQuestionTypes> returnValue = new List<lkpSurveyQuestionTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                lkpSurveyQuestionTypes MylkpSurveyQuestionTypes = new lkpSurveyQuestionTypes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.questionType)))
                                    MylkpSurveyQuestionTypes.questionType = dR.GetString((int)Columns.ColumnNames.questionType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.qtDescription)))
                                    MylkpSurveyQuestionTypes.qtDescription = dR.GetString((int)Columns.ColumnNames.qtDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    MylkpSurveyQuestionTypes.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(MylkpSurveyQuestionTypes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.String> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.String> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.String> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.String> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.String> returnValue = new List<System.String>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetString(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(lkpSurveyQuestionTypes MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.questionType != string.Empty)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.String questionType, System.String qtDescription, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (questionType != string.Empty)
                    ReturnValue = Insert(qtDescription, isActive);
                else
                {
                    lkpSurveyQuestionTypes MyLib = new lkpSurveyQuestionTypes();

                    MyLib.questionType = questionType;

                    MyLib.qtDescription = qtDescription;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(lkpSurveyQuestionTypes _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    lkpSurveyQuestionTypes Old = new lkpSurveyQuestionTypes(_MyLib.questionType);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@questionType", _MyLib.questionType));

                        command.Parameters.Add(new SqlParameter("@qtDescription", _MyLib.qtDescription));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE lkpSurveyQuestionTypes  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.String questionType)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@questionType", questionType));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<lkpSurveyQuestionTypes> returnValue = new List<lkpSurveyQuestionTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(lkpSurveyQuestionTypes _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@qtDescription", _MyLib.qtDescription));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String qtDescription, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@qtDescription", qtDescription));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class ts_Pages"
        public partial class ts_Pages
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_ts_Pages_";
            }


            #region  - Constructors -

            public ts_Pages(System.Int32 ID)
            {
                SetDefaults();
                if (ID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ID", ID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    _ID = dR.GetInt32((int)Columns.ColumnNames.ID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.parentID)))
                                    _parentID = dR.GetInt32((int)Columns.ColumnNames.parentID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageTitle)))
                                    _pageTitle = dR.GetString((int)Columns.ColumnNames.pageTitle);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageName)))
                                    _pageName = dR.GetString((int)Columns.ColumnNames.pageName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSystemRequiredPage)))
                                    _IsSystemRequiredPage = dR.GetBoolean((int)Columns.ColumnNames.IsSystemRequiredPage);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsDefault)))
                                    _IsDefault = dR.GetBoolean((int)Columns.ColumnNames.IsDefault);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    _ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    _EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    _IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MasterPage)))
                                    _MasterPage = dR.GetString((int)Columns.ColumnNames.MasterPage);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Theme)))
                                    _Theme = dR.GetString((int)Columns.ColumnNames.Theme);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSecure)))
                                    _IsSecure = dR.GetBoolean((int)Columns.ColumnNames.IsSecure);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    _PageType = dR.GetInt32((int)Columns.ColumnNames.PageType);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<ts_Pages> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<ts_Pages> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_Pages> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_Pages> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<ts_Pages> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<ts_Pages> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<ts_Pages> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<ts_Pages> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<ts_Pages> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<ts_Pages> returnValue = new List<ts_Pages>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_Pages Myts_Pages = new ts_Pages();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_Pages.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.parentID)))
                                    Myts_Pages.parentID = dR.GetInt32((int)Columns.ColumnNames.parentID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageTitle)))
                                    Myts_Pages.pageTitle = dR.GetString((int)Columns.ColumnNames.pageTitle);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageName)))
                                    Myts_Pages.pageName = dR.GetString((int)Columns.ColumnNames.pageName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSystemRequiredPage)))
                                    Myts_Pages.IsSystemRequiredPage = dR.GetBoolean((int)Columns.ColumnNames.IsSystemRequiredPage);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsDefault)))
                                    Myts_Pages.IsDefault = dR.GetBoolean((int)Columns.ColumnNames.IsDefault);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    Myts_Pages.ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    Myts_Pages.EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    Myts_Pages.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MasterPage)))
                                    Myts_Pages.MasterPage = dR.GetString((int)Columns.ColumnNames.MasterPage);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Theme)))
                                    Myts_Pages.Theme = dR.GetString((int)Columns.ColumnNames.Theme);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSecure)))
                                    Myts_Pages.IsSecure = dR.GetBoolean((int)Columns.ColumnNames.IsSecure);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    Myts_Pages.PageType = dR.GetInt32((int)Columns.ColumnNames.PageType);


                                returnValue.Add(Myts_Pages);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<ts_Pages> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<ts_Pages> returnValue = new List<ts_Pages>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_Pages Myts_Pages = new ts_Pages();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_Pages.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.parentID)))
                                    Myts_Pages.parentID = dR.GetInt32((int)Columns.ColumnNames.parentID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageTitle)))
                                    Myts_Pages.pageTitle = dR.GetString((int)Columns.ColumnNames.pageTitle);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.pageName)))
                                    Myts_Pages.pageName = dR.GetString((int)Columns.ColumnNames.pageName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSystemRequiredPage)))
                                    Myts_Pages.IsSystemRequiredPage = dR.GetBoolean((int)Columns.ColumnNames.IsSystemRequiredPage);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsDefault)))
                                    Myts_Pages.IsDefault = dR.GetBoolean((int)Columns.ColumnNames.IsDefault);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ExpiryDate)))
                                    Myts_Pages.ExpiryDate = dR.GetDateTime((int)Columns.ColumnNames.ExpiryDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    Myts_Pages.EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsActive)))
                                    Myts_Pages.IsActive = dR.GetBoolean((int)Columns.ColumnNames.IsActive);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MasterPage)))
                                    Myts_Pages.MasterPage = dR.GetString((int)Columns.ColumnNames.MasterPage);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Theme)))
                                    Myts_Pages.Theme = dR.GetString((int)Columns.ColumnNames.Theme);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsSecure)))
                                    Myts_Pages.IsSecure = dR.GetBoolean((int)Columns.ColumnNames.IsSecure);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    Myts_Pages.PageType = dR.GetInt32((int)Columns.ColumnNames.PageType);


                                returnValue.Add(Myts_Pages);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(ts_Pages MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ID, System.Int32 parentID, System.String pageTitle, System.String pageName, System.Boolean IsSystemRequiredPage, System.Boolean IsDefault, System.DateTime ExpiryDate, System.DateTime EffectiveDate, System.Boolean IsActive, System.String MasterPage, System.String Theme, System.Boolean IsSecure, System.Int32 PageType)
            {
                int ReturnValue = 0;
                if (ID == 0)
                    ReturnValue = Insert(parentID, pageTitle, pageName, IsSystemRequiredPage, IsDefault, ExpiryDate, EffectiveDate, IsActive, MasterPage, Theme, IsSecure, PageType);
                else
                {
                    ts_Pages MyLib = new ts_Pages();

                    MyLib.ID = ID;

                    MyLib.parentID = parentID;

                    MyLib.pageTitle = pageTitle;

                    MyLib.pageName = pageName;

                    MyLib.IsSystemRequiredPage = IsSystemRequiredPage;

                    MyLib.IsDefault = IsDefault;

                    MyLib.ExpiryDate = ExpiryDate;

                    MyLib.EffectiveDate = EffectiveDate;

                    MyLib.IsActive = IsActive;

                    MyLib.MasterPage = MasterPage;

                    MyLib.Theme = Theme;

                    MyLib.IsSecure = IsSecure;

                    MyLib.PageType = PageType;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(ts_Pages _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    ts_Pages Old = new ts_Pages(_MyLib.ID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", _MyLib.ID));

                        command.Parameters.Add(new SqlParameter("@parentID", _MyLib.parentID));

                        command.Parameters.Add(new SqlParameter("@pageTitle", _MyLib.pageTitle));

                        command.Parameters.Add(new SqlParameter("@pageName", _MyLib.pageName));

                        command.Parameters.Add(new SqlParameter("@IsSystemRequiredPage", _MyLib.IsSystemRequiredPage));

                        command.Parameters.Add(new SqlParameter("@IsDefault", _MyLib.IsDefault));

                        command.Parameters.Add(new SqlParameter("@ExpiryDate", _MyLib.ExpiryDate));

                        command.Parameters.Add(new SqlParameter("@EffectiveDate", _MyLib.EffectiveDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));

                        command.Parameters.Add(new SqlParameter("@MasterPage", _MyLib.MasterPage));

                        command.Parameters.Add(new SqlParameter("@Theme", _MyLib.Theme));

                        command.Parameters.Add(new SqlParameter("@IsSecure", _MyLib.IsSecure));

                        command.Parameters.Add(new SqlParameter("@PageType", _MyLib.PageType));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE ts_Pages  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", ID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<ts_Pages> returnValue = new List<ts_Pages>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(ts_Pages _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@parentID", _MyLib.parentID));
                        command.Parameters.Add(new SqlParameter("@pageTitle", _MyLib.pageTitle));
                        command.Parameters.Add(new SqlParameter("@pageName", _MyLib.pageName));
                        command.Parameters.Add(new SqlParameter("@IsSystemRequiredPage", _MyLib.IsSystemRequiredPage));
                        command.Parameters.Add(new SqlParameter("@IsDefault", _MyLib.IsDefault));
                        command.Parameters.Add(new SqlParameter("@ExpiryDate", _MyLib.ExpiryDate));
                        command.Parameters.Add(new SqlParameter("@EffectiveDate", _MyLib.EffectiveDate));
                        command.Parameters.Add(new SqlParameter("@IsActive", _MyLib.IsActive));
                        command.Parameters.Add(new SqlParameter("@MasterPage", _MyLib.MasterPage));
                        command.Parameters.Add(new SqlParameter("@Theme", _MyLib.Theme));
                        command.Parameters.Add(new SqlParameter("@IsSecure", _MyLib.IsSecure));
                        command.Parameters.Add(new SqlParameter("@PageType", _MyLib.PageType));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 parentID, System.String pageTitle, System.String pageName, System.Boolean IsSystemRequiredPage, System.Boolean IsDefault, System.DateTime ExpiryDate, System.DateTime EffectiveDate, System.Boolean IsActive, System.String MasterPage, System.String Theme, System.Boolean IsSecure, System.Int32 PageType)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@parentID", parentID));

                        command.Parameters.Add(new SqlParameter("@pageTitle", pageTitle));

                        command.Parameters.Add(new SqlParameter("@pageName", pageName));

                        command.Parameters.Add(new SqlParameter("@IsSystemRequiredPage", IsSystemRequiredPage));

                        command.Parameters.Add(new SqlParameter("@IsDefault", IsDefault));

                        command.Parameters.Add(new SqlParameter("@ExpiryDate", ExpiryDate));

                        command.Parameters.Add(new SqlParameter("@EffectiveDate", EffectiveDate));

                        command.Parameters.Add(new SqlParameter("@IsActive", IsActive));

                        command.Parameters.Add(new SqlParameter("@MasterPage", MasterPage));

                        command.Parameters.Add(new SqlParameter("@Theme", Theme));

                        command.Parameters.Add(new SqlParameter("@IsSecure", IsSecure));

                        command.Parameters.Add(new SqlParameter("@PageType", PageType));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class ts_PageTypes"
        public partial class ts_PageTypes
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_ts_PageTypes_";
            }


            #region  - Constructors -

            public ts_PageTypes(System.Int32 ID)
            {
                SetDefaults();
                if (ID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ID", ID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    _ID = dR.GetInt32((int)Columns.ColumnNames.ID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    _PageType = dR.GetString((int)Columns.ColumnNames.PageType);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsUsed)))
                                    _IsUsed = dR.GetBoolean((int)Columns.ColumnNames.IsUsed);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<ts_PageTypes> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<ts_PageTypes> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageTypes> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageTypes> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<ts_PageTypes> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<ts_PageTypes> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<ts_PageTypes> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<ts_PageTypes> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<ts_PageTypes> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<ts_PageTypes> returnValue = new List<ts_PageTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageTypes Myts_PageTypes = new ts_PageTypes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageTypes.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    Myts_PageTypes.PageType = dR.GetString((int)Columns.ColumnNames.PageType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsUsed)))
                                    Myts_PageTypes.IsUsed = dR.GetBoolean((int)Columns.ColumnNames.IsUsed);


                                returnValue.Add(Myts_PageTypes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<ts_PageTypes> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<ts_PageTypes> returnValue = new List<ts_PageTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageTypes Myts_PageTypes = new ts_PageTypes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageTypes.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageType)))
                                    Myts_PageTypes.PageType = dR.GetString((int)Columns.ColumnNames.PageType);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsUsed)))
                                    Myts_PageTypes.IsUsed = dR.GetBoolean((int)Columns.ColumnNames.IsUsed);


                                returnValue.Add(Myts_PageTypes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(ts_PageTypes MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ID, System.String PageType, System.Boolean IsUsed)
            {
                int ReturnValue = 0;
                if (ID == 0)
                    ReturnValue = Insert(PageType, IsUsed);
                else
                {
                    ts_PageTypes MyLib = new ts_PageTypes();

                    MyLib.ID = ID;

                    MyLib.PageType = PageType;

                    MyLib.IsUsed = IsUsed;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(ts_PageTypes _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    ts_PageTypes Old = new ts_PageTypes(_MyLib.ID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", _MyLib.ID));

                        command.Parameters.Add(new SqlParameter("@PageType", _MyLib.PageType));

                        command.Parameters.Add(new SqlParameter("@IsUsed", _MyLib.IsUsed));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE ts_PageTypes  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", ID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<ts_PageTypes> returnValue = new List<ts_PageTypes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(ts_PageTypes _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@PageType", _MyLib.PageType));
                        command.Parameters.Add(new SqlParameter("@IsUsed", _MyLib.IsUsed));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.String PageType, System.Boolean IsUsed)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@PageType", PageType));

                        command.Parameters.Add(new SqlParameter("@IsUsed", IsUsed));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class ts_PageVersionNotes"
        public partial class ts_PageVersionNotes
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_ts_PageVersionNotes_";
            }


            #region  - Constructors -

            public ts_PageVersionNotes(System.Int32 ID)
            {
                SetDefaults();
                if (ID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ID", ID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    _ID = dR.GetInt32((int)Columns.ColumnNames.ID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.versionID)))
                                    _versionID = dR.GetInt32((int)Columns.ColumnNames.versionID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.userName)))
                                    _userName = dR.GetString((int)Columns.ColumnNames.userName);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtAdded)))
                                    _dtAdded = dR.GetDateTime((int)Columns.ColumnNames.dtAdded);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Note)))
                                    _Note = dR.GetString((int)Columns.ColumnNames.Note);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    _isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<ts_PageVersionNotes> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<ts_PageVersionNotes> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageVersionNotes> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageVersionNotes> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<ts_PageVersionNotes> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<ts_PageVersionNotes> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<ts_PageVersionNotes> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<ts_PageVersionNotes> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<ts_PageVersionNotes> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<ts_PageVersionNotes> returnValue = new List<ts_PageVersionNotes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageVersionNotes Myts_PageVersionNotes = new ts_PageVersionNotes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageVersionNotes.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.versionID)))
                                    Myts_PageVersionNotes.versionID = dR.GetInt32((int)Columns.ColumnNames.versionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.userName)))
                                    Myts_PageVersionNotes.userName = dR.GetString((int)Columns.ColumnNames.userName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtAdded)))
                                    Myts_PageVersionNotes.dtAdded = dR.GetDateTime((int)Columns.ColumnNames.dtAdded);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Note)))
                                    Myts_PageVersionNotes.Note = dR.GetString((int)Columns.ColumnNames.Note);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    Myts_PageVersionNotes.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(Myts_PageVersionNotes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<ts_PageVersionNotes> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<ts_PageVersionNotes> returnValue = new List<ts_PageVersionNotes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageVersionNotes Myts_PageVersionNotes = new ts_PageVersionNotes();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageVersionNotes.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.versionID)))
                                    Myts_PageVersionNotes.versionID = dR.GetInt32((int)Columns.ColumnNames.versionID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.userName)))
                                    Myts_PageVersionNotes.userName = dR.GetString((int)Columns.ColumnNames.userName);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.dtAdded)))
                                    Myts_PageVersionNotes.dtAdded = dR.GetDateTime((int)Columns.ColumnNames.dtAdded);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.Note)))
                                    Myts_PageVersionNotes.Note = dR.GetString((int)Columns.ColumnNames.Note);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.isActive)))
                                    Myts_PageVersionNotes.isActive = dR.GetBoolean((int)Columns.ColumnNames.isActive);


                                returnValue.Add(Myts_PageVersionNotes);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(ts_PageVersionNotes MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ID, System.Int32 versionID, System.String userName, System.DateTime dtAdded, System.String Note, System.Boolean isActive)
            {
                int ReturnValue = 0;
                if (ID == 0)
                    ReturnValue = Insert(versionID, userName, dtAdded, Note, isActive);
                else
                {
                    ts_PageVersionNotes MyLib = new ts_PageVersionNotes();

                    MyLib.ID = ID;

                    MyLib.versionID = versionID;

                    MyLib.userName = userName;

                    MyLib.dtAdded = dtAdded;

                    MyLib.Note = Note;

                    MyLib.isActive = isActive;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(ts_PageVersionNotes _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    ts_PageVersionNotes Old = new ts_PageVersionNotes(_MyLib.ID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", _MyLib.ID));

                        command.Parameters.Add(new SqlParameter("@versionID", _MyLib.versionID));

                        command.Parameters.Add(new SqlParameter("@userName", _MyLib.userName));

                        command.Parameters.Add(new SqlParameter("@dtAdded", _MyLib.dtAdded));

                        command.Parameters.Add(new SqlParameter("@Note", _MyLib.Note));

                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE ts_PageVersionNotes  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", ID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<ts_PageVersionNotes> returnValue = new List<ts_PageVersionNotes>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(ts_PageVersionNotes _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@versionID", _MyLib.versionID));
                        command.Parameters.Add(new SqlParameter("@userName", _MyLib.userName));
                        command.Parameters.Add(new SqlParameter("@dtAdded", _MyLib.dtAdded));
                        command.Parameters.Add(new SqlParameter("@Note", _MyLib.Note));
                        command.Parameters.Add(new SqlParameter("@isActive", _MyLib.isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 versionID, System.String userName, System.DateTime dtAdded, System.String Note, System.Boolean isActive)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@versionID", versionID));

                        command.Parameters.Add(new SqlParameter("@userName", userName));

                        command.Parameters.Add(new SqlParameter("@dtAdded", dtAdded));

                        command.Parameters.Add(new SqlParameter("@Note", Note));

                        command.Parameters.Add(new SqlParameter("@isActive", isActive));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion

        #region " - Class ts_PageVersions"
        public partial class ts_PageVersions
        {

            private static string SPBaseSQL()
            {
                return "tcmsSP_ts_PageVersions_";
            }


            #region  - Constructors -

            public ts_PageVersions(System.Int32 ID)
            {
                SetDefaults();
                if (ID > 0)
                {

                    using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                    {
                        using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.SelectRow, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("@ID", ID));
                            connection.Open();
                            IDataReader dR = command.ExecuteReader();
                            if (dR.Read())
                            {
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    _ID = dR.GetInt32((int)Columns.ColumnNames.ID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    _PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageContent)))
                                    _PageContent = dR.GetString((int)Columns.ColumnNames.PageContent);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaKeywords)))
                                    _MetaKeywords = dR.GetString((int)Columns.ColumnNames.MetaKeywords);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaDescription)))
                                    _MetaDescription = dR.GetString((int)Columns.ColumnNames.MetaDescription);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    _EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    _IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.VersionTitle)))
                                    _VersionTitle = dR.GetString((int)Columns.ColumnNames.VersionTitle);
                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ViewCount)))
                                    _ViewCount = dR.GetInt32((int)Columns.ColumnNames.ViewCount);
                            }
                            dR.Close();
                            dR = null; /*TODO change to default if this is not refrence type */
                            connection.Close();
                        }
                    }
                }

            }

            #endregion
            #region - SELECTS - 

            public static List<ts_PageVersions> SelectWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), null /* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<ts_PageVersions> SelectWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageVersions> SelectWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<ts_PageVersions> SelectWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectAll(WhereCondition, OrderByExpression);
            }

            public static List<ts_PageVersions> SelectWhere(string WhereCondition, string OrderByExpression, string NumRows)
            {
                return SelectAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<ts_PageVersions> SelectAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }
            private static List<ts_PageVersions> SelectAll(string WhereCondition, string OrderByExpression, string NumRows)
            {
                if (NumRows == null)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else
                    return SelectRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<ts_PageVersions> SelectAll()
            {
                return SelectRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<ts_PageVersions> SelectRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<ts_PageVersions> returnValue = new List<ts_PageVersions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageVersions Myts_PageVersions = new ts_PageVersions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageVersions.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    Myts_PageVersions.PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageContent)))
                                    Myts_PageVersions.PageContent = dR.GetString((int)Columns.ColumnNames.PageContent);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaKeywords)))
                                    Myts_PageVersions.MetaKeywords = dR.GetString((int)Columns.ColumnNames.MetaKeywords);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaDescription)))
                                    Myts_PageVersions.MetaDescription = dR.GetString((int)Columns.ColumnNames.MetaDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    Myts_PageVersions.EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    Myts_PageVersions.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.VersionTitle)))
                                    Myts_PageVersions.VersionTitle = dR.GetString((int)Columns.ColumnNames.VersionTitle);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ViewCount)))
                                    Myts_PageVersions.ViewCount = dR.GetInt32((int)Columns.ColumnNames.ViewCount);


                                returnValue.Add(Myts_PageVersions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<ts_PageVersions> SelectRows(string SP, string WhereCondition, string OrderByExpression, string NumRows)
            {
                List<ts_PageVersions> returnValue = new List<ts_PageVersions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != null)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                            {
                                ts_PageVersions Myts_PageVersions = new ts_PageVersions();


                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ID)))
                                    Myts_PageVersions.ID = dR.GetInt32((int)Columns.ColumnNames.ID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageID)))
                                    Myts_PageVersions.PageID = dR.GetInt32((int)Columns.ColumnNames.PageID);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.PageContent)))
                                    Myts_PageVersions.PageContent = dR.GetString((int)Columns.ColumnNames.PageContent);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaKeywords)))
                                    Myts_PageVersions.MetaKeywords = dR.GetString((int)Columns.ColumnNames.MetaKeywords);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.MetaDescription)))
                                    Myts_PageVersions.MetaDescription = dR.GetString((int)Columns.ColumnNames.MetaDescription);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.EffectiveDate)))
                                    Myts_PageVersions.EffectiveDate = dR.GetDateTime((int)Columns.ColumnNames.EffectiveDate);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.IsApproved)))
                                    Myts_PageVersions.IsApproved = dR.GetBoolean((int)Columns.ColumnNames.IsApproved);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.VersionTitle)))
                                    Myts_PageVersions.VersionTitle = dR.GetString((int)Columns.ColumnNames.VersionTitle);

                                if (!dR.IsDBNull(dR.GetOrdinal(Columns.ViewCount)))
                                    Myts_PageVersions.ViewCount = dR.GetInt32((int)Columns.ColumnNames.ViewCount);


                                returnValue.Add(Myts_PageVersions);
                            }
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] ParmArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), null/* TODO Change to default(_) if this is not a reference type */);
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.WhereCondition[] WhereConditionArray, SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(SPHelpers.OrderByExpression[] OrderByExpressionArray)
            {
                return SelectKeysAll(null/* TODO Change to default(_) if this is not a reference type */, SPHelpers.BuildOrderByExpression(OrderByExpressionArray));
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression);
            }

            public static List<System.Int32> SelectKeysWhere(string WhereCondition, string OrderByExpression, int NumRows)
            {
                return SelectKeysAll(WhereCondition, OrderByExpression, NumRows);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression)
            {
                if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
            }

            private static List<System.Int32> SelectKeysAll(string WhereCondition, string OrderByExpression, int NumRows)
            {
                if (NumRows == 0)
                {
                    if (WhereCondition == null && OrderByExpression == null)
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
                    else
                        return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression);
                }
                else if (WhereCondition == null && OrderByExpression == null)
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */, NumRows);
                else
                    return SelectKeysRows(SPBaseSQL() + SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows);
            }

            public static List<System.Int32> SelectKeysAll()
            {
                return SelectKeysRows(SPBaseSQL() + SPTypes.SelectAll, null/* TODO Change to default(_) if this is not a reference type */, null/* TODO Change to default(_) if this is not a reference type */);
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }

            private static List<System.Int32> SelectKeysRows(string SP, string WhereCondition, string OrderByExpression, int NumRows)
            {
                List<System.Int32> returnValue = new List<System.Int32>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SP + "_TopN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (WhereCondition != null)
                            command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        if (OrderByExpression != null)
                            command.Parameters.Add(new SqlParameter("@OrderByExpression", OrderByExpression));
                        if (NumRows != 0)
                            command.Parameters.Add(new SqlParameter("@NumRows", NumRows));
                        connection.Open();
                        try
                        {
                            IDataReader dR = command.ExecuteReader();
                            while (dR.Read())
                                returnValue.Add(dR.GetInt32(0));
                            dR.Close();
                            dR = null/* TODO Change to default(_) if this is not a reference type */;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnValue;
            }
            #endregion

            #region  - Update, Insert, Delete, Save - 
            #region            - Save -
            public static int Save(ts_PageVersions MyLib)
            {
                int ReturnValue = 0;
                if (MyLib.ID == 0)
                    ReturnValue = Insert(MyLib);
                else if (Update(MyLib))
                    ReturnValue = 1;
                else
                    ReturnValue = 0;
                return ReturnValue;
            }

            public static int Save(System.Int32 ID, System.Int32 PageID, System.String PageContent, System.String MetaKeywords, System.String MetaDescription, System.DateTime EffectiveDate, System.Boolean IsApproved, System.String VersionTitle, System.Int32 ViewCount)
            {
                int ReturnValue = 0;
                if (ID == 0)
                    ReturnValue = Insert(PageID, PageContent, MetaKeywords, MetaDescription, EffectiveDate, IsApproved, VersionTitle, ViewCount);
                else
                {
                    ts_PageVersions MyLib = new ts_PageVersions();

                    MyLib.ID = ID;

                    MyLib.PageID = PageID;

                    MyLib.PageContent = PageContent;

                    MyLib.MetaKeywords = MetaKeywords;

                    MyLib.MetaDescription = MetaDescription;

                    MyLib.EffectiveDate = EffectiveDate;

                    MyLib.IsApproved = IsApproved;

                    MyLib.VersionTitle = VersionTitle;

                    MyLib.ViewCount = ViewCount;
                    if (Update(MyLib))
                        ReturnValue = 1;
                    else
                        ReturnValue = 0;
                }
                return ReturnValue;
            }
            #endregion
            #region            - Update - 

            public static bool Update(ts_PageVersions _MyLib)
            {
                bool update = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    ts_PageVersions Old = new ts_PageVersions(_MyLib.ID);
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Update, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", _MyLib.ID));

                        command.Parameters.Add(new SqlParameter("@PageID", _MyLib.PageID));

                        command.Parameters.Add(new SqlParameter("@PageContent", _MyLib.PageContent));

                        command.Parameters.Add(new SqlParameter("@MetaKeywords", _MyLib.MetaKeywords));

                        command.Parameters.Add(new SqlParameter("@MetaDescription", _MyLib.MetaDescription));

                        command.Parameters.Add(new SqlParameter("@EffectiveDate", _MyLib.EffectiveDate));

                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));

                        command.Parameters.Add(new SqlParameter("@VersionTitle", _MyLib.VersionTitle));

                        command.Parameters.Add(new SqlParameter("@ViewCount", _MyLib.ViewCount));

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            update = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            update = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    Old = null;
                }
                return update;
            }

            public static bool MassUpdate(string UpdateCriteria, string WhereClause)
            {
                bool massUpdate = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    string UpdateString = "UPDATE ts_PageVersions  SET " + UpdateCriteria;
                    if (WhereClause != null && WhereClause.Length > 2)
                        UpdateString += " WHERE " + WhereClause;
                    using (SqlCommand MyCommand = new SqlCommand(UpdateString, connection))
                    {
                        MyCommand.CommandType = CommandType.Text;
                        connection.Open();
                        try
                        {
                            MyCommand.ExecuteNonQuery();
                            massUpdate = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method
                            throw ex;
                            massUpdate = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return massUpdate;
            }
            #endregion

            #region           - Delete - 

            public static bool Delete(System.Int32 ID)
            {
                bool delete = false;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Delete, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ID", ID));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            delete = false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return delete;
            }

            public static bool DeleteWhere(SPHelpers.WhereCondition[] WhereConditionArray)
            {
                return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray));
            }

            public static bool DeleteWhere(string WhereCondition)
            {
                bool deleteWhere = false;
                List<ts_PageVersions> returnValue = new List<ts_PageVersions>();
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.DeleteDynamic, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@WhereCondition", WhereCondition));
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            deleteWhere = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            deleteWhere = false;
                        }
                    }
                }
                return deleteWhere;
            }
            #endregion
            #region           - Insert - 

            public static int Insert(ts_PageVersions _MyLib)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection)) // EDIT WAS HERE
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))
                        command.Parameters.Add(new SqlParameter("@PageID", _MyLib.PageID));
                        command.Parameters.Add(new SqlParameter("@PageContent", _MyLib.PageContent));
                        command.Parameters.Add(new SqlParameter("@MetaKeywords", _MyLib.MetaKeywords));
                        command.Parameters.Add(new SqlParameter("@MetaDescription", _MyLib.MetaDescription));
                        command.Parameters.Add(new SqlParameter("@EffectiveDate", _MyLib.EffectiveDate));
                        command.Parameters.Add(new SqlParameter("@IsApproved", _MyLib.IsApproved));
                        command.Parameters.Add(new SqlParameter("@VersionTitle", _MyLib.VersionTitle));
                        command.Parameters.Add(new SqlParameter("@ViewCount", _MyLib.ViewCount));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
                return returnID;
            }



            public static int Insert(System.Int32 PageID, System.String PageContent, System.String MetaKeywords, System.String MetaDescription, System.DateTime EffectiveDate, System.Boolean IsApproved, System.String VersionTitle, System.Int32 ViewCount)
            {
                int returnID = 0;
                using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                {
                    using (SqlCommand command = new SqlCommand(SPBaseSQL() + SPTypes.Insert, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // command.parameters.add(New SQLParameter("@AddressID", 0))

                        command.Parameters.Add(new SqlParameter("@PageID", PageID));

                        command.Parameters.Add(new SqlParameter("@PageContent", PageContent));

                        command.Parameters.Add(new SqlParameter("@MetaKeywords", MetaKeywords));

                        command.Parameters.Add(new SqlParameter("@MetaDescription", MetaDescription));

                        command.Parameters.Add(new SqlParameter("@EffectiveDate", EffectiveDate));

                        command.Parameters.Add(new SqlParameter("@IsApproved", IsApproved));

                        command.Parameters.Add(new SqlParameter("@VersionTitle", VersionTitle));

                        command.Parameters.Add(new SqlParameter("@ViewCount", ViewCount));
                        try
                        {
                            connection.Open();
                            returnID = Convert.ToInt32(command.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                            System.Diagnostics.StackFrame SF = ST.GetFrame(0); // Current Method

                            throw ex;
                            returnID = default(int);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                return returnID;
            }

            #endregion

            #endregion
        }
        #endregion
    }
}
