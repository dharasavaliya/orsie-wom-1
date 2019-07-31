using System.Data;
using System.Data.SqlClient;
using System;

//******************************************************************
//* Code Generated Automatically using GlobalCodeGen and CodeRush! 
//* AUTHOR: InterGlobal Solutions
//* SUPPORT: http://www.interglobal.ca  519-342-4881
//* ALSO: http://www.techstudio.ca  519-342-4881
//* DATE: 2019-06-11 3:50:28 PM
//* Derived from: WOM_SalesCoach
//******************************************************************
namespace DBL
{
    public partial class Tables
    {
        public enum Sorting
        {
            Ascending,
            Descending
        }

        public enum Equals
        {
            IsEqualTo,
            NotEquals,
            GreaterThan,
            GreaterThanEquals,
            LessThan,
            LessThanEquals,
            Contains,
            StartsWith,
            EndsWith
        }

        public enum TableList
        {
            AspNetRoleClaims,
            AspNetRoles,
            AspNetUserClaims,
            AspNetUserLogins,
            AspNetUserRoles,
            AspNetUsers,
            AspNetUserTokens,
            datClass,
            datClient,
            datClientResponsesMain,
            datClientResponsesOptions,
            datClientResponsesText,
            datClientSocialMedia,
            datCoach,
            datCourse,
            datCurriculum,
            datForums,
            datPerson,
            datPosts,
            datQuestionOptions,
            datSurveyQuestions,
            datSurveys,
            jncClassForum,
            jncClassStudents,
            jncCoachClasses,
            jncCurriculumSection,
            jncUsersToPeople,
            linkSurveysQuestions,
            lkpCountry,
            lkpDesignation,
            lkpGender,
            lkpProvinces,
            lkpSocialMedia,
            lkpSurveyQuestionTypes,
            ts_Pages,
            ts_PageTypes,
            ts_PageVersionNotes,
            ts_PageVersions,
        }

        #region " - Class datClass"
        public partial class datClass
        {
            #region "       - Variable Declarations - "
            private System.String _ClassCode;
            public System.String ClassCode
            {
                get
                {
                    return _ClassCode;
                }
                set
                {
                    _ClassCode = value;
                }
            }
            private System.String _CourseCode;
            public System.String CourseCode
            {
                get
                {
                    return _CourseCode;
                }
                set
                {
                    _CourseCode = value;
                }
            }
            private System.String _ClassName;
            public System.String ClassName
            {
                get
                {
                    return _ClassName;
                }
                set
                {
                    _ClassName = value;
                }
            }
            private System.String _ClassDescription;
            public System.String ClassDescription
            {
                get
                {
                    return _ClassDescription;
                }
                set
                {
                    _ClassDescription = value;
                }
            }
            private System.DateTime _CreatedDate;
            public System.DateTime CreatedDate
            {
                get
                {
                    return _CreatedDate;
                }
                set
                {
                    _CreatedDate = value;
                }
            }
            private System.DateTime _StartDate;
            public System.DateTime StartDate
            {
                get
                {
                    return _StartDate;
                }
                set
                {
                    _StartDate = value;
                }
            }
            private System.DateTime _EndDate;
            public System.DateTime EndDate
            {
                get
                {
                    return _EndDate;
                }
                set
                {
                    _EndDate = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ClassCode = "ClassCode";
                public const string CourseCode = "CourseCode";
                public const string ClassName = "ClassName";
                public const string ClassDescription = "ClassDescription";
                public const string CreatedDate = "CreatedDate";
                public const string StartDate = "StartDate";
                public const string EndDate = "EndDate";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    ClassCode,
                    CourseCode,
                    ClassName,
                    ClassDescription,
                    CreatedDate,
                    StartDate,
                    EndDate,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ClassCode:
                            {
                                return ClassCode;
                            }
                        case ColumnNames.CourseCode:
                            {
                                return CourseCode;
                            }
                        case ColumnNames.ClassName:
                            {
                                return ClassName;
                            }
                        case ColumnNames.ClassDescription:
                            {
                                return ClassDescription;
                            }
                        case ColumnNames.CreatedDate:
                            {
                                return CreatedDate;
                            }
                        case ColumnNames.StartDate:
                            {
                                return StartDate;
                            }
                        case ColumnNames.EndDate:
                            {
                                return EndDate;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return ClassCode;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ClassCode = typeof(System.String);
                public static System.Type CourseCode = typeof(System.String);
                public static System.Type ClassName = typeof(System.String);
                public static System.Type ClassDescription = typeof(System.String);
                public static System.Type CreatedDate = typeof(System.DateTime);
                public static System.Type StartDate = typeof(System.DateTime);
                public static System.Type EndDate = typeof(System.DateTime);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datClass()
            {
                SetDefaults();
            }

            public datClass(System.String CourseCode_In, System.String ClassName_In, System.String ClassDescription_In, System.DateTime CreatedDate_In, System.DateTime StartDate_In, System.DateTime EndDate_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _CourseCode = CourseCode_In;
                _ClassName = ClassName_In;
                _ClassDescription = ClassDescription_In;
                _CreatedDate = CreatedDate_In;
                _StartDate = StartDate_In;
                _EndDate = EndDate_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                ClassCode = string.Empty;
                CourseCode = string.Empty;
                ClassName = string.Empty;
                ClassDescription = string.Empty;
                CreatedDate = System.DateTime.Now;
                StartDate = System.DateTime.Now;
                EndDate = System.DateTime.Now;
                isActive = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _ClassCode;
                public static System.String ClassCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassCode] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [ClassCode] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CourseCode;
                public static System.String CourseCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CourseCode] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [CourseCode] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ClassName;
                public static System.String ClassName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassName] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [ClassName] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ClassDescription;
                public static System.String ClassDescription
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassDescription] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassDescription));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [ClassDescription] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassDescription));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _CreatedDate;
                public static System.DateTime CreatedDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CreatedDate] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [CreatedDate] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _StartDate;
                public static System.DateTime StartDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [StartDate] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _StartDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [StartDate] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _StartDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _EndDate;
                public static System.DateTime EndDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [EndDate] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _EndDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [EndDate] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _EndDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datClass] WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClass] SET [isActive] = @Value WHERE [ClassCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.String Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClass lhs, datClass rhs)
            {
                if (lhs.CourseCode == rhs.CourseCode && lhs.ClassName == rhs.ClassName && lhs.ClassDescription == rhs.ClassDescription && lhs.CreatedDate == rhs.CreatedDate && lhs.StartDate == rhs.StartDate && lhs.EndDate == rhs.EndDate && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClass lhs, datClass rhs)
            {
                if (lhs.CourseCode == rhs.CourseCode && lhs.ClassName == rhs.ClassName && lhs.ClassDescription == rhs.ClassDescription && lhs.CreatedDate == rhs.CreatedDate && lhs.StartDate == rhs.StartDate && lhs.EndDate == rhs.EndDate && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datClient"
        public partial class datClient
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ClientID;
            public System.Int32 ClientID
            {
                get
                {
                    return _ClientID;
                }
                set
                {
                    _ClientID = value;
                }
            }
            private System.String _CompanyName;
            public System.String CompanyName
            {
                get
                {
                    return _CompanyName;
                }
                set
                {
                    _CompanyName = value;
                }
            }
            private System.String _CompanyDetail;
            public System.String CompanyDetail
            {
                get
                {
                    return _CompanyDetail;
                }
                set
                {
                    _CompanyDetail = value;
                }
            }
            private System.String _WebsiteName;
            public System.String WebsiteName
            {
                get
                {
                    return _WebsiteName;
                }
                set
                {
                    _WebsiteName = value;
                }
            }
            private System.DateTime _RegisterDate;
            public System.DateTime RegisterDate
            {
                get
                {
                    return _RegisterDate;
                }
                set
                {
                    _RegisterDate = value;
                }
            }
            private System.Boolean _IsActive;
            public System.Boolean IsActive
            {
                get
                {
                    return _IsActive;
                }
                set
                {
                    _IsActive = value;
                }
            }
            private System.String _ProfileLink;
            public System.String ProfileLink
            {
                get
                {
                    return _ProfileLink;
                }
                set
                {
                    _ProfileLink = value;
                }
            }
            private System.String _BusinessType;
            public System.String BusinessType
            {
                get
                {
                    return _BusinessType;
                }
                set
                {
                    _BusinessType = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ClientID = "ClientID";
                public const string CompanyName = "CompanyName";
                public const string CompanyDetail = "CompanyDetail";
                public const string WebsiteName = "WebsiteName";
                public const string RegisterDate = "RegisterDate";
                public const string IsActive = "IsActive";
                public const string ProfileLink = "ProfileLink";
                public const string BusinessType = "BusinessType";

                public enum ColumnNames
                {
                    ClientID,
                    CompanyName,
                    CompanyDetail,
                    WebsiteName,
                    RegisterDate,
                    IsActive,
                    ProfileLink,
                    BusinessType,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ClientID:
                            {
                                return ClientID;
                            }
                        case ColumnNames.CompanyName:
                            {
                                return CompanyName;
                            }
                        case ColumnNames.CompanyDetail:
                            {
                                return CompanyDetail;
                            }
                        case ColumnNames.WebsiteName:
                            {
                                return WebsiteName;
                            }
                        case ColumnNames.RegisterDate:
                            {
                                return RegisterDate;
                            }
                        case ColumnNames.IsActive:
                            {
                                return IsActive;
                            }
                        case ColumnNames.ProfileLink:
                            {
                                return ProfileLink;
                            }
                        case ColumnNames.BusinessType:
                            {
                                return BusinessType;
                            }
                        default:
                            return ClientID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ClientID = typeof(System.Int32);
                public static System.Type CompanyName = typeof(System.String);
                public static System.Type CompanyDetail = typeof(System.String);
                public static System.Type WebsiteName = typeof(System.String);
                public static System.Type RegisterDate = typeof(System.DateTime);
                public static System.Type IsActive = typeof(System.Boolean);
                public static System.Type ProfileLink = typeof(System.String);
                public static System.Type BusinessType = typeof(System.String);
            }
            #endregion

            #region " - Sub NEW -"

            public datClient()
            {
                SetDefaults();
            }

            public datClient(System.String CompanyName_In, System.String CompanyDetail_In, System.String WebsiteName_In, System.DateTime RegisterDate_In, System.Boolean IsActive_In, System.String ProfileLink_In, System.String BusinessType_In)
            {
                SetDefaults();
                _CompanyName = CompanyName_In;
                _CompanyDetail = CompanyDetail_In;
                _WebsiteName = WebsiteName_In;
                _RegisterDate = RegisterDate_In;
                _IsActive = IsActive_In;
                _ProfileLink = ProfileLink_In;
                _BusinessType = BusinessType_In;
            }

            #endregion
            private void SetDefaults()
            {
                ClientID = 0;
                CompanyName = string.Empty;
                CompanyDetail = string.Empty;
                WebsiteName = string.Empty;
                RegisterDate = System.DateTime.Now;
                IsActive = false;
                ProfileLink = string.Empty;
                BusinessType = string.Empty;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ClientID;
                public static System.Int32 ClientID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClientID] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [ClientID] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CompanyName;
                public static System.String CompanyName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CompanyName] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CompanyName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [CompanyName] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CompanyName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CompanyDetail;
                public static System.String CompanyDetail
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CompanyDetail] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CompanyDetail));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [CompanyDetail] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CompanyDetail));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _WebsiteName;
                public static System.String WebsiteName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [WebsiteName] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _WebsiteName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [WebsiteName] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _WebsiteName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _RegisterDate;
                public static System.DateTime RegisterDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [RegisterDate] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _RegisterDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [RegisterDate] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _RegisterDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsActive] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [IsActive] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ProfileLink;
                public static System.String ProfileLink
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ProfileLink] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ProfileLink));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [ProfileLink] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ProfileLink));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _BusinessType;
                public static System.String BusinessType
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [BusinessType] FROM [datClient] WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _BusinessType));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClient] SET [BusinessType] = @Value WHERE [ClientID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _BusinessType));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClient lhs, datClient rhs)
            {
                if (lhs.CompanyName == rhs.CompanyName && lhs.CompanyDetail == rhs.CompanyDetail && lhs.WebsiteName == rhs.WebsiteName && lhs.RegisterDate == rhs.RegisterDate && lhs.IsActive == rhs.IsActive && lhs.ProfileLink == rhs.ProfileLink && lhs.BusinessType == rhs.BusinessType)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClient lhs, datClient rhs)
            {
                if (lhs.CompanyName == rhs.CompanyName && lhs.CompanyDetail == rhs.CompanyDetail && lhs.WebsiteName == rhs.WebsiteName && lhs.RegisterDate == rhs.RegisterDate && lhs.IsActive == rhs.IsActive && lhs.ProfileLink == rhs.ProfileLink && lhs.BusinessType == rhs.BusinessType)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datClientResponsesMain"
        public partial class datClientResponsesMain
        {
            #region "       - Variable Declarations - "
            private System.Int32 _clientResponseID;
            public System.Int32 clientResponseID
            {
                get
                {
                    return _clientResponseID;
                }
                set
                {
                    _clientResponseID = value;
                }
            }
            private System.Int32 _clientID;
            public System.Int32 clientID
            {
                get
                {
                    return _clientID;
                }
                set
                {
                    _clientID = value;
                }
            }
            private System.DateTime _dtStarted;
            public System.DateTime dtStarted
            {
                get
                {
                    return _dtStarted;
                }
                set
                {
                    _dtStarted = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            private System.Int32 _numberCorrect;
            public System.Int32 numberCorrect
            {
                get
                {
                    return _numberCorrect;
                }
                set
                {
                    _numberCorrect = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string clientResponseID = "clientResponseID";
                public const string clientID = "clientID";
                public const string dtStarted = "dtStarted";
                public const string isActive = "isActive";
                public const string numberCorrect = "numberCorrect";

                public enum ColumnNames
                {
                    clientResponseID,
                    clientID,
                    dtStarted,
                    isActive,
                    numberCorrect,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.clientResponseID:
                            {
                                return clientResponseID;
                            }
                        case ColumnNames.clientID:
                            {
                                return clientID;
                            }
                        case ColumnNames.dtStarted:
                            {
                                return dtStarted;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        case ColumnNames.numberCorrect:
                            {
                                return numberCorrect;
                            }
                        default:
                            return clientResponseID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type clientResponseID = typeof(System.Int32);
                public static System.Type clientID = typeof(System.Int32);
                public static System.Type dtStarted = typeof(System.DateTime);
                public static System.Type isActive = typeof(System.Boolean);
                public static System.Type numberCorrect = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public datClientResponsesMain()
            {
                SetDefaults();
            }

            public datClientResponsesMain(System.Int32 clientID_In, System.DateTime dtStarted_In, System.Boolean isActive_In, System.Int32 numberCorrect_In)
            {
                SetDefaults();
                _clientID = clientID_In;
                _dtStarted = dtStarted_In;
                _isActive = isActive_In;
                _numberCorrect = numberCorrect_In;
            }

            #endregion
            private void SetDefaults()
            {
                clientResponseID = 0;
                clientID = 0;
                dtStarted = System.DateTime.Now;
                isActive = true;
                numberCorrect = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ClientResponseID;
                public static System.Int32 ClientResponseID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [clientResponseID] FROM [datClientResponsesMain] WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesMain] SET [clientResponseID] = @Value WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ClientID;
                public static System.Int32 ClientID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [clientID] FROM [datClientResponsesMain] WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesMain] SET [clientID] = @Value WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _DtStarted;
                public static System.DateTime DtStarted
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [dtStarted] FROM [datClientResponsesMain] WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DtStarted));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesMain] SET [dtStarted] = @Value WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DtStarted));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datClientResponsesMain] WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesMain] SET [isActive] = @Value WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _NumberCorrect;
                public static System.Int32 NumberCorrect
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [numberCorrect] FROM [datClientResponsesMain] WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _NumberCorrect));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesMain] SET [numberCorrect] = @Value WHERE [clientResponseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _NumberCorrect));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClientResponsesMain lhs, datClientResponsesMain rhs)
            {
                if (lhs.clientID == rhs.clientID && lhs.dtStarted == rhs.dtStarted && lhs.isActive == rhs.isActive && lhs.numberCorrect == rhs.numberCorrect)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClientResponsesMain lhs, datClientResponsesMain rhs)
            {
                if (lhs.clientID == rhs.clientID && lhs.dtStarted == rhs.dtStarted && lhs.isActive == rhs.isActive && lhs.numberCorrect == rhs.numberCorrect)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datClientResponsesOptions"
        public partial class datClientResponsesOptions
        {
            #region "       - Variable Declarations - "
            private System.Int32 _responseID;
            public System.Int32 responseID
            {
                get
                {
                    return _responseID;
                }
                set
                {
                    _responseID = value;
                }
            }
            private System.Int32 _clientResponseID;
            public System.Int32 clientResponseID
            {
                get
                {
                    return _clientResponseID;
                }
                set
                {
                    _clientResponseID = value;
                }
            }
            private System.Int32 _SurveyQuestionID;
            public System.Int32 SurveyQuestionID
            {
                get
                {
                    return _SurveyQuestionID;
                }
                set
                {
                    _SurveyQuestionID = value;
                }
            }
            private System.Int32 _optionID;
            public System.Int32 optionID
            {
                get
                {
                    return _optionID;
                }
                set
                {
                    _optionID = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string responseID = "responseID";
                public const string clientResponseID = "clientResponseID";
                public const string SurveyQuestionID = "SurveyQuestionID";
                public const string optionID = "optionID";

                public enum ColumnNames
                {
                    responseID,
                    clientResponseID,
                    SurveyQuestionID,
                    optionID,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.responseID:
                            {
                                return responseID;
                            }
                        case ColumnNames.clientResponseID:
                            {
                                return clientResponseID;
                            }
                        case ColumnNames.SurveyQuestionID:
                            {
                                return SurveyQuestionID;
                            }
                        case ColumnNames.optionID:
                            {
                                return optionID;
                            }
                        default:
                            return responseID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type responseID = typeof(System.Int32);
                public static System.Type clientResponseID = typeof(System.Int32);
                public static System.Type SurveyQuestionID = typeof(System.Int32);
                public static System.Type optionID = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public datClientResponsesOptions()
            {
                SetDefaults();
            }

            public datClientResponsesOptions(System.Int32 clientResponseID_In, System.Int32 SurveyQuestionID_In, System.Int32 optionID_In)
            {
                SetDefaults();
                _clientResponseID = clientResponseID_In;
                _SurveyQuestionID = SurveyQuestionID_In;
                _optionID = optionID_In;
            }

            #endregion
            private void SetDefaults()
            {
                responseID = 0;
                clientResponseID = 0;
                SurveyQuestionID = 0;
                optionID = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ResponseID;
                public static System.Int32 ResponseID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [responseID] FROM [datClientResponsesOptions] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesOptions] SET [responseID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ClientResponseID;
                public static System.Int32 ClientResponseID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [clientResponseID] FROM [datClientResponsesOptions] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesOptions] SET [clientResponseID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _SurveyQuestionID;
                public static System.Int32 SurveyQuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [SurveyQuestionID] FROM [datClientResponsesOptions] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesOptions] SET [SurveyQuestionID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _OptionID;
                public static System.Int32 OptionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [optionID] FROM [datClientResponsesOptions] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _OptionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesOptions] SET [optionID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _OptionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClientResponsesOptions lhs, datClientResponsesOptions rhs)
            {
                if (lhs.clientResponseID == rhs.clientResponseID && lhs.SurveyQuestionID == rhs.SurveyQuestionID && lhs.optionID == rhs.optionID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClientResponsesOptions lhs, datClientResponsesOptions rhs)
            {
                if (lhs.clientResponseID == rhs.clientResponseID && lhs.SurveyQuestionID == rhs.SurveyQuestionID && lhs.optionID == rhs.optionID)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datClientResponsesText"
        public partial class datClientResponsesText
        {
            #region "       - Variable Declarations - "
            private System.Int32 _responseID;
            public System.Int32 responseID
            {
                get
                {
                    return _responseID;
                }
                set
                {
                    _responseID = value;
                }
            }
            private System.Int32 _clientResponseID;
            public System.Int32 clientResponseID
            {
                get
                {
                    return _clientResponseID;
                }
                set
                {
                    _clientResponseID = value;
                }
            }
            private System.Int32 _surveyQuestionID;
            public System.Int32 surveyQuestionID
            {
                get
                {
                    return _surveyQuestionID;
                }
                set
                {
                    _surveyQuestionID = value;
                }
            }
            private System.String _responseText;
            public System.String responseText
            {
                get
                {
                    return _responseText;
                }
                set
                {
                    _responseText = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string responseID = "responseID";
                public const string clientResponseID = "clientResponseID";
                public const string surveyQuestionID = "surveyQuestionID";
                public const string responseText = "responseText";

                public enum ColumnNames
                {
                    responseID,
                    clientResponseID,
                    surveyQuestionID,
                    responseText,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.responseID:
                            {
                                return responseID;
                            }
                        case ColumnNames.clientResponseID:
                            {
                                return clientResponseID;
                            }
                        case ColumnNames.surveyQuestionID:
                            {
                                return surveyQuestionID;
                            }
                        case ColumnNames.responseText:
                            {
                                return responseText;
                            }
                        default:
                            return responseID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type responseID = typeof(System.Int32);
                public static System.Type clientResponseID = typeof(System.Int32);
                public static System.Type surveyQuestionID = typeof(System.Int32);
                public static System.Type responseText = typeof(System.String);
            }
            #endregion

            #region " - Sub NEW -"

            public datClientResponsesText()
            {
                SetDefaults();
            }

            public datClientResponsesText(System.Int32 clientResponseID_In, System.Int32 surveyQuestionID_In, System.String responseText_In)
            {
                SetDefaults();
                _clientResponseID = clientResponseID_In;
                _surveyQuestionID = surveyQuestionID_In;
                _responseText = responseText_In;
            }

            #endregion
            private void SetDefaults()
            {
                responseID = 0;
                clientResponseID = 0;
                surveyQuestionID = 0;
                responseText = string.Empty;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ResponseID;
                public static System.Int32 ResponseID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [responseID] FROM [datClientResponsesText] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesText] SET [responseID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ClientResponseID;
                public static System.Int32 ClientResponseID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [clientResponseID] FROM [datClientResponsesText] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesText] SET [clientResponseID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientResponseID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _SurveyQuestionID;
                public static System.Int32 SurveyQuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [surveyQuestionID] FROM [datClientResponsesText] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesText] SET [surveyQuestionID] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ResponseText;
                public static System.String ResponseText
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [responseText] FROM [datClientResponsesText] WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseText));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientResponsesText] SET [responseText] = @Value WHERE [responseID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ResponseText));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClientResponsesText lhs, datClientResponsesText rhs)
            {
                if (lhs.clientResponseID == rhs.clientResponseID && lhs.surveyQuestionID == rhs.surveyQuestionID && lhs.responseText == rhs.responseText)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClientResponsesText lhs, datClientResponsesText rhs)
            {
                if (lhs.clientResponseID == rhs.clientResponseID && lhs.surveyQuestionID == rhs.surveyQuestionID && lhs.responseText == rhs.responseText)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datClientSocialMedia"
        public partial class datClientSocialMedia
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ID;
            public System.Int32 ID
            {
                get
                {
                    return _ID;
                }
                set
                {
                    _ID = value;
                }
            }
            private System.Int32 _clientID;
            public System.Int32 clientID
            {
                get
                {
                    return _clientID;
                }
                set
                {
                    _clientID = value;
                }
            }
            private System.Int32 _smTypeID;
            public System.Int32 smTypeID
            {
                get
                {
                    return _smTypeID;
                }
                set
                {
                    _smTypeID = value;
                }
            }
            private System.String _URLstring;
            public System.String URLstring
            {
                get
                {
                    return _URLstring;
                }
                set
                {
                    _URLstring = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            private System.Int32 _DisplayOrder;
            public System.Int32 DisplayOrder
            {
                get
                {
                    return _DisplayOrder;
                }
                set
                {
                    _DisplayOrder = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ID = "ID";
                public const string clientID = "clientID";
                public const string smTypeID = "smTypeID";
                public const string URLstring = "URLstring";
                public const string isActive = "isActive";
                public const string DisplayOrder = "DisplayOrder";

                public enum ColumnNames
                {
                    ID,
                    clientID,
                    smTypeID,
                    URLstring,
                    isActive,
                    DisplayOrder,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ID:
                            {
                                return ID;
                            }
                        case ColumnNames.clientID:
                            {
                                return clientID;
                            }
                        case ColumnNames.smTypeID:
                            {
                                return smTypeID;
                            }
                        case ColumnNames.URLstring:
                            {
                                return URLstring;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        case ColumnNames.DisplayOrder:
                            {
                                return DisplayOrder;
                            }
                        default:
                            return ID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ID = typeof(System.Int32);
                public static System.Type clientID = typeof(System.Int32);
                public static System.Type smTypeID = typeof(System.Int32);
                public static System.Type URLstring = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
                public static System.Type DisplayOrder = typeof(System.Byte);
            }
            #endregion

            #region " - Sub NEW -"

            public datClientSocialMedia()
            {
                SetDefaults();
            }

            public datClientSocialMedia(System.Int32 clientID_In, System.Int32 smTypeID_In, System.String URLstring_In, System.Boolean isActive_In, System.Int32 DisplayOrder_In)
            {
                SetDefaults();
                _clientID = clientID_In;
                _smTypeID = smTypeID_In;
                _URLstring = URLstring_In;
                _isActive = isActive_In;
                _DisplayOrder = DisplayOrder_In;
            }

            #endregion
            private void SetDefaults()
            {
                ID = 0;
                clientID = 0;
                smTypeID = 0;
                URLstring = string.Empty;
                isActive = true;
                DisplayOrder = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _Id;
                public static System.Int32 Id
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ID] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [ID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ClientID;
                public static System.Int32 ClientID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [clientID] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [clientID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _SmTypeID;
                public static System.Int32 SmTypeID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [smTypeID] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SmTypeID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [smTypeID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SmTypeID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _URLstring;
                public static System.String URLstring
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [URLstring] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _URLstring));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [URLstring] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _URLstring));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [isActive] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DisplayOrder] FROM [datClientSocialMedia] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datClientSocialMedia] SET [DisplayOrder] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datClientSocialMedia lhs, datClientSocialMedia rhs)
            {
                if (lhs.clientID == rhs.clientID && lhs.smTypeID == rhs.smTypeID && lhs.URLstring == rhs.URLstring && lhs.isActive == rhs.isActive && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datClientSocialMedia lhs, datClientSocialMedia rhs)
            {
                if (lhs.clientID == rhs.clientID && lhs.smTypeID == rhs.smTypeID && lhs.URLstring == rhs.URLstring && lhs.isActive == rhs.isActive && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datCoach"
        public partial class datCoach
        {
            #region "       - Variable Declarations - "
            private System.Int32 _CoachID;
            public System.Int32 CoachID
            {
                get
                {
                    return _CoachID;
                }
                set
                {
                    _CoachID = value;
                }
            }
            private System.String _DesignationID;
            public System.String DesignationID
            {
                get
                {
                    return _DesignationID;
                }
                set
                {
                    _DesignationID = value;
                }
            }
            private System.DateTime _StartDate;
            public System.DateTime StartDate
            {
                get
                {
                    return _StartDate;
                }
                set
                {
                    _StartDate = value;
                }
            }
            private System.DateTime _EndDate;
            public System.DateTime EndDate
            {
                get
                {
                    return _EndDate;
                }
                set
                {
                    _EndDate = value;
                }
            }
            private System.Boolean _IsActive;
            public System.Boolean IsActive
            {
                get
                {
                    return _IsActive;
                }
                set
                {
                    _IsActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string CoachID = "CoachID";
                public const string DesignationID = "DesignationID";
                public const string StartDate = "StartDate";
                public const string EndDate = "EndDate";
                public const string IsActive = "IsActive";

                public enum ColumnNames
                {
                    CoachID,
                    DesignationID,
                    StartDate,
                    EndDate,
                    IsActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.CoachID:
                            {
                                return CoachID;
                            }
                        case ColumnNames.DesignationID:
                            {
                                return DesignationID;
                            }
                        case ColumnNames.StartDate:
                            {
                                return StartDate;
                            }
                        case ColumnNames.EndDate:
                            {
                                return EndDate;
                            }
                        case ColumnNames.IsActive:
                            {
                                return IsActive;
                            }
                        default:
                            return CoachID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type CoachID = typeof(System.Int32);
                public static System.Type DesignationID = typeof(System.String);
                public static System.Type StartDate = typeof(System.DateTime);
                public static System.Type EndDate = typeof(System.DateTime);
                public static System.Type IsActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datCoach()
            {
                SetDefaults();
            }

            public datCoach(System.String DesignationID_In, System.DateTime StartDate_In, System.DateTime EndDate_In, System.Boolean IsActive_In)
            {
                SetDefaults();
                _DesignationID = DesignationID_In;
                _StartDate = StartDate_In;
                _EndDate = EndDate_In;
                _IsActive = IsActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                CoachID = 0;
                DesignationID = string.Empty;
                StartDate = System.DateTime.Now;
                EndDate = System.DateTime.Now;
                IsActive = false;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _CoachID;
                public static System.Int32 CoachID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CoachID] FROM [datCoach] WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CoachID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCoach] SET [CoachID] = @Value WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CoachID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _DesignationID;
                public static System.String DesignationID
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DesignationID] FROM [datCoach] WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationID));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCoach] SET [DesignationID] = @Value WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _StartDate;
                public static System.DateTime StartDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [StartDate] FROM [datCoach] WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _StartDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCoach] SET [StartDate] = @Value WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _StartDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _EndDate;
                public static System.DateTime EndDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [EndDate] FROM [datCoach] WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _EndDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCoach] SET [EndDate] = @Value WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _EndDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsActive] FROM [datCoach] WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCoach] SET [IsActive] = @Value WHERE [CoachID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datCoach lhs, datCoach rhs)
            {
                if (lhs.DesignationID == rhs.DesignationID && lhs.StartDate == rhs.StartDate && lhs.EndDate == rhs.EndDate && lhs.IsActive == rhs.IsActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datCoach lhs, datCoach rhs)
            {
                if (lhs.DesignationID == rhs.DesignationID && lhs.StartDate == rhs.StartDate && lhs.EndDate == rhs.EndDate && lhs.IsActive == rhs.IsActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datCourse"
        public partial class datCourse
        {
            #region "       - Variable Declarations - "
            private System.String _CourseCode;
            public System.String CourseCode
            {
                get
                {
                    return _CourseCode;
                }
                set
                {
                    _CourseCode = value;
                }
            }
            private System.String _CourseName;
            public System.String CourseName
            {
                get
                {
                    return _CourseName;
                }
                set
                {
                    _CourseName = value;
                }
            }
            private System.String _CourseDescription;
            public System.String CourseDescription
            {
                get
                {
                    return _CourseDescription;
                }
                set
                {
                    _CourseDescription = value;
                }
            }
            private System.DateTime _CreatedDate;
            public System.DateTime CreatedDate
            {
                get
                {
                    return _CreatedDate;
                }
                set
                {
                    _CreatedDate = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string CourseCode = "CourseCode";
                public const string CourseName = "CourseName";
                public const string CourseDescription = "CourseDescription";
                public const string CreatedDate = "CreatedDate";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    CourseCode,
                    CourseName,
                    CourseDescription,
                    CreatedDate,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.CourseCode:
                            {
                                return CourseCode;
                            }
                        case ColumnNames.CourseName:
                            {
                                return CourseName;
                            }
                        case ColumnNames.CourseDescription:
                            {
                                return CourseDescription;
                            }
                        case ColumnNames.CreatedDate:
                            {
                                return CreatedDate;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return CourseCode;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type CourseCode = typeof(System.String);
                public static System.Type CourseName = typeof(System.String);
                public static System.Type CourseDescription = typeof(System.String);
                public static System.Type CreatedDate = typeof(System.DateTime);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datCourse()
            {
                SetDefaults();
            }

            public datCourse(System.String CourseName_In, System.String CourseDescription_In, System.DateTime CreatedDate_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _CourseName = CourseName_In;
                _CourseDescription = CourseDescription_In;
                _CreatedDate = CreatedDate_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                CourseCode = string.Empty;
                CourseName = string.Empty;
                CourseDescription = string.Empty;
                CreatedDate = System.DateTime.Now;
                isActive = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _CourseCode;
                public static System.String CourseCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CourseCode] FROM [datCourse] WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCourse] SET [CourseCode] = @Value WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CourseName;
                public static System.String CourseName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CourseName] FROM [datCourse] WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CourseName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCourse] SET [CourseName] = @Value WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CourseName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CourseDescription;
                public static System.String CourseDescription
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CourseDescription] FROM [datCourse] WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CourseDescription));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCourse] SET [CourseDescription] = @Value WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CourseDescription));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _CreatedDate;
                public static System.DateTime CreatedDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CreatedDate] FROM [datCourse] WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCourse] SET [CreatedDate] = @Value WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datCourse] WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCourse] SET [isActive] = @Value WHERE [CourseCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.String Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datCourse lhs, datCourse rhs)
            {
                if (lhs.CourseName == rhs.CourseName && lhs.CourseDescription == rhs.CourseDescription && lhs.CreatedDate == rhs.CreatedDate && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datCourse lhs, datCourse rhs)
            {
                if (lhs.CourseName == rhs.CourseName && lhs.CourseDescription == rhs.CourseDescription && lhs.CreatedDate == rhs.CreatedDate && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datCurriculum"
        public partial class datCurriculum
        {
            #region "       - Variable Declarations - "
            private System.Int32 _CurriculumID;
            public System.Int32 CurriculumID
            {
                get
                {
                    return _CurriculumID;
                }
                set
                {
                    _CurriculumID = value;
                }
            }
            private System.String _CourseCode;
            public System.String CourseCode
            {
                get
                {
                    return _CourseCode;
                }
                set
                {
                    _CourseCode = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string CurriculumID = "CurriculumID";
                public const string CourseCode = "CourseCode";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    CurriculumID,
                    CourseCode,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.CurriculumID:
                            {
                                return CurriculumID;
                            }
                        case ColumnNames.CourseCode:
                            {
                                return CourseCode;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return CurriculumID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type CurriculumID = typeof(System.Int32);
                public static System.Type CourseCode = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datCurriculum()
            {
                SetDefaults();
            }

            public datCurriculum(System.String CourseCode_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _CourseCode = CourseCode_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                CurriculumID = 0;
                CourseCode = string.Empty;
                isActive = false;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _CurriculumID;
                public static System.Int32 CurriculumID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CurriculumID] FROM [datCurriculum] WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CurriculumID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCurriculum] SET [CurriculumID] = @Value WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CurriculumID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CourseCode;
                public static System.String CourseCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CourseCode] FROM [datCurriculum] WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCurriculum] SET [CourseCode] = @Value WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CourseCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datCurriculum] WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datCurriculum] SET [isActive] = @Value WHERE [CurriculumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datCurriculum lhs, datCurriculum rhs)
            {
                if (lhs.CourseCode == rhs.CourseCode && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datCurriculum lhs, datCurriculum rhs)
            {
                if (lhs.CourseCode == rhs.CourseCode && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datForums"
        public partial class datForums
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ForumID;
            public System.Int32 ForumID
            {
                get
                {
                    return _ForumID;
                }
                set
                {
                    _ForumID = value;
                }
            }
            private System.String _ForumName;
            public System.String ForumName
            {
                get
                {
                    return _ForumName;
                }
                set
                {
                    _ForumName = value;
                }
            }
            private System.Boolean _IsActive;
            public System.Boolean IsActive
            {
                get
                {
                    return _IsActive;
                }
                set
                {
                    _IsActive = value;
                }
            }
            private System.Boolean _IsApproved;
            public System.Boolean IsApproved
            {
                get
                {
                    return _IsApproved;
                }
                set
                {
                    _IsApproved = value;
                }
            }
            private System.Boolean _IsSticky;
            public System.Boolean IsSticky
            {
                get
                {
                    return _IsSticky;
                }
                set
                {
                    _IsSticky = value;
                }
            }
            private System.Boolean _IsPrivate;
            public System.Boolean IsPrivate
            {
                get
                {
                    return _IsPrivate;
                }
                set
                {
                    _IsPrivate = value;
                }
            }
            private System.String _UserCreated;
            public System.String UserCreated
            {
                get
                {
                    return _UserCreated;
                }
                set
                {
                    _UserCreated = value;
                }
            }
            private System.DateTime _CreatedDate;
            public System.DateTime CreatedDate
            {
                get
                {
                    return _CreatedDate;
                }
                set
                {
                    _CreatedDate = value;
                }
            }
            private System.DateTime _ExpiryDate;
            public System.DateTime ExpiryDate
            {
                get
                {
                    return _ExpiryDate;
                }
                set
                {
                    _ExpiryDate = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ForumID = "ForumID";
                public const string ForumName = "ForumName";
                public const string IsActive = "IsActive";
                public const string IsApproved = "IsApproved";
                public const string IsSticky = "IsSticky";
                public const string IsPrivate = "IsPrivate";
                public const string UserCreated = "UserCreated";
                public const string CreatedDate = "CreatedDate";
                public const string ExpiryDate = "ExpiryDate";

                public enum ColumnNames
                {
                    ForumID,
                    ForumName,
                    IsActive,
                    IsApproved,
                    IsSticky,
                    IsPrivate,
                    UserCreated,
                    CreatedDate,
                    ExpiryDate,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ForumID:
                            {
                                return ForumID;
                            }
                        case ColumnNames.ForumName:
                            {
                                return ForumName;
                            }
                        case ColumnNames.IsActive:
                            {
                                return IsActive;
                            }
                        case ColumnNames.IsApproved:
                            {
                                return IsApproved;
                            }
                        case ColumnNames.IsSticky:
                            {
                                return IsSticky;
                            }
                        case ColumnNames.IsPrivate:
                            {
                                return IsPrivate;
                            }
                        case ColumnNames.UserCreated:
                            {
                                return UserCreated;
                            }
                        case ColumnNames.CreatedDate:
                            {
                                return CreatedDate;
                            }
                        case ColumnNames.ExpiryDate:
                            {
                                return ExpiryDate;
                            }
                        default:
                            return ForumID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ForumID = typeof(System.Int32);
                public static System.Type ForumName = typeof(System.String);
                public static System.Type IsActive = typeof(System.Boolean);
                public static System.Type IsApproved = typeof(System.Boolean);
                public static System.Type IsSticky = typeof(System.Boolean);
                public static System.Type IsPrivate = typeof(System.Boolean);
                public static System.Type UserCreated = typeof(System.String);
                public static System.Type CreatedDate = typeof(System.DateTime);
                public static System.Type ExpiryDate = typeof(System.DateTime);
            }
            #endregion

            #region " - Sub NEW -"

            public datForums()
            {
                SetDefaults();
            }

            public datForums(System.String ForumName_In, System.Boolean IsActive_In, System.Boolean IsApproved_In, System.Boolean IsSticky_In, System.Boolean IsPrivate_In, System.String UserCreated_In, System.DateTime CreatedDate_In, System.DateTime ExpiryDate_In)
            {
                SetDefaults();
                _ForumName = ForumName_In;
                _IsActive = IsActive_In;
                _IsApproved = IsApproved_In;
                _IsSticky = IsSticky_In;
                _IsPrivate = IsPrivate_In;
                _UserCreated = UserCreated_In;
                _CreatedDate = CreatedDate_In;
                _ExpiryDate = ExpiryDate_In;
            }

            #endregion
            private void SetDefaults()
            {
                ForumID = 0;
                ForumName = string.Empty;
                IsActive = true;
                IsApproved = true;
                IsSticky = false;
                IsPrivate = false;
                UserCreated = string.Empty;
                CreatedDate = System.DateTime.Now;
                ExpiryDate = System.DateTime.Now;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ForumID;
                public static System.Int32 ForumID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ForumID] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [ForumID] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ForumName;
                public static System.String ForumName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ForumName] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ForumName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [ForumName] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ForumName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsActive] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [IsActive] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsApproved;
                public static System.Boolean IsApproved
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsApproved] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [IsApproved] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsSticky;
                public static System.Boolean IsSticky
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsSticky] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsSticky));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [IsSticky] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsSticky));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsPrivate;
                public static System.Boolean IsPrivate
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsPrivate] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsPrivate));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [IsPrivate] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsPrivate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _UserCreated;
                public static System.String UserCreated
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [UserCreated] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _UserCreated));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [UserCreated] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _UserCreated));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _CreatedDate;
                public static System.DateTime CreatedDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CreatedDate] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [CreatedDate] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CreatedDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _ExpiryDate;
                public static System.DateTime ExpiryDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ExpiryDate] FROM [datForums] WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ExpiryDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datForums] SET [ExpiryDate] = @Value WHERE [ForumID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ExpiryDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
                public static bool IsApproved(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsApproved;
                    ReadWrite.IsApproved = !Value;
                    return Value;
                }
                public static bool IsSticky(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsSticky;
                    ReadWrite.IsSticky = !Value;
                    return Value;
                }
                public static bool IsPrivate(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsPrivate;
                    ReadWrite.IsPrivate = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datForums lhs, datForums rhs)
            {
                if (lhs.ForumName == rhs.ForumName && lhs.IsActive == rhs.IsActive && lhs.IsApproved == rhs.IsApproved && lhs.IsSticky == rhs.IsSticky && lhs.IsPrivate == rhs.IsPrivate && lhs.UserCreated == rhs.UserCreated && lhs.CreatedDate == rhs.CreatedDate && lhs.ExpiryDate == rhs.ExpiryDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datForums lhs, datForums rhs)
            {
                if (lhs.ForumName == rhs.ForumName && lhs.IsActive == rhs.IsActive && lhs.IsApproved == rhs.IsApproved && lhs.IsSticky == rhs.IsSticky && lhs.IsPrivate == rhs.IsPrivate && lhs.UserCreated == rhs.UserCreated && lhs.CreatedDate == rhs.CreatedDate && lhs.ExpiryDate == rhs.ExpiryDate)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datPerson"
        public partial class datPerson
        {
            #region "       - Variable Declarations - "
            private System.Int32 _PersonID;
            public System.Int32 PersonID
            {
                get
                {
                    return _PersonID;
                }
                set
                {
                    _PersonID = value;
                }
            }
            private System.String _FirstName;
            public System.String FirstName
            {
                get
                {
                    return _FirstName;
                }
                set
                {
                    _FirstName = value;
                }
            }
            private System.String _LastName;
            public System.String LastName
            {
                get
                {
                    return _LastName;
                }
                set
                {
                    _LastName = value;
                }
            }
            private System.String _Gender;
            public System.String Gender
            {
                get
                {
                    return _Gender;
                }
                set
                {
                    _Gender = value;
                }
            }
            private System.String _PhoneNumber;
            public System.String PhoneNumber
            {
                get
                {
                    return _PhoneNumber;
                }
                set
                {
                    _PhoneNumber = value;
                }
            }
            private System.String _StreetAddress;
            public System.String StreetAddress
            {
                get
                {
                    return _StreetAddress;
                }
                set
                {
                    _StreetAddress = value;
                }
            }
            private System.String _StreetAddress2;
            public System.String StreetAddress2
            {
                get
                {
                    return _StreetAddress2;
                }
                set
                {
                    _StreetAddress2 = value;
                }
            }
            private System.String _City;
            public System.String City
            {
                get
                {
                    return _City;
                }
                set
                {
                    _City = value;
                }
            }
            private System.String _Prov;
            public System.String Prov
            {
                get
                {
                    return _Prov;
                }
                set
                {
                    _Prov = value;
                }
            }
            private System.String _PostalCode;
            public System.String PostalCode
            {
                get
                {
                    return _PostalCode;
                }
                set
                {
                    _PostalCode = value;
                }
            }
            private System.DateTime _DateOfBirth;
            public System.DateTime DateOfBirth
            {
                get
                {
                    return _DateOfBirth;
                }
                set
                {
                    _DateOfBirth = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string PersonID = "PersonID";
                public const string FirstName = "FirstName";
                public const string LastName = "LastName";
                public const string Gender = "Gender";
                public const string PhoneNumber = "PhoneNumber";
                public const string StreetAddress = "StreetAddress";
                public const string StreetAddress2 = "StreetAddress2";
                public const string City = "City";
                public const string Prov = "Prov";
                public const string PostalCode = "PostalCode";
                public const string DateOfBirth = "DateOfBirth";

                public enum ColumnNames
                {
                    PersonID,
                    FirstName,
                    LastName,
                    Gender,
                    PhoneNumber,
                    StreetAddress,
                    StreetAddress2,
                    City,
                    Prov,
                    PostalCode,
                    DateOfBirth,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.PersonID:
                            {
                                return PersonID;
                            }
                        case ColumnNames.FirstName:
                            {
                                return FirstName;
                            }
                        case ColumnNames.LastName:
                            {
                                return LastName;
                            }
                        case ColumnNames.Gender:
                            {
                                return Gender;
                            }
                        case ColumnNames.PhoneNumber:
                            {
                                return PhoneNumber;
                            }
                        case ColumnNames.StreetAddress:
                            {
                                return StreetAddress;
                            }
                        case ColumnNames.StreetAddress2:
                            {
                                return StreetAddress2;
                            }
                        case ColumnNames.City:
                            {
                                return City;
                            }
                        case ColumnNames.Prov:
                            {
                                return Prov;
                            }
                        case ColumnNames.PostalCode:
                            {
                                return PostalCode;
                            }
                        case ColumnNames.DateOfBirth:
                            {
                                return DateOfBirth;
                            }
                        default:
                            return PersonID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type PersonID = typeof(System.Int32);
                public static System.Type FirstName = typeof(System.String);
                public static System.Type LastName = typeof(System.String);
                public static System.Type Gender = typeof(System.String);
                public static System.Type PhoneNumber = typeof(System.String);
                public static System.Type StreetAddress = typeof(System.String);
                public static System.Type StreetAddress2 = typeof(System.String);
                public static System.Type City = typeof(System.String);
                public static System.Type Prov = typeof(System.String);
                public static System.Type PostalCode = typeof(System.String);
                public static System.Type DateOfBirth = typeof(System.DateTime);
            }
            #endregion

            #region " - Sub NEW -"

            public datPerson()
            {
                SetDefaults();
            }

            public datPerson(System.String FirstName_In, System.String LastName_In, System.String Gender_In, System.String PhoneNumber_In, System.String StreetAddress_In, System.String StreetAddress2_In, System.String City_In, System.String Prov_In, System.String PostalCode_In, System.DateTime DateOfBirth_In)
            {
                SetDefaults();
                _FirstName = FirstName_In;
                _LastName = LastName_In;
                _Gender = Gender_In;
                _PhoneNumber = PhoneNumber_In;
                _StreetAddress = StreetAddress_In;
                _StreetAddress2 = StreetAddress2_In;
                _City = City_In;
                _Prov = Prov_In;
                _PostalCode = PostalCode_In;
                _DateOfBirth = DateOfBirth_In;
            }

            #endregion
            private void SetDefaults()
            {
                PersonID = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Gender = string.Empty;
                PhoneNumber = string.Empty;
                StreetAddress = string.Empty;
                StreetAddress2 = string.Empty;
                City = string.Empty;
                Prov = string.Empty;
                PostalCode = string.Empty;
                DateOfBirth = System.DateTime.Now;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _PersonID;
                public static System.Int32 PersonID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PersonID] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [PersonID] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _FirstName;
                public static System.String FirstName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [FirstName] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _FirstName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [FirstName] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _FirstName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _LastName;
                public static System.String LastName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [LastName] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _LastName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [LastName] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _LastName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _Gender;
                public static System.String Gender
                {
                    get
                    {
                        System.String value = null;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Gender] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Gender));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [Gender] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Gender));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PhoneNumber;
                public static System.String PhoneNumber
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PhoneNumber] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PhoneNumber));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [PhoneNumber] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PhoneNumber));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _StreetAddress;
                public static System.String StreetAddress
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [StreetAddress] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _StreetAddress));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [StreetAddress] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _StreetAddress));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _StreetAddress2;
                public static System.String StreetAddress2
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [StreetAddress2] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _StreetAddress2));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [StreetAddress2] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _StreetAddress2));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _City;
                public static System.String City
                {
                    get
                    {
                        System.String value = null;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [City] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _City));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [City] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _City));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _Prov;
                public static System.String Prov
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Prov] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Prov));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [Prov] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Prov));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PostalCode;
                public static System.String PostalCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PostalCode] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PostalCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [PostalCode] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PostalCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _DateOfBirth;
                public static System.DateTime DateOfBirth
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DateOfBirth] FROM [datPerson] WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DateOfBirth));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPerson] SET [DateOfBirth] = @Value WHERE [PersonID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DateOfBirth));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datPerson lhs, datPerson rhs)
            {
                if (lhs.FirstName == rhs.FirstName && lhs.LastName == rhs.LastName && lhs.Gender == rhs.Gender && lhs.PhoneNumber == rhs.PhoneNumber && lhs.StreetAddress == rhs.StreetAddress && lhs.StreetAddress2 == rhs.StreetAddress2 && lhs.City == rhs.City && lhs.Prov == rhs.Prov && lhs.PostalCode == rhs.PostalCode && lhs.DateOfBirth == rhs.DateOfBirth)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datPerson lhs, datPerson rhs)
            {
                if (lhs.FirstName == rhs.FirstName && lhs.LastName == rhs.LastName && lhs.Gender == rhs.Gender && lhs.PhoneNumber == rhs.PhoneNumber && lhs.StreetAddress == rhs.StreetAddress && lhs.StreetAddress2 == rhs.StreetAddress2 && lhs.City == rhs.City && lhs.Prov == rhs.Prov && lhs.PostalCode == rhs.PostalCode && lhs.DateOfBirth == rhs.DateOfBirth)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datPosts"
        public partial class datPosts
        {
            #region "       - Variable Declarations - "
            private System.Int32 _PostID;
            public System.Int32 PostID
            {
                get
                {
                    return _PostID;
                }
                set
                {
                    _PostID = value;
                }
            }
            private System.Int32 _ForumID;
            public System.Int32 ForumID
            {
                get
                {
                    return _ForumID;
                }
                set
                {
                    _ForumID = value;
                }
            }
            private System.Int32 _ParentID;
            public System.Int32 ParentID
            {
                get
                {
                    return _ParentID;
                }
                set
                {
                    _ParentID = value;
                }
            }
            private System.String _SubjectLine;
            public System.String SubjectLine
            {
                get
                {
                    return _SubjectLine;
                }
                set
                {
                    _SubjectLine = value;
                }
            }
            private System.DateTime _PostedDate;
            public System.DateTime PostedDate
            {
                get
                {
                    return _PostedDate;
                }
                set
                {
                    _PostedDate = value;
                }
            }
            private System.Boolean _IsActive;
            public System.Boolean IsActive
            {
                get
                {
                    return _IsActive;
                }
                set
                {
                    _IsActive = value;
                }
            }
            private System.Boolean _IsApproved;
            public System.Boolean IsApproved
            {
                get
                {
                    return _IsApproved;
                }
                set
                {
                    _IsApproved = value;
                }
            }
            private System.Int32 _PersonID;
            public System.Int32 PersonID
            {
                get
                {
                    return _PersonID;
                }
                set
                {
                    _PersonID = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string PostID = "PostID";
                public const string ForumID = "ForumID";
                public const string ParentID = "ParentID";
                public const string SubjectLine = "SubjectLine";
                public const string PostedDate = "PostedDate";
                public const string IsActive = "IsActive";
                public const string IsApproved = "IsApproved";
                public const string PersonID = "PersonID";

                public enum ColumnNames
                {
                    PostID,
                    ForumID,
                    ParentID,
                    SubjectLine,
                    PostedDate,
                    IsActive,
                    IsApproved,
                    PersonID,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.PostID:
                            {
                                return PostID;
                            }
                        case ColumnNames.ForumID:
                            {
                                return ForumID;
                            }
                        case ColumnNames.ParentID:
                            {
                                return ParentID;
                            }
                        case ColumnNames.SubjectLine:
                            {
                                return SubjectLine;
                            }
                        case ColumnNames.PostedDate:
                            {
                                return PostedDate;
                            }
                        case ColumnNames.IsActive:
                            {
                                return IsActive;
                            }
                        case ColumnNames.IsApproved:
                            {
                                return IsApproved;
                            }
                        case ColumnNames.PersonID:
                            {
                                return PersonID;
                            }
                        default:
                            return PostID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type PostID = typeof(System.Int32);
                public static System.Type ForumID = typeof(System.Int32);
                public static System.Type ParentID = typeof(System.Int32);
                public static System.Type SubjectLine = typeof(System.String);
                public static System.Type PostedDate = typeof(System.DateTime);
                public static System.Type IsActive = typeof(System.Boolean);
                public static System.Type IsApproved = typeof(System.Boolean);
                public static System.Type PersonID = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public datPosts()
            {
                SetDefaults();
            }

            public datPosts(System.Int32 ForumID_In, System.Int32 ParentID_In, System.String SubjectLine_In, System.DateTime PostedDate_In, System.Boolean IsActive_In, System.Boolean IsApproved_In, System.Int32 PersonID_In)
            {
                SetDefaults();
                _ForumID = ForumID_In;
                _ParentID = ParentID_In;
                _SubjectLine = SubjectLine_In;
                _PostedDate = PostedDate_In;
                _IsActive = IsActive_In;
                _IsApproved = IsApproved_In;
                _PersonID = PersonID_In;
            }

            #endregion
            private void SetDefaults()
            {
                PostID = 0;
                ForumID = 0;
                ParentID = 0;
                SubjectLine = string.Empty;
                PostedDate = System.DateTime.Now;
                IsActive = true;
                IsApproved = true;
                PersonID = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _PostID;
                public static System.Int32 PostID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PostID] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PostID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [PostID] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PostID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ForumID;
                public static System.Int32 ForumID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ForumID] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [ForumID] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ParentID;
                public static System.Int32 ParentID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ParentID] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ParentID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [ParentID] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ParentID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _SubjectLine;
                public static System.String SubjectLine
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [SubjectLine] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SubjectLine));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [SubjectLine] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SubjectLine));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _PostedDate;
                public static System.DateTime PostedDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PostedDate] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PostedDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [PostedDate] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PostedDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsActive] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [IsActive] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsApproved;
                public static System.Boolean IsApproved
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsApproved] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [IsApproved] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _PersonID;
                public static System.Int32 PersonID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PersonID] FROM [datPosts] WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datPosts] SET [PersonID] = @Value WHERE [PostID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
                public static bool IsApproved(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsApproved;
                    ReadWrite.IsApproved = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datPosts lhs, datPosts rhs)
            {
                if (lhs.ForumID == rhs.ForumID && lhs.ParentID == rhs.ParentID && lhs.SubjectLine == rhs.SubjectLine && lhs.PostedDate == rhs.PostedDate && lhs.IsActive == rhs.IsActive && lhs.IsApproved == rhs.IsApproved && lhs.PersonID == rhs.PersonID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datPosts lhs, datPosts rhs)
            {
                if (lhs.ForumID == rhs.ForumID && lhs.ParentID == rhs.ParentID && lhs.SubjectLine == rhs.SubjectLine && lhs.PostedDate == rhs.PostedDate && lhs.IsActive == rhs.IsActive && lhs.IsApproved == rhs.IsApproved && lhs.PersonID == rhs.PersonID)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datQuestionOptions"
        public partial class datQuestionOptions
        {
            #region "       - Variable Declarations - "
            private System.Int32 _optionID;
            public System.Int32 optionID
            {
                get
                {
                    return _optionID;
                }
                set
                {
                    _optionID = value;
                }
            }
            private System.Int32 _questionID;
            public System.Int32 questionID
            {
                get
                {
                    return _questionID;
                }
                set
                {
                    _questionID = value;
                }
            }
            private System.String _optionText;
            public System.String optionText
            {
                get
                {
                    return _optionText;
                }
                set
                {
                    _optionText = value;
                }
            }
            private System.Int32 _displayOrder;
            public System.Int32 displayOrder
            {
                get
                {
                    return _displayOrder;
                }
                set
                {
                    _displayOrder = value;
                }
            }
            private System.Int32 _defaultOption;
            public System.Int32 defaultOption
            {
                get
                {
                    return _defaultOption;
                }
                set
                {
                    _defaultOption = value;
                }
            }
            private System.Boolean _isCorrect;
            public System.Boolean isCorrect
            {
                get
                {
                    return _isCorrect;
                }
                set
                {
                    _isCorrect = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string optionID = "optionID";
                public const string questionID = "questionID";
                public const string optionText = "optionText";
                public const string displayOrder = "displayOrder";
                public const string defaultOption = "defaultOption";
                public const string isCorrect = "isCorrect";

                public enum ColumnNames
                {
                    optionID,
                    questionID,
                    optionText,
                    displayOrder,
                    defaultOption,
                    isCorrect,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.optionID:
                            {
                                return optionID;
                            }
                        case ColumnNames.questionID:
                            {
                                return questionID;
                            }
                        case ColumnNames.optionText:
                            {
                                return optionText;
                            }
                        case ColumnNames.displayOrder:
                            {
                                return displayOrder;
                            }
                        case ColumnNames.defaultOption:
                            {
                                return defaultOption;
                            }
                        case ColumnNames.isCorrect:
                            {
                                return isCorrect;
                            }
                        default:
                            return optionID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type optionID = typeof(System.Int32);
                public static System.Type questionID = typeof(System.Int32);
                public static System.Type optionText = typeof(System.String);
                public static System.Type displayOrder = typeof(System.Int32);
                public static System.Type defaultOption = typeof(System.Int32);
                public static System.Type isCorrect = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datQuestionOptions()
            {
                SetDefaults();
            }

            public datQuestionOptions(System.Int32 questionID_In, System.String optionText_In, System.Int32 displayOrder_In, System.Int32 defaultOption_In, System.Boolean isCorrect_In)
            {
                SetDefaults();
                _questionID = questionID_In;
                _optionText = optionText_In;
                _displayOrder = displayOrder_In;
                _defaultOption = defaultOption_In;
                _isCorrect = isCorrect_In;
            }

            #endregion
            private void SetDefaults()
            {
                optionID = 0;
                questionID = 0;
                optionText = string.Empty;
                displayOrder = 0;
                defaultOption = 0;
                isCorrect = false;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _OptionID;
                public static System.Int32 OptionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [optionID] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _OptionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [optionID] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _OptionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _QuestionID;
                public static System.Int32 QuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionID] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [questionID] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _OptionText;
                public static System.String OptionText
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [optionText] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _OptionText));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [optionText] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _OptionText));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [displayOrder] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [displayOrder] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DefaultOption;
                public static System.Int32 DefaultOption
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [defaultOption] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DefaultOption));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [defaultOption] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DefaultOption));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsCorrect;
                public static System.Boolean IsCorrect
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isCorrect] FROM [datQuestionOptions] WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsCorrect));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datQuestionOptions] SET [isCorrect] = @Value WHERE [optionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsCorrect));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsCorrect(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsCorrect;
                    ReadWrite.IsCorrect = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datQuestionOptions lhs, datQuestionOptions rhs)
            {
                if (lhs.questionID == rhs.questionID && lhs.optionText == rhs.optionText && lhs.displayOrder == rhs.displayOrder && lhs.defaultOption == rhs.defaultOption && lhs.isCorrect == rhs.isCorrect)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datQuestionOptions lhs, datQuestionOptions rhs)
            {
                if (lhs.questionID == rhs.questionID && lhs.optionText == rhs.optionText && lhs.displayOrder == rhs.displayOrder && lhs.defaultOption == rhs.defaultOption && lhs.isCorrect == rhs.isCorrect)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datSurveyQuestions"
        public partial class datSurveyQuestions
        {
            #region "       - Variable Declarations - "
            private System.Int32 _questionID;
            public System.Int32 questionID
            {
                get
                {
                    return _questionID;
                }
                set
                {
                    _questionID = value;
                }
            }
            private System.String _questionType;
            public System.String questionType
            {
                get
                {
                    return _questionType;
                }
                set
                {
                    _questionType = value;
                }
            }
            private System.String _questionText;
            public System.String questionText
            {
                get
                {
                    return _questionText;
                }
                set
                {
                    _questionText = value;
                }
            }
            private System.Boolean _hasOtherOption;
            public System.Boolean hasOtherOption
            {
                get
                {
                    return _hasOtherOption;
                }
                set
                {
                    _hasOtherOption = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string questionID = "questionID";
                public const string questionType = "questionType";
                public const string questionText = "questionText";
                public const string hasOtherOption = "hasOtherOption";

                public enum ColumnNames
                {
                    questionID,
                    questionType,
                    questionText,
                    hasOtherOption,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.questionID:
                            {
                                return questionID;
                            }
                        case ColumnNames.questionType:
                            {
                                return questionType;
                            }
                        case ColumnNames.questionText:
                            {
                                return questionText;
                            }
                        case ColumnNames.hasOtherOption:
                            {
                                return hasOtherOption;
                            }
                        default:
                            return questionID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type questionID = typeof(System.Int32);
                public static System.Type questionType = typeof(System.String);
                public static System.Type questionText = typeof(System.String);
                public static System.Type hasOtherOption = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public datSurveyQuestions()
            {
                SetDefaults();
            }

            public datSurveyQuestions(System.String questionType_In, System.String questionText_In, System.Boolean hasOtherOption_In)
            {
                SetDefaults();
                _questionType = questionType_In;
                _questionText = questionText_In;
                _hasOtherOption = hasOtherOption_In;
            }

            #endregion
            private void SetDefaults()
            {
                questionID = 0;
                questionType = string.Empty;
                questionText = string.Empty;
                hasOtherOption = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _QuestionID;
                public static System.Int32 QuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionID] FROM [datSurveyQuestions] WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveyQuestions] SET [questionID] = @Value WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _QuestionType;
                public static System.String QuestionType
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionType] FROM [datSurveyQuestions] WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionType));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveyQuestions] SET [questionType] = @Value WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionType));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _QuestionText;
                public static System.String QuestionText
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionText] FROM [datSurveyQuestions] WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionText));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveyQuestions] SET [questionText] = @Value WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionText));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _HasOtherOption;
                public static System.Boolean HasOtherOption
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [hasOtherOption] FROM [datSurveyQuestions] WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _HasOtherOption));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveyQuestions] SET [hasOtherOption] = @Value WHERE [questionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _HasOtherOption));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool HasOtherOption(System.Int32 Key)
                {
                    bool Value = ReadWrite.HasOtherOption;
                    ReadWrite.HasOtherOption = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datSurveyQuestions lhs, datSurveyQuestions rhs)
            {
                if (lhs.questionType == rhs.questionType && lhs.questionText == rhs.questionText && lhs.hasOtherOption == rhs.hasOtherOption)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datSurveyQuestions lhs, datSurveyQuestions rhs)
            {
                if (lhs.questionType == rhs.questionType && lhs.questionText == rhs.questionText && lhs.hasOtherOption == rhs.hasOtherOption)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class datSurveys"
        public partial class datSurveys
        {
            #region "       - Variable Declarations - "
            private System.Int32 _surveyID;
            public System.Int32 surveyID
            {
                get
                {
                    return _surveyID;
                }
                set
                {
                    _surveyID = value;
                }
            }
            private System.String _surveyName;
            public System.String surveyName
            {
                get
                {
                    return _surveyName;
                }
                set
                {
                    _surveyName = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            private System.DateTime _dtEffective;
            public System.DateTime dtEffective
            {
                get
                {
                    return _dtEffective;
                }
                set
                {
                    _dtEffective = value;
                }
            }
            private System.DateTime _dtExpiry;
            public System.DateTime dtExpiry
            {
                get
                {
                    return _dtExpiry;
                }
                set
                {
                    _dtExpiry = value;
                }
            }
            private System.Int32 _reqToPass;
            public System.Int32 reqToPass
            {
                get
                {
                    return _reqToPass;
                }
                set
                {
                    _reqToPass = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string surveyID = "surveyID";
                public const string surveyName = "surveyName";
                public const string isActive = "isActive";
                public const string dtEffective = "dtEffective";
                public const string dtExpiry = "dtExpiry";
                public const string reqToPass = "reqToPass";

                public enum ColumnNames
                {
                    surveyID,
                    surveyName,
                    isActive,
                    dtEffective,
                    dtExpiry,
                    reqToPass,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.surveyID:
                            {
                                return surveyID;
                            }
                        case ColumnNames.surveyName:
                            {
                                return surveyName;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        case ColumnNames.dtEffective:
                            {
                                return dtEffective;
                            }
                        case ColumnNames.dtExpiry:
                            {
                                return dtExpiry;
                            }
                        case ColumnNames.reqToPass:
                            {
                                return reqToPass;
                            }
                        default:
                            return surveyID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type surveyID = typeof(System.Int32);
                public static System.Type surveyName = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
                public static System.Type dtEffective = typeof(System.DateTime);
                public static System.Type dtExpiry = typeof(System.DateTime);
                public static System.Type reqToPass = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public datSurveys()
            {
                SetDefaults();
            }

            public datSurveys(System.String surveyName_In, System.Boolean isActive_In, System.DateTime dtEffective_In, System.DateTime dtExpiry_In, System.Int32 reqToPass_In)
            {
                SetDefaults();
                _surveyName = surveyName_In;
                _isActive = isActive_In;
                _dtEffective = dtEffective_In;
                _dtExpiry = dtExpiry_In;
                _reqToPass = reqToPass_In;
            }

            #endregion
            private void SetDefaults()
            {
                surveyID = 0;
                surveyName = string.Empty;
                isActive = true;
                dtEffective = System.DateTime.Now;
                dtExpiry = System.DateTime.Now;
                reqToPass = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _SurveyID;
                public static System.Int32 SurveyID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [surveyID] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [surveyID] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _SurveyName;
                public static System.String SurveyName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [surveyName] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [surveyName] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [isActive] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _DtEffective;
                public static System.DateTime DtEffective
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [dtEffective] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DtEffective));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [dtEffective] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DtEffective));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _DtExpiry;
                public static System.DateTime DtExpiry
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [dtExpiry] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DtExpiry));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [dtExpiry] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DtExpiry));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ReqToPass;
                public static System.Int32 ReqToPass
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [reqToPass] FROM [datSurveys] WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ReqToPass));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [datSurveys] SET [reqToPass] = @Value WHERE [surveyID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ReqToPass));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(datSurveys lhs, datSurveys rhs)
            {
                if (lhs.surveyName == rhs.surveyName && lhs.isActive == rhs.isActive && lhs.dtEffective == rhs.dtEffective && lhs.dtExpiry == rhs.dtExpiry && lhs.reqToPass == rhs.reqToPass)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(datSurveys lhs, datSurveys rhs)
            {
                if (lhs.surveyName == rhs.surveyName && lhs.isActive == rhs.isActive && lhs.dtEffective == rhs.dtEffective && lhs.dtExpiry == rhs.dtExpiry && lhs.reqToPass == rhs.reqToPass)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class jncClassForum"
        public partial class jncClassForum
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ItemID;
            public System.Int32 ItemID
            {
                get
                {
                    return _ItemID;
                }
                set
                {
                    _ItemID = value;
                }
            }
            private System.Int32 _ForumID;
            public System.Int32 ForumID
            {
                get
                {
                    return _ForumID;
                }
                set
                {
                    _ForumID = value;
                }
            }
            private System.String _ClassCode;
            public System.String ClassCode
            {
                get
                {
                    return _ClassCode;
                }
                set
                {
                    _ClassCode = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ItemID = "ItemID";
                public const string ForumID = "ForumID";
                public const string ClassCode = "ClassCode";

                public enum ColumnNames
                {
                    ItemID,
                    ForumID,
                    ClassCode,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ItemID:
                            {
                                return ItemID;
                            }
                        case ColumnNames.ForumID:
                            {
                                return ForumID;
                            }
                        case ColumnNames.ClassCode:
                            {
                                return ClassCode;
                            }
                        default:
                            return ItemID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ItemID = typeof(System.Int32);
                public static System.Type ForumID = typeof(System.Int32);
                public static System.Type ClassCode = typeof(System.String);
            }
            #endregion

            #region " - Sub NEW -"

            public jncClassForum()
            {
                SetDefaults();
            }

            public jncClassForum(System.Int32 ForumID_In, System.String ClassCode_In)
            {
                SetDefaults();
                _ForumID = ForumID_In;
                _ClassCode = ClassCode_In;
            }

            #endregion
            private void SetDefaults()
            {
                ItemID = 0;
                ForumID = 0;
                ClassCode = string.Empty;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _ItemID;
                public static System.Int32 ItemID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ItemID] FROM [jncClassForum] WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ItemID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassForum] SET [ItemID] = @Value WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ItemID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ForumID;
                public static System.Int32 ForumID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ForumID] FROM [jncClassForum] WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassForum] SET [ForumID] = @Value WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ForumID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ClassCode;
                public static System.String ClassCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassCode] FROM [jncClassForum] WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassForum] SET [ClassCode] = @Value WHERE [ItemID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(jncClassForum lhs, jncClassForum rhs)
            {
                if (lhs.ForumID == rhs.ForumID && lhs.ClassCode == rhs.ClassCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(jncClassForum lhs, jncClassForum rhs)
            {
                if (lhs.ForumID == rhs.ForumID && lhs.ClassCode == rhs.ClassCode)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class jncClassStudents"
        public partial class jncClassStudents
        {
            #region "       - Variable Declarations - "
            private System.Int32 _StudentProgressID;
            public System.Int32 StudentProgressID
            {
                get
                {
                    return _StudentProgressID;
                }
                set
                {
                    _StudentProgressID = value;
                }
            }
            private System.Int32 _ClientID;
            public System.Int32 ClientID
            {
                get
                {
                    return _ClientID;
                }
                set
                {
                    _ClientID = value;
                }
            }
            private System.String _ClassCode;
            public System.String ClassCode
            {
                get
                {
                    return _ClassCode;
                }
                set
                {
                    _ClassCode = value;
                }
            }
            private System.Int32 _Marks;
            public System.Int32 Marks
            {
                get
                {
                    return _Marks;
                }
                set
                {
                    _Marks = value;
                }
            }
            private System.Boolean _hasStarted;
            public System.Boolean hasStarted
            {
                get
                {
                    return _hasStarted;
                }
                set
                {
                    _hasStarted = value;
                }
            }
            private System.Boolean _hasCompleted;
            public System.Boolean hasCompleted
            {
                get
                {
                    return _hasCompleted;
                }
                set
                {
                    _hasCompleted = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string StudentProgressID = "StudentProgressID";
                public const string ClientID = "ClientID";
                public const string ClassCode = "ClassCode";
                public const string Marks = "Marks";
                public const string hasStarted = "hasStarted";
                public const string hasCompleted = "hasCompleted";

                public enum ColumnNames
                {
                    StudentProgressID,
                    ClientID,
                    ClassCode,
                    Marks,
                    hasStarted,
                    hasCompleted,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.StudentProgressID:
                            {
                                return StudentProgressID;
                            }
                        case ColumnNames.ClientID:
                            {
                                return ClientID;
                            }
                        case ColumnNames.ClassCode:
                            {
                                return ClassCode;
                            }
                        case ColumnNames.Marks:
                            {
                                return Marks;
                            }
                        case ColumnNames.hasStarted:
                            {
                                return hasStarted;
                            }
                        case ColumnNames.hasCompleted:
                            {
                                return hasCompleted;
                            }
                        default:
                            return StudentProgressID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type StudentProgressID = typeof(System.Int32);
                public static System.Type ClientID = typeof(System.Int32);
                public static System.Type ClassCode = typeof(System.String);
                public static System.Type Marks = typeof(System.Byte);
                public static System.Type hasStarted = typeof(System.Boolean);
                public static System.Type hasCompleted = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public jncClassStudents()
            {
                SetDefaults();
            }

            public jncClassStudents(System.Int32 ClientID_In, System.String ClassCode_In, System.Int32 Marks_In, System.Boolean hasStarted_In, System.Boolean hasCompleted_In)
            {
                SetDefaults();
                _ClientID = ClientID_In;
                _ClassCode = ClassCode_In;
                _Marks = Marks_In;
                _hasStarted = hasStarted_In;
                _hasCompleted = hasCompleted_In;
            }

            #endregion
            private void SetDefaults()
            {
                StudentProgressID = 0;
                ClientID = 0;
                ClassCode = string.Empty;
                Marks = 0;
                hasStarted = false;
                hasCompleted = false;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _StudentProgressID;
                public static System.Int32 StudentProgressID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [StudentProgressID] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _StudentProgressID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [StudentProgressID] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _StudentProgressID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ClientID;
                public static System.Int32 ClientID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClientID] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [ClientID] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClientID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ClassCode;
                public static System.String ClassCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassCode] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [ClassCode] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _Marks;
                public static System.Int32 Marks
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Marks] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Marks));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [Marks] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Marks));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _HasStarted;
                public static System.Boolean HasStarted
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [hasStarted] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _HasStarted));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [hasStarted] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _HasStarted));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _HasCompleted;
                public static System.Boolean HasCompleted
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [hasCompleted] FROM [jncClassStudents] WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _HasCompleted));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncClassStudents] SET [hasCompleted] = @Value WHERE [StudentProgressID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _HasCompleted));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool HasStarted(System.Int32 Key)
                {
                    bool Value = ReadWrite.HasStarted;
                    ReadWrite.HasStarted = !Value;
                    return Value;
                }
                public static bool HasCompleted(System.Int32 Key)
                {
                    bool Value = ReadWrite.HasCompleted;
                    ReadWrite.HasCompleted = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(jncClassStudents lhs, jncClassStudents rhs)
            {
                if (lhs.ClientID == rhs.ClientID && lhs.ClassCode == rhs.ClassCode && lhs.Marks == rhs.Marks && lhs.hasStarted == rhs.hasStarted && lhs.hasCompleted == rhs.hasCompleted)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(jncClassStudents lhs, jncClassStudents rhs)
            {
                if (lhs.ClientID == rhs.ClientID && lhs.ClassCode == rhs.ClassCode && lhs.Marks == rhs.Marks && lhs.hasStarted == rhs.hasStarted && lhs.hasCompleted == rhs.hasCompleted)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class jncCoachClasses"
        public partial class jncCoachClasses
        {
            #region "       - Variable Declarations - "
            private System.Int32 _TeachingID;
            public System.Int32 TeachingID
            {
                get
                {
                    return _TeachingID;
                }
                set
                {
                    _TeachingID = value;
                }
            }
            private System.Int32 _CoachID;
            public System.Int32 CoachID
            {
                get
                {
                    return _CoachID;
                }
                set
                {
                    _CoachID = value;
                }
            }
            private System.String _ClassCode;
            public System.String ClassCode
            {
                get
                {
                    return _ClassCode;
                }
                set
                {
                    _ClassCode = value;
                }
            }
            private System.String _Role;
            public System.String Role
            {
                get
                {
                    return _Role;
                }
                set
                {
                    _Role = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string TeachingID = "TeachingID";
                public const string CoachID = "CoachID";
                public const string ClassCode = "ClassCode";
                public const string Role = "Role";

                public enum ColumnNames
                {
                    TeachingID,
                    CoachID,
                    ClassCode,
                    Role,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.TeachingID:
                            {
                                return TeachingID;
                            }
                        case ColumnNames.CoachID:
                            {
                                return CoachID;
                            }
                        case ColumnNames.ClassCode:
                            {
                                return ClassCode;
                            }
                        case ColumnNames.Role:
                            {
                                return Role;
                            }
                        default:
                            return TeachingID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type TeachingID = typeof(System.Int32);
                public static System.Type CoachID = typeof(System.Int32);
                public static System.Type ClassCode = typeof(System.String);
                public static System.Type Role = typeof(System.String);
            }
            #endregion

            #region " - Sub NEW -"

            public jncCoachClasses()
            {
                SetDefaults();
            }

            public jncCoachClasses(System.Int32 CoachID_In, System.String ClassCode_In, System.String Role_In)
            {
                SetDefaults();
                _CoachID = CoachID_In;
                _ClassCode = ClassCode_In;
                _Role = Role_In;
            }

            #endregion
            private void SetDefaults()
            {
                TeachingID = 0;
                CoachID = 0;
                ClassCode = string.Empty;
                Role = string.Empty;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _TeachingID;
                public static System.Int32 TeachingID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [TeachingID] FROM [jncCoachClasses] WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _TeachingID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCoachClasses] SET [TeachingID] = @Value WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _TeachingID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _CoachID;
                public static System.Int32 CoachID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CoachID] FROM [jncCoachClasses] WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CoachID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCoachClasses] SET [CoachID] = @Value WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CoachID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ClassCode;
                public static System.String ClassCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ClassCode] FROM [jncCoachClasses] WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCoachClasses] SET [ClassCode] = @Value WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ClassCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _Role;
                public static System.String Role
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Role] FROM [jncCoachClasses] WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Role));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCoachClasses] SET [Role] = @Value WHERE [TeachingID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Role));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(jncCoachClasses lhs, jncCoachClasses rhs)
            {
                if (lhs.CoachID == rhs.CoachID && lhs.ClassCode == rhs.ClassCode && lhs.Role == rhs.Role)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(jncCoachClasses lhs, jncCoachClasses rhs)
            {
                if (lhs.CoachID == rhs.CoachID && lhs.ClassCode == rhs.ClassCode && lhs.Role == rhs.Role)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class jncCurriculumSection"
        public partial class jncCurriculumSection
        {
            #region "       - Variable Declarations - "
            private System.Int32 _SectionID;
            public System.Int32 SectionID
            {
                get
                {
                    return _SectionID;
                }
                set
                {
                    _SectionID = value;
                }
            }
            private System.Int32 _CurriculumID;
            public System.Int32 CurriculumID
            {
                get
                {
                    return _CurriculumID;
                }
                set
                {
                    _CurriculumID = value;
                }
            }
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
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string SectionID = "SectionID";
                public const string CurriculumID = "CurriculumID";
                public const string PageID = "PageID";

                public enum ColumnNames
                {
                    SectionID,
                    CurriculumID,
                    PageID,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.SectionID:
                            {
                                return SectionID;
                            }
                        case ColumnNames.CurriculumID:
                            {
                                return CurriculumID;
                            }
                        case ColumnNames.PageID:
                            {
                                return PageID;
                            }
                        default:
                            return SectionID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type SectionID = typeof(System.Int32);
                public static System.Type CurriculumID = typeof(System.Int32);
                public static System.Type PageID = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public jncCurriculumSection()
            {
                SetDefaults();
            }

            public jncCurriculumSection(System.Int32 CurriculumID_In, System.Int32 PageID_In)
            {
                SetDefaults();
                _CurriculumID = CurriculumID_In;
                _PageID = PageID_In;
            }

            #endregion
            private void SetDefaults()
            {
                SectionID = 0;
                CurriculumID = 0;
                PageID = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _SectionID;
                public static System.Int32 SectionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [SectionID] FROM [jncCurriculumSection] WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SectionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCurriculumSection] SET [SectionID] = @Value WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SectionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _CurriculumID;
                public static System.Int32 CurriculumID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CurriculumID] FROM [jncCurriculumSection] WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CurriculumID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCurriculumSection] SET [CurriculumID] = @Value WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CurriculumID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _PageID;
                public static System.Int32 PageID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PageID] FROM [jncCurriculumSection] WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncCurriculumSection] SET [PageID] = @Value WHERE [SectionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(jncCurriculumSection lhs, jncCurriculumSection rhs)
            {
                if (lhs.CurriculumID == rhs.CurriculumID && lhs.PageID == rhs.PageID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(jncCurriculumSection lhs, jncCurriculumSection rhs)
            {
                if (lhs.CurriculumID == rhs.CurriculumID && lhs.PageID == rhs.PageID)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class jncUsersToPeople"
        public partial class jncUsersToPeople
        {
            #region "       - Variable Declarations - "
            private System.String _id;
            public System.String id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }
            private System.Int32 _personID;
            public System.Int32 personID
            {
                get
                {
                    return _personID;
                }
                set
                {
                    _personID = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string id = "id";
                public const string personID = "personID";

                public enum ColumnNames
                {
                    id,
                    personID,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.id:
                            {
                                return id;
                            }
                        case ColumnNames.personID:
                            {
                                return personID;
                            }
                        default:
                            return id;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type id = typeof(System.String);
                public static System.Type personID = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public jncUsersToPeople()
            {
                SetDefaults();
            }

            public jncUsersToPeople(System.Int32 personID_In)
            {
                SetDefaults();
                _personID = personID_In;
            }

            #endregion
            private void SetDefaults()
            {
                id = string.Empty;
                personID = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _Id;
                public static System.String Id
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [id] FROM [jncUsersToPeople] WHERE [id] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncUsersToPeople] SET [id] = @Value WHERE [id] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _PersonID;
                public static System.Int32 PersonID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [personID] FROM [jncUsersToPeople] WHERE [id] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [jncUsersToPeople] SET [personID] = @Value WHERE [id] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PersonID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(jncUsersToPeople lhs, jncUsersToPeople rhs)
            {
                if (lhs.personID == rhs.personID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(jncUsersToPeople lhs, jncUsersToPeople rhs)
            {
                if (lhs.personID == rhs.personID)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class linkSurveysQuestions"
        public partial class linkSurveysQuestions
        {
            #region "       - Variable Declarations - "
            private System.Int32 _surveyQuestionID;
            public System.Int32 surveyQuestionID
            {
                get
                {
                    return _surveyQuestionID;
                }
                set
                {
                    _surveyQuestionID = value;
                }
            }
            private System.Int32 _surveyID;
            public System.Int32 surveyID
            {
                get
                {
                    return _surveyID;
                }
                set
                {
                    _surveyID = value;
                }
            }
            private System.Int32 _questionID;
            public System.Int32 questionID
            {
                get
                {
                    return _questionID;
                }
                set
                {
                    _questionID = value;
                }
            }
            private System.Int32 _displayOrder;
            public System.Int32 displayOrder
            {
                get
                {
                    return _displayOrder;
                }
                set
                {
                    _displayOrder = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string surveyQuestionID = "surveyQuestionID";
                public const string surveyID = "surveyID";
                public const string questionID = "questionID";
                public const string displayOrder = "displayOrder";

                public enum ColumnNames
                {
                    surveyQuestionID,
                    surveyID,
                    questionID,
                    displayOrder,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.surveyQuestionID:
                            {
                                return surveyQuestionID;
                            }
                        case ColumnNames.surveyID:
                            {
                                return surveyID;
                            }
                        case ColumnNames.questionID:
                            {
                                return questionID;
                            }
                        case ColumnNames.displayOrder:
                            {
                                return displayOrder;
                            }
                        default:
                            return surveyQuestionID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type surveyQuestionID = typeof(System.Int32);
                public static System.Type surveyID = typeof(System.Int32);
                public static System.Type questionID = typeof(System.Int32);
                public static System.Type displayOrder = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public linkSurveysQuestions()
            {
                SetDefaults();
            }

            public linkSurveysQuestions(System.Int32 surveyID_In, System.Int32 questionID_In, System.Int32 displayOrder_In)
            {
                SetDefaults();
                _surveyID = surveyID_In;
                _questionID = questionID_In;
                _displayOrder = displayOrder_In;
            }

            #endregion
            private void SetDefaults()
            {
                surveyQuestionID = 0;
                surveyID = 0;
                questionID = 0;
                displayOrder = 0;
            }

            #region "           - ReadWrites - "
            public class ReadWrite
            {


                private static System.Int32 _SurveyQuestionID;
                public static System.Int32 SurveyQuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [surveyQuestionID] FROM [linkSurveysQuestions] WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [linkSurveysQuestions] SET [surveyQuestionID] = @Value WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyQuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _SurveyID;
                public static System.Int32 SurveyID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [surveyID] FROM [linkSurveysQuestions] WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [linkSurveysQuestions] SET [surveyID] = @Value WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SurveyID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _QuestionID;
                public static System.Int32 QuestionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionID] FROM [linkSurveysQuestions] WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [linkSurveysQuestions] SET [questionID] = @Value WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [displayOrder] FROM [linkSurveysQuestions] WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [linkSurveysQuestions] SET [displayOrder] = @Value WHERE [surveyQuestionID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(linkSurveysQuestions lhs, linkSurveysQuestions rhs)
            {
                if (lhs.surveyID == rhs.surveyID && lhs.questionID == rhs.questionID && lhs.displayOrder == rhs.displayOrder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(linkSurveysQuestions lhs, linkSurveysQuestions rhs)
            {
                if (lhs.surveyID == rhs.surveyID && lhs.questionID == rhs.questionID && lhs.displayOrder == rhs.displayOrder)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpCountry"
        public partial class lkpCountry
        {
            #region "       - Variable Declarations - "
            private System.String _CountryID;
            public System.String CountryID
            {
                get
                {
                    return _CountryID;
                }
                set
                {
                    _CountryID = value;
                }
            }
            private System.String _CountryName;
            public System.String CountryName
            {
                get
                {
                    return _CountryName;
                }
                set
                {
                    _CountryName = value;
                }
            }
            private System.Int32 _DisplayOrder;
            public System.Int32 DisplayOrder
            {
                get
                {
                    return _DisplayOrder;
                }
                set
                {
                    _DisplayOrder = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string CountryID = "CountryID";
                public const string CountryName = "CountryName";
                public const string DisplayOrder = "DisplayOrder";

                public enum ColumnNames
                {
                    CountryID,
                    CountryName,
                    DisplayOrder,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.CountryID:
                            {
                                return CountryID;
                            }
                        case ColumnNames.CountryName:
                            {
                                return CountryName;
                            }
                        case ColumnNames.DisplayOrder:
                            {
                                return DisplayOrder;
                            }
                        default:
                            return CountryID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type CountryID = typeof(System.String);
                public static System.Type CountryName = typeof(System.String);
                public static System.Type DisplayOrder = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpCountry()
            {
                SetDefaults();
            }

            public lkpCountry(System.String CountryName_In, System.Int32 DisplayOrder_In)
            {
                SetDefaults();
                _CountryName = CountryName_In;
                _DisplayOrder = DisplayOrder_In;
            }

            #endregion
            private void SetDefaults()
            {
                CountryID = string.Empty;
                CountryName = string.Empty;
                DisplayOrder = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _CountryID;
                public static System.String CountryID
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CountryID] FROM [lkpCountry] WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CountryID));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpCountry] SET [CountryID] = @Value WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CountryID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CountryName;
                public static System.String CountryName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CountryName] FROM [lkpCountry] WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CountryName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpCountry] SET [CountryName] = @Value WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CountryName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DisplayOrder] FROM [lkpCountry] WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpCountry] SET [DisplayOrder] = @Value WHERE [CountryID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpCountry lhs, lkpCountry rhs)
            {
                if (lhs.CountryName == rhs.CountryName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpCountry lhs, lkpCountry rhs)
            {
                if (lhs.CountryName == rhs.CountryName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpDesignation"
        public partial class lkpDesignation
        {
            #region "       - Variable Declarations - "
            private System.String _DesignationID;
            public System.String DesignationID
            {
                get
                {
                    return _DesignationID;
                }
                set
                {
                    _DesignationID = value;
                }
            }
            private System.String _DesignationName;
            public System.String DesignationName
            {
                get
                {
                    return _DesignationName;
                }
                set
                {
                    _DesignationName = value;
                }
            }
            private System.Int32 _DisplayOrder;
            public System.Int32 DisplayOrder
            {
                get
                {
                    return _DisplayOrder;
                }
                set
                {
                    _DisplayOrder = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string DesignationID = "DesignationID";
                public const string DesignationName = "DesignationName";
                public const string DisplayOrder = "DisplayOrder";

                public enum ColumnNames
                {
                    DesignationID,
                    DesignationName,
                    DisplayOrder,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.DesignationID:
                            {
                                return DesignationID;
                            }
                        case ColumnNames.DesignationName:
                            {
                                return DesignationName;
                            }
                        case ColumnNames.DisplayOrder:
                            {
                                return DisplayOrder;
                            }
                        default:
                            return DesignationID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type DesignationID = typeof(System.String);
                public static System.Type DesignationName = typeof(System.String);
                public static System.Type DisplayOrder = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpDesignation()
            {
                SetDefaults();
            }

            public lkpDesignation(System.String DesignationName_In, System.Int32 DisplayOrder_In)
            {
                SetDefaults();
                _DesignationName = DesignationName_In;
                _DisplayOrder = DisplayOrder_In;
            }

            #endregion
            private void SetDefaults()
            {
                DesignationID = string.Empty;
                DesignationName = string.Empty;
                DisplayOrder = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _DesignationID;
                public static System.String DesignationID
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DesignationID] FROM [lkpDesignation] WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationID));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpDesignation] SET [DesignationID] = @Value WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _DesignationName;
                public static System.String DesignationName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DesignationName] FROM [lkpDesignation] WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpDesignation] SET [DesignationName] = @Value WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DesignationName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DisplayOrder] FROM [lkpDesignation] WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpDesignation] SET [DisplayOrder] = @Value WHERE [DesignationID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpDesignation lhs, lkpDesignation rhs)
            {
                if (lhs.DesignationName == rhs.DesignationName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpDesignation lhs, lkpDesignation rhs)
            {
                if (lhs.DesignationName == rhs.DesignationName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpGender"
        public partial class lkpGender
        {
            #region "       - Variable Declarations - "
            private System.String _GenderID;
            public System.String GenderID
            {
                get
                {
                    return _GenderID;
                }
                set
                {
                    _GenderID = value;
                }
            }
            private System.String _GenderName;
            public System.String GenderName
            {
                get
                {
                    return _GenderName;
                }
                set
                {
                    _GenderName = value;
                }
            }
            private System.Int32 _DisplayOrder;
            public System.Int32 DisplayOrder
            {
                get
                {
                    return _DisplayOrder;
                }
                set
                {
                    _DisplayOrder = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string GenderID = "GenderID";
                public const string GenderName = "GenderName";
                public const string DisplayOrder = "DisplayOrder";

                public enum ColumnNames
                {
                    GenderID,
                    GenderName,
                    DisplayOrder,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.GenderID:
                            {
                                return GenderID;
                            }
                        case ColumnNames.GenderName:
                            {
                                return GenderName;
                            }
                        case ColumnNames.DisplayOrder:
                            {
                                return DisplayOrder;
                            }
                        default:
                            return GenderID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type GenderID = typeof(System.String);
                public static System.Type GenderName = typeof(System.String);
                public static System.Type DisplayOrder = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpGender()
            {
                SetDefaults();
            }

            public lkpGender(System.String GenderName_In, System.Int32 DisplayOrder_In)
            {
                SetDefaults();
                _GenderName = GenderName_In;
                _DisplayOrder = DisplayOrder_In;
            }

            #endregion
            private void SetDefaults()
            {
                GenderID = string.Empty;
                GenderName = string.Empty;
                DisplayOrder = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _GenderID;
                public static System.String GenderID
                {
                    get
                    {
                        System.String value = null;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [GenderID] FROM [lkpGender] WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _GenderID));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpGender] SET [GenderID] = @Value WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _GenderID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _GenderName;
                public static System.String GenderName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [GenderName] FROM [lkpGender] WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _GenderName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpGender] SET [GenderName] = @Value WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _GenderName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _DisplayOrder;
                public static System.Int32 DisplayOrder
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [DisplayOrder] FROM [lkpGender] WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpGender] SET [DisplayOrder] = @Value WHERE [GenderID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DisplayOrder));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpGender lhs, lkpGender rhs)
            {
                if (lhs.GenderName == rhs.GenderName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpGender lhs, lkpGender rhs)
            {
                if (lhs.GenderName == rhs.GenderName && lhs.DisplayOrder == rhs.DisplayOrder)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpProvinces"
        public partial class lkpProvinces
        {
            #region "       - Variable Declarations - "
            private System.String _ProvinceCode;
            public System.String ProvinceCode
            {
                get
                {
                    return _ProvinceCode;
                }
                set
                {
                    _ProvinceCode = value;
                }
            }
            private System.String _ProvinceName;
            public System.String ProvinceName
            {
                get
                {
                    return _ProvinceName;
                }
                set
                {
                    _ProvinceName = value;
                }
            }
            private System.String _CountryID;
            public System.String CountryID
            {
                get
                {
                    return _CountryID;
                }
                set
                {
                    _CountryID = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ProvinceCode = "ProvinceCode";
                public const string ProvinceName = "ProvinceName";
                public const string CountryID = "CountryID";

                public enum ColumnNames
                {
                    ProvinceCode,
                    ProvinceName,
                    CountryID,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ProvinceCode:
                            {
                                return ProvinceCode;
                            }
                        case ColumnNames.ProvinceName:
                            {
                                return ProvinceName;
                            }
                        case ColumnNames.CountryID:
                            {
                                return CountryID;
                            }
                        default:
                            return ProvinceCode;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ProvinceCode = typeof(System.String);
                public static System.Type ProvinceName = typeof(System.String);
                public static System.Type CountryID = typeof(System.String);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpProvinces()
            {
                SetDefaults();
            }

            public lkpProvinces(System.String ProvinceName_In, System.String CountryID_In)
            {
                SetDefaults();
                _ProvinceName = ProvinceName_In;
                _CountryID = CountryID_In;
            }

            #endregion
            private void SetDefaults()
            {
                ProvinceCode = string.Empty;
                ProvinceName = string.Empty;
                CountryID = string.Empty;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _ProvinceCode;
                public static System.String ProvinceCode
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ProvinceCode] FROM [lkpProvinces] WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ProvinceCode));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpProvinces] SET [ProvinceCode] = @Value WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ProvinceCode));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _ProvinceName;
                public static System.String ProvinceName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ProvinceName] FROM [lkpProvinces] WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ProvinceName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpProvinces] SET [ProvinceName] = @Value WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ProvinceName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _CountryID;
                public static System.String CountryID
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [CountryID] FROM [lkpProvinces] WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _CountryID));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpProvinces] SET [CountryID] = @Value WHERE [ProvinceCode] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _CountryID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpProvinces lhs, lkpProvinces rhs)
            {
                if (lhs.ProvinceName == rhs.ProvinceName && lhs.CountryID == rhs.CountryID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpProvinces lhs, lkpProvinces rhs)
            {
                if (lhs.ProvinceName == rhs.ProvinceName && lhs.CountryID == rhs.CountryID)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpSocialMedia"
        public partial class lkpSocialMedia
        {
            #region "       - Variable Declarations - "
            private System.Int32 _smID;
            public System.Int32 smID
            {
                get
                {
                    return _smID;
                }
                set
                {
                    _smID = value;
                }
            }
            private System.String _smName;
            public System.String smName
            {
                get
                {
                    return _smName;
                }
                set
                {
                    _smName = value;
                }
            }
            private System.String _smIconURL;
            public System.String smIconURL
            {
                get
                {
                    return _smIconURL;
                }
                set
                {
                    _smIconURL = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string smID = "smID";
                public const string smName = "smName";
                public const string smIconURL = "smIconURL";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    smID,
                    smName,
                    smIconURL,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.smID:
                            {
                                return smID;
                            }
                        case ColumnNames.smName:
                            {
                                return smName;
                            }
                        case ColumnNames.smIconURL:
                            {
                                return smIconURL;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return smID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type smID = typeof(System.Int32);
                public static System.Type smName = typeof(System.String);
                public static System.Type smIconURL = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpSocialMedia()
            {
                SetDefaults();
            }

            public lkpSocialMedia(System.String smName_In, System.String smIconURL_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _smName = smName_In;
                _smIconURL = smIconURL_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                smID = 0;
                smName = string.Empty;
                smIconURL = string.Empty;
                isActive = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _SmID;
                public static System.Int32 SmID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [smID] FROM [lkpSocialMedia] WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SmID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSocialMedia] SET [smID] = @Value WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SmID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _SmName;
                public static System.String SmName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [smName] FROM [lkpSocialMedia] WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SmName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSocialMedia] SET [smName] = @Value WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SmName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _SmIconURL;
                public static System.String SmIconURL
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [smIconURL] FROM [lkpSocialMedia] WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _SmIconURL));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSocialMedia] SET [smIconURL] = @Value WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _SmIconURL));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [lkpSocialMedia] WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSocialMedia] SET [isActive] = @Value WHERE [smID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpSocialMedia lhs, lkpSocialMedia rhs)
            {
                if (lhs.smName == rhs.smName && lhs.smIconURL == rhs.smIconURL && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpSocialMedia lhs, lkpSocialMedia rhs)
            {
                if (lhs.smName == rhs.smName && lhs.smIconURL == rhs.smIconURL && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class lkpSurveyQuestionTypes"
        public partial class lkpSurveyQuestionTypes
        {
            #region "       - Variable Declarations - "
            private System.String _questionType;
            public System.String questionType
            {
                get
                {
                    return _questionType;
                }
                set
                {
                    _questionType = value;
                }
            }
            private System.String _qtDescription;
            public System.String qtDescription
            {
                get
                {
                    return _qtDescription;
                }
                set
                {
                    _qtDescription = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string questionType = "questionType";
                public const string qtDescription = "qtDescription";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    questionType,
                    qtDescription,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.questionType:
                            {
                                return questionType;
                            }
                        case ColumnNames.qtDescription:
                            {
                                return qtDescription;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return questionType;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type questionType = typeof(System.String);
                public static System.Type qtDescription = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public lkpSurveyQuestionTypes()
            {
                SetDefaults();
            }

            public lkpSurveyQuestionTypes(System.String qtDescription_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _qtDescription = qtDescription_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                questionType = string.Empty;
                qtDescription = string.Empty;
                isActive = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.String _QuestionType;
                public static System.String QuestionType
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [questionType] FROM [lkpSurveyQuestionTypes] WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionType));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSurveyQuestionTypes] SET [questionType] = @Value WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QuestionType));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _QtDescription;
                public static System.String QtDescription
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [qtDescription] FROM [lkpSurveyQuestionTypes] WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _QtDescription));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSurveyQuestionTypes] SET [qtDescription] = @Value WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _QtDescription));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [lkpSurveyQuestionTypes] WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [lkpSurveyQuestionTypes] SET [isActive] = @Value WHERE [questionType] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.String Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(lkpSurveyQuestionTypes lhs, lkpSurveyQuestionTypes rhs)
            {
                if (lhs.qtDescription == rhs.qtDescription && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(lkpSurveyQuestionTypes lhs, lkpSurveyQuestionTypes rhs)
            {
                if (lhs.qtDescription == rhs.qtDescription && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class ts_Pages"
        public partial class ts_Pages
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ID;
            public System.Int32 ID
            {
                get
                {
                    return _ID;
                }
                set
                {
                    _ID = value;
                }
            }
            private System.Int32 _parentID;
            public System.Int32 parentID
            {
                get
                {
                    return _parentID;
                }
                set
                {
                    _parentID = value;
                }
            }
            private System.String _pageTitle;
            public System.String pageTitle
            {
                get
                {
                    return _pageTitle;
                }
                set
                {
                    _pageTitle = value;
                }
            }
            private System.String _pageName;
            public System.String pageName
            {
                get
                {
                    return _pageName;
                }
                set
                {
                    _pageName = value;
                }
            }
            private System.Boolean _IsSystemRequiredPage;
            public System.Boolean IsSystemRequiredPage
            {
                get
                {
                    return _IsSystemRequiredPage;
                }
                set
                {
                    _IsSystemRequiredPage = value;
                }
            }
            private System.Boolean _IsDefault;
            public System.Boolean IsDefault
            {
                get
                {
                    return _IsDefault;
                }
                set
                {
                    _IsDefault = value;
                }
            }
            private System.DateTime _ExpiryDate;
            public System.DateTime ExpiryDate
            {
                get
                {
                    return _ExpiryDate;
                }
                set
                {
                    _ExpiryDate = value;
                }
            }
            private System.DateTime _EffectiveDate;
            public System.DateTime EffectiveDate
            {
                get
                {
                    return _EffectiveDate;
                }
                set
                {
                    _EffectiveDate = value;
                }
            }
            private System.Boolean _IsActive;
            public System.Boolean IsActive
            {
                get
                {
                    return _IsActive;
                }
                set
                {
                    _IsActive = value;
                }
            }
            private System.String _MasterPage;
            public System.String MasterPage
            {
                get
                {
                    return _MasterPage;
                }
                set
                {
                    _MasterPage = value;
                }
            }
            private System.String _Theme;
            public System.String Theme
            {
                get
                {
                    return _Theme;
                }
                set
                {
                    _Theme = value;
                }
            }
            private System.Boolean _IsSecure;
            public System.Boolean IsSecure
            {
                get
                {
                    return _IsSecure;
                }
                set
                {
                    _IsSecure = value;
                }
            }
            private System.Int32 _PageType;
            public System.Int32 PageType
            {
                get
                {
                    return _PageType;
                }
                set
                {
                    _PageType = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ID = "ID";
                public const string parentID = "parentID";
                public const string pageTitle = "pageTitle";
                public const string pageName = "pageName";
                public const string IsSystemRequiredPage = "IsSystemRequiredPage";
                public const string IsDefault = "IsDefault";
                public const string ExpiryDate = "ExpiryDate";
                public const string EffectiveDate = "EffectiveDate";
                public const string IsActive = "IsActive";
                public const string MasterPage = "MasterPage";
                public const string Theme = "Theme";
                public const string IsSecure = "IsSecure";
                public const string PageType = "PageType";

                public enum ColumnNames
                {
                    ID,
                    parentID,
                    pageTitle,
                    pageName,
                    IsSystemRequiredPage,
                    IsDefault,
                    ExpiryDate,
                    EffectiveDate,
                    IsActive,
                    MasterPage,
                    Theme,
                    IsSecure,
                    PageType,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ID:
                            {
                                return ID;
                            }
                        case ColumnNames.parentID:
                            {
                                return parentID;
                            }
                        case ColumnNames.pageTitle:
                            {
                                return pageTitle;
                            }
                        case ColumnNames.pageName:
                            {
                                return pageName;
                            }
                        case ColumnNames.IsSystemRequiredPage:
                            {
                                return IsSystemRequiredPage;
                            }
                        case ColumnNames.IsDefault:
                            {
                                return IsDefault;
                            }
                        case ColumnNames.ExpiryDate:
                            {
                                return ExpiryDate;
                            }
                        case ColumnNames.EffectiveDate:
                            {
                                return EffectiveDate;
                            }
                        case ColumnNames.IsActive:
                            {
                                return IsActive;
                            }
                        case ColumnNames.MasterPage:
                            {
                                return MasterPage;
                            }
                        case ColumnNames.Theme:
                            {
                                return Theme;
                            }
                        case ColumnNames.IsSecure:
                            {
                                return IsSecure;
                            }
                        case ColumnNames.PageType:
                            {
                                return PageType;
                            }
                        default:
                            return ID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ID = typeof(System.Int32);
                public static System.Type parentID = typeof(System.Int32);
                public static System.Type pageTitle = typeof(System.String);
                public static System.Type pageName = typeof(System.String);
                public static System.Type IsSystemRequiredPage = typeof(System.Boolean);
                public static System.Type IsDefault = typeof(System.Boolean);
                public static System.Type ExpiryDate = typeof(System.DateTime);
                public static System.Type EffectiveDate = typeof(System.DateTime);
                public static System.Type IsActive = typeof(System.Boolean);
                public static System.Type MasterPage = typeof(System.String);
                public static System.Type Theme = typeof(System.String);
                public static System.Type IsSecure = typeof(System.Boolean);
                public static System.Type PageType = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public ts_Pages()
            {
                SetDefaults();
            }

            public ts_Pages(System.Int32 parentID_In, System.String pageTitle_In, System.String pageName_In, System.Boolean IsSystemRequiredPage_In, System.Boolean IsDefault_In, System.DateTime ExpiryDate_In, System.DateTime EffectiveDate_In, System.Boolean IsActive_In, System.String MasterPage_In, System.String Theme_In, System.Boolean IsSecure_In, System.Int32 PageType_In)
            {
                SetDefaults();
                _parentID = parentID_In;
                _pageTitle = pageTitle_In;
                _pageName = pageName_In;
                _IsSystemRequiredPage = IsSystemRequiredPage_In;
                _IsDefault = IsDefault_In;
                _ExpiryDate = ExpiryDate_In;
                _EffectiveDate = EffectiveDate_In;
                _IsActive = IsActive_In;
                _MasterPage = MasterPage_In;
                _Theme = Theme_In;
                _IsSecure = IsSecure_In;
                _PageType = PageType_In;
            }

            #endregion
            private void SetDefaults()
            {
                ID = 0;
                parentID = 0;
                pageTitle = string.Empty;
                pageName = string.Empty;
                IsSystemRequiredPage = false;
                IsDefault = false;
                ExpiryDate = System.DateTime.Now;
                EffectiveDate = System.DateTime.Now;
                IsActive = true;
                MasterPage = string.Empty;
                Theme = string.Empty;
                IsSecure = false;
                PageType = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _Id;
                public static System.Int32 Id
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ID] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [ID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ParentID;
                public static System.Int32 ParentID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [parentID] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ParentID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [parentID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ParentID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PageTitle;
                public static System.String PageTitle
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [pageTitle] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageTitle));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [pageTitle] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageTitle));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PageName;
                public static System.String PageName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [pageName] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [pageName] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsSystemRequiredPage;
                public static System.Boolean IsSystemRequiredPage
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsSystemRequiredPage] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsSystemRequiredPage));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [IsSystemRequiredPage] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsSystemRequiredPage));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsDefault;
                public static System.Boolean IsDefault
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsDefault] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsDefault));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [IsDefault] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsDefault));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _ExpiryDate;
                public static System.DateTime ExpiryDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ExpiryDate] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ExpiryDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [ExpiryDate] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ExpiryDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _EffectiveDate;
                public static System.DateTime EffectiveDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [EffectiveDate] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _EffectiveDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [EffectiveDate] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _EffectiveDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsActive] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [IsActive] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _MasterPage;
                public static System.String MasterPage
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [MasterPage] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _MasterPage));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [MasterPage] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _MasterPage));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _Theme;
                public static System.String Theme
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Theme] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Theme));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [Theme] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Theme));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsSecure;
                public static System.Boolean IsSecure
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsSecure] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsSecure));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [IsSecure] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsSecure));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _PageType;
                public static System.Int32 PageType
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PageType] FROM [ts_Pages] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageType));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_Pages] SET [PageType] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageType));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsSystemRequiredPage(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsSystemRequiredPage;
                    ReadWrite.IsSystemRequiredPage = !Value;
                    return Value;
                }
                public static bool IsDefault(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsDefault;
                    ReadWrite.IsDefault = !Value;
                    return Value;
                }
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
                public static bool IsSecure(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsSecure;
                    ReadWrite.IsSecure = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(ts_Pages lhs, ts_Pages rhs)
            {
                if (lhs.parentID == rhs.parentID && lhs.pageTitle == rhs.pageTitle && lhs.pageName == rhs.pageName && lhs.IsSystemRequiredPage == rhs.IsSystemRequiredPage && lhs.IsDefault == rhs.IsDefault && lhs.ExpiryDate == rhs.ExpiryDate && lhs.EffectiveDate == rhs.EffectiveDate && lhs.IsActive == rhs.IsActive && lhs.MasterPage == rhs.MasterPage && lhs.Theme == rhs.Theme && lhs.IsSecure == rhs.IsSecure && lhs.PageType == rhs.PageType)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(ts_Pages lhs, ts_Pages rhs)
            {
                if (lhs.parentID == rhs.parentID && lhs.pageTitle == rhs.pageTitle && lhs.pageName == rhs.pageName && lhs.IsSystemRequiredPage == rhs.IsSystemRequiredPage && lhs.IsDefault == rhs.IsDefault && lhs.ExpiryDate == rhs.ExpiryDate && lhs.EffectiveDate == rhs.EffectiveDate && lhs.IsActive == rhs.IsActive && lhs.MasterPage == rhs.MasterPage && lhs.Theme == rhs.Theme && lhs.IsSecure == rhs.IsSecure && lhs.PageType == rhs.PageType)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class ts_PageTypes"
        public partial class ts_PageTypes
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ID;
            public System.Int32 ID
            {
                get
                {
                    return _ID;
                }
                set
                {
                    _ID = value;
                }
            }
            private System.String _PageType;
            public System.String PageType
            {
                get
                {
                    return _PageType;
                }
                set
                {
                    _PageType = value;
                }
            }
            private System.Boolean _IsUsed;
            public System.Boolean IsUsed
            {
                get
                {
                    return _IsUsed;
                }
                set
                {
                    _IsUsed = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ID = "ID";
                public const string PageType = "PageType";
                public const string IsUsed = "IsUsed";

                public enum ColumnNames
                {
                    ID,
                    PageType,
                    IsUsed,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ID:
                            {
                                return ID;
                            }
                        case ColumnNames.PageType:
                            {
                                return PageType;
                            }
                        case ColumnNames.IsUsed:
                            {
                                return IsUsed;
                            }
                        default:
                            return ID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ID = typeof(System.Int32);
                public static System.Type PageType = typeof(System.String);
                public static System.Type IsUsed = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public ts_PageTypes()
            {
                SetDefaults();
            }

            public ts_PageTypes(System.String PageType_In, System.Boolean IsUsed_In)
            {
                SetDefaults();
                _PageType = PageType_In;
                _IsUsed = IsUsed_In;
            }

            #endregion
            private void SetDefaults()
            {
                ID = 0;
                PageType = string.Empty;
                IsUsed = true;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _Id;
                public static System.Int32 Id
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ID] FROM [ts_PageTypes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageTypes] SET [ID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PageType;
                public static System.String PageType
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PageType] FROM [ts_PageTypes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageType));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageTypes] SET [PageType] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageType));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsUsed;
                public static System.Boolean IsUsed
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsUsed] FROM [ts_PageTypes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsUsed));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageTypes] SET [IsUsed] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsUsed));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsUsed(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsUsed;
                    ReadWrite.IsUsed = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(ts_PageTypes lhs, ts_PageTypes rhs)
            {
                if (lhs.PageType == rhs.PageType && lhs.IsUsed == rhs.IsUsed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(ts_PageTypes lhs, ts_PageTypes rhs)
            {
                if (lhs.PageType == rhs.PageType && lhs.IsUsed == rhs.IsUsed)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class ts_PageVersionNotes"
        public partial class ts_PageVersionNotes
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ID;
            public System.Int32 ID
            {
                get
                {
                    return _ID;
                }
                set
                {
                    _ID = value;
                }
            }
            private System.Int32 _versionID;
            public System.Int32 versionID
            {
                get
                {
                    return _versionID;
                }
                set
                {
                    _versionID = value;
                }
            }
            private System.String _userName;
            public System.String userName
            {
                get
                {
                    return _userName;
                }
                set
                {
                    _userName = value;
                }
            }
            private System.DateTime _dtAdded;
            public System.DateTime dtAdded
            {
                get
                {
                    return _dtAdded;
                }
                set
                {
                    _dtAdded = value;
                }
            }
            private System.String _Note;
            public System.String Note
            {
                get
                {
                    return _Note;
                }
                set
                {
                    _Note = value;
                }
            }
            private System.Boolean _isActive;
            public System.Boolean isActive
            {
                get
                {
                    return _isActive;
                }
                set
                {
                    _isActive = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ID = "ID";
                public const string versionID = "versionID";
                public const string userName = "userName";
                public const string dtAdded = "dtAdded";
                public const string Note = "Note";
                public const string isActive = "isActive";

                public enum ColumnNames
                {
                    ID,
                    versionID,
                    userName,
                    dtAdded,
                    Note,
                    isActive,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ID:
                            {
                                return ID;
                            }
                        case ColumnNames.versionID:
                            {
                                return versionID;
                            }
                        case ColumnNames.userName:
                            {
                                return userName;
                            }
                        case ColumnNames.dtAdded:
                            {
                                return dtAdded;
                            }
                        case ColumnNames.Note:
                            {
                                return Note;
                            }
                        case ColumnNames.isActive:
                            {
                                return isActive;
                            }
                        default:
                            return ID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ID = typeof(System.Int32);
                public static System.Type versionID = typeof(System.Int32);
                public static System.Type userName = typeof(System.String);
                public static System.Type dtAdded = typeof(System.DateTime);
                public static System.Type Note = typeof(System.String);
                public static System.Type isActive = typeof(System.Boolean);
            }
            #endregion

            #region " - Sub NEW -"

            public ts_PageVersionNotes()
            {
                SetDefaults();
            }

            public ts_PageVersionNotes(System.Int32 versionID_In, System.String userName_In, System.DateTime dtAdded_In, System.String Note_In, System.Boolean isActive_In)
            {
                SetDefaults();
                _versionID = versionID_In;
                _userName = userName_In;
                _dtAdded = dtAdded_In;
                _Note = Note_In;
                _isActive = isActive_In;
            }

            #endregion
            private void SetDefaults()
            {
                ID = 0;
                versionID = 0;
                userName = string.Empty;
                dtAdded = System.DateTime.Now;
                Note = string.Empty;
                isActive = false;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _Id;
                public static System.Int32 Id
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ID] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [ID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _VersionID;
                public static System.Int32 VersionID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [versionID] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _VersionID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [versionID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _VersionID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _UserName;
                public static System.String UserName
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [userName] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _UserName));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [userName] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _UserName));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _DtAdded;
                public static System.DateTime DtAdded
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [dtAdded] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _DtAdded));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [dtAdded] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _DtAdded));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _Note;
                public static System.String Note
                {
                    get
                    {
                        System.String value = null;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [Note] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Note));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [Note] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Note));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsActive;
                public static System.Boolean IsActive
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [isActive] FROM [ts_PageVersionNotes] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersionNotes] SET [isActive] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsActive));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsActive(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsActive;
                    ReadWrite.IsActive = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(ts_PageVersionNotes lhs, ts_PageVersionNotes rhs)
            {
                if (lhs.versionID == rhs.versionID && lhs.userName == rhs.userName && lhs.dtAdded == rhs.dtAdded && lhs.Note == rhs.Note && lhs.isActive == rhs.isActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(ts_PageVersionNotes lhs, ts_PageVersionNotes rhs)
            {
                if (lhs.versionID == rhs.versionID && lhs.userName == rhs.userName && lhs.dtAdded == rhs.dtAdded && lhs.Note == rhs.Note && lhs.isActive == rhs.isActive)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
        #region " - Class ts_PageVersions"
        public partial class ts_PageVersions
        {
            #region "       - Variable Declarations - "
            private System.Int32 _ID;
            public System.Int32 ID
            {
                get
                {
                    return _ID;
                }
                set
                {
                    _ID = value;
                }
            }
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
            private System.String _PageContent;
            public System.String PageContent
            {
                get
                {
                    return _PageContent;
                }
                set
                {
                    _PageContent = value;
                }
            }
            private System.String _MetaKeywords;
            public System.String MetaKeywords
            {
                get
                {
                    return _MetaKeywords;
                }
                set
                {
                    _MetaKeywords = value;
                }
            }
            private System.String _MetaDescription;
            public System.String MetaDescription
            {
                get
                {
                    return _MetaDescription;
                }
                set
                {
                    _MetaDescription = value;
                }
            }
            private System.DateTime _EffectiveDate;
            public System.DateTime EffectiveDate
            {
                get
                {
                    return _EffectiveDate;
                }
                set
                {
                    _EffectiveDate = value;
                }
            }
            private System.Boolean _IsApproved;
            public System.Boolean IsApproved
            {
                get
                {
                    return _IsApproved;
                }
                set
                {
                    _IsApproved = value;
                }
            }
            private System.String _VersionTitle;
            public System.String VersionTitle
            {
                get
                {
                    return _VersionTitle;
                }
                set
                {
                    _VersionTitle = value;
                }
            }
            private System.Int32 _ViewCount;
            public System.Int32 ViewCount
            {
                get
                {
                    return _ViewCount;
                }
                set
                {
                    _ViewCount = value;
                }
            }
            #endregion

            #region "           - Column Definitions - "
            public class Columns
            {
                public const string ID = "ID";
                public const string PageID = "PageID";
                public const string PageContent = "PageContent";
                public const string MetaKeywords = "MetaKeywords";
                public const string MetaDescription = "MetaDescription";
                public const string EffectiveDate = "EffectiveDate";
                public const string IsApproved = "IsApproved";
                public const string VersionTitle = "VersionTitle";
                public const string ViewCount = "ViewCount";

                public enum ColumnNames
                {
                    ID,
                    PageID,
                    PageContent,
                    MetaKeywords,
                    MetaDescription,
                    EffectiveDate,
                    IsApproved,
                    VersionTitle,
                    ViewCount,
                }

                public static string GetColumnName(ColumnNames ColumnEnum)
                {
                    switch (ColumnEnum)
                    {
                        case ColumnNames.ID:
                            {
                                return ID;
                            }
                        case ColumnNames.PageID:
                            {
                                return PageID;
                            }
                        case ColumnNames.PageContent:
                            {
                                return PageContent;
                            }
                        case ColumnNames.MetaKeywords:
                            {
                                return MetaKeywords;
                            }
                        case ColumnNames.MetaDescription:
                            {
                                return MetaDescription;
                            }
                        case ColumnNames.EffectiveDate:
                            {
                                return EffectiveDate;
                            }
                        case ColumnNames.IsApproved:
                            {
                                return IsApproved;
                            }
                        case ColumnNames.VersionTitle:
                            {
                                return VersionTitle;
                            }
                        case ColumnNames.ViewCount:
                            {
                                return ViewCount;
                            }
                        default:
                            return ID;
                    }
                }
            }
            #endregion

            #region "           - Type Definitions - "
            class Types
            {
                public static System.Type ID = typeof(System.Int32);
                public static System.Type PageID = typeof(System.Int32);
                public static System.Type PageContent = typeof(System.String);
                public static System.Type MetaKeywords = typeof(System.String);
                public static System.Type MetaDescription = typeof(System.String);
                public static System.Type EffectiveDate = typeof(System.DateTime);
                public static System.Type IsApproved = typeof(System.Boolean);
                public static System.Type VersionTitle = typeof(System.String);
                public static System.Type ViewCount = typeof(System.Int32);
            }
            #endregion

            #region " - Sub NEW -"

            public ts_PageVersions()
            {
                SetDefaults();
            }

            public ts_PageVersions(System.Int32 PageID_In, System.String PageContent_In, System.String MetaKeywords_In, System.String MetaDescription_In, System.DateTime EffectiveDate_In, System.Boolean IsApproved_In, System.String VersionTitle_In, System.Int32 ViewCount_In)
            {
                SetDefaults();
                _PageID = PageID_In;
                _PageContent = PageContent_In;
                _MetaKeywords = MetaKeywords_In;
                _MetaDescription = MetaDescription_In;
                _EffectiveDate = EffectiveDate_In;
                _IsApproved = IsApproved_In;
                _VersionTitle = VersionTitle_In;
                _ViewCount = ViewCount_In;
            }

            #endregion
            private void SetDefaults()
            {
                ID = 0;
                PageID = 0;
                PageContent = string.Empty;
                MetaKeywords = string.Empty;
                MetaDescription = string.Empty;
                EffectiveDate = System.DateTime.Now;
                IsApproved = true;
                VersionTitle = string.Empty;
                ViewCount = 0;
            }

            #region "           - ReadWrites - "
            class ReadWrite
            {


                private static System.Int32 _Id;
                public static System.Int32 Id
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ID] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [ID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _Id));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _PageID;
                public static System.Int32 PageID
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PageID] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageID));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [PageID] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageID));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _PageContent;
                public static System.String PageContent
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [PageContent] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _PageContent));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [PageContent] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _PageContent));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _MetaKeywords;
                public static System.String MetaKeywords
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [MetaKeywords] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _MetaKeywords));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [MetaKeywords] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _MetaKeywords));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _MetaDescription;
                public static System.String MetaDescription
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [MetaDescription] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _MetaDescription));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [MetaDescription] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _MetaDescription));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.DateTime _EffectiveDate;
                public static System.DateTime EffectiveDate
                {
                    get
                    {
                        System.DateTime value = DateTime.Now;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [EffectiveDate] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _EffectiveDate));
                                connection.Open();
                                try
                                {
                                    value = (System.DateTime)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [EffectiveDate] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _EffectiveDate));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Boolean _IsApproved;
                public static System.Boolean IsApproved
                {
                    get
                    {
                        System.Boolean value = false;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [IsApproved] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                connection.Open();
                                try
                                {
                                    value = (System.Boolean)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [IsApproved] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _IsApproved));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.String _VersionTitle;
                public static System.String VersionTitle
                {
                    get
                    {
                        System.String value = String.Empty;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [VersionTitle] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _VersionTitle));
                                connection.Open();
                                try
                                {
                                    value = (System.String)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [VersionTitle] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _VersionTitle));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                private static System.Int32 _ViewCount;
                public static System.Int32 ViewCount
                {
                    get
                    {
                        System.Int32 value = 0;
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "SELECT TOP 1 [ViewCount] FROM [ts_PageVersions] WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add(new SqlParameter("@Key", _ViewCount));
                                connection.Open();
                                try
                                {
                                    value = (System.Int32)command.ExecuteScalar();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        return value;
                    }

                    set
                    {
                        using (SqlConnection connection = new SqlConnection(Lookups.GetConnString()))
                        {
                            string strSQL = "UPDATE [ts_PageVersions] SET [ViewCount] = @Value WHERE [ID] = @Key";
                            using (SqlCommand command = new SqlCommand(strSQL, connection))
                            {
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                command.Parameters.Add(new SqlParameter("@Key", _ViewCount));
                                command.Parameters.Add(new SqlParameter("@Value", value));
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.StackTrace ST = new System.Diagnostics.StackTrace();
                                    System.Diagnostics.StackFrame SF = ST.GetFrame(0); //Current Method
                                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name + ":" + SF.GetMethod().Name, ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region "           - BitSwitches - "
            public class Switches
            {
                public static bool IsApproved(System.Int32 Key)
                {
                    bool Value = ReadWrite.IsApproved;
                    ReadWrite.IsApproved = !Value;
                    return Value;
                }
            }
            #endregion
            #region "           - Operators - "

            public static bool operator ==(ts_PageVersions lhs, ts_PageVersions rhs)
            {
                if (lhs.PageID == rhs.PageID && lhs.PageContent == rhs.PageContent && lhs.MetaKeywords == rhs.MetaKeywords && lhs.MetaDescription == rhs.MetaDescription && lhs.EffectiveDate == rhs.EffectiveDate && lhs.IsApproved == rhs.IsApproved && lhs.VersionTitle == rhs.VersionTitle && lhs.ViewCount == rhs.ViewCount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(ts_PageVersions lhs, ts_PageVersions rhs)
            {
                if (lhs.PageID == rhs.PageID && lhs.PageContent == rhs.PageContent && lhs.MetaKeywords == rhs.MetaKeywords && lhs.MetaDescription == rhs.MetaDescription && lhs.EffectiveDate == rhs.EffectiveDate && lhs.IsApproved == rhs.IsApproved && lhs.VersionTitle == rhs.VersionTitle && lhs.ViewCount == rhs.ViewCount)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            #endregion
        }
        #endregion
    }



}
