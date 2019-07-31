using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL
{
    public class Errors
    {
        public static bool LogError(string ModuleName, string ErrDescription)
        {
            bool RetVal = false;

            try
            {
                // Dim MyBrowser As Web.HttpBrowserCapabilities
                // MyBrowser = HttpContext.Current.Request.Browser

                // Dim LogE As New DBL.Tables.logErrors(0)
                // LogE.dtTime = Now
                // LogE.ErrorDescription = ErrDescription & ":<br/>" & HttpContext.Current.Request.Url.OriginalString
                // LogE.IPAddress = HttpContext.Current.Request.ServerVariables("REMOTE_ADDR")
                // LogE.UserBrowser = MyBrowser.Type & " - " & MyBrowser.Version
                // LogE.Location = ModuleName
                // LogE.Username = HttpContext.Current.User.Identity.Name
                // LogE.UserOS = MyBrowser.Platform
                // DBL.Tables.logErrors.Insert(LogE)
                RetVal = true;
            }
            catch (Exception ex)
            {
                // Clint: Don't know what to do here as logging the error in the error log would be an endless loop ???
                RetVal = false;
            }

            return RetVal;
        }
    }

}