using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace CarRentalLoader.Class.Managers
{
    public sealed class LogManager
    {
        public static readonly LogManager GlobalLogManager = new LogManager();
        private string fileName = "Log.log";
        private string fileLocation = Application.StartupPath;
        private bool fileAppend = true;
        private static bool logType = false;
        private static bool loggingOn = true;
        private string nameSpace;
        private string methodName;
        private string className;
        private string methodArgs;
        private StreamWriter Writer = null;

        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

        public string FileLocation
        {
            get
            {
                return fileLocation;
            }
            set
            {
                fileLocation = value;
            }
        }

        public bool FileAppend
        {
            get
            {
                return fileAppend;
            }
            set
            {
                fileAppend = value;
            }
        }

        public static bool LoggingOn
        {
            get
            {
                return loggingOn;
            }
            set
            {
                loggingOn = value;
            }
        }

        public static bool LogType
        {
            get
            {
                return logType;
            }
            set
            {
                logType = value;
            }
        }

        private string NameSpace
        {
            get
            {
                InitializeName();
                return nameSpace;
            }
            set
            {
                nameSpace = value;
            }
        }

        private string MethodName
        {
            get
            {
                InitializeName();
                return methodName;
            }
            set
            {
                methodName = value;
            }
        }

        private string MethodArguments
        {
            get
            {
                InitializeName();
                return methodArgs;
            }
            set
            {
                methodArgs = value;
            }
        }

        private string ClassName
        {
            get
            {
                InitializeName();
                return className;
            }
            set
            {
                className = value;
            }
        }

        private StreamWriter MyWriter
        {
            get
            {
                return Writer;
            }
            set
            {
                Writer = value;
            }
        }

        public static LogManager GetLogManager()
        {
            return GlobalLogManager;
        }

        public void StartLog()
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " 记录开始。");
                    }
                    catch (Exception ex)
                    {
                        EventLog.WriteEntry("Application", ex.Message);
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " 记录开始。");
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void StartLog(string strMsg)
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " 记录开始，为" + strMsg + " 创建。");
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " 记录开始，为" + strMsg + " 创建。");
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void CreateLog(string strMsg)
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = new FileLogTraceListener();
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " " + strMsg);
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " " + strMsg);
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void CreateLog(Exception ex)
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = new FileLogTraceListener();
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " 异常记录开始。");
                        logInfo.WriteLine("命名空间： " + NameSpace);
                        logInfo.WriteLine("类名： " + ClassName);
                        logInfo.WriteLine("方法名： " + MethodName);
                        logInfo.WriteLine("方法参数： " + MethodArguments);
                        logInfo.WriteLine("源： " + ex.Source);
                        logInfo.WriteLine("类型： " + ex.GetType().FullName);
                        logInfo.WriteLine("消息： " + ex.Message);
                        logInfo.WriteLine("目标站点： " + ex.TargetSite);
                        logInfo.WriteLine("堆栈跟踪： " + ex.StackTrace);
                        if (ex.InnerException != null)
                        {
                            logInfo.WriteLine("内部异常： " + ex.InnerException);
                        }
                        logInfo.WriteLine("异常记录结束。");
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " 异常记录开始。");
                            MyWriter.WriteLine("命名空间： " + NameSpace);
                            MyWriter.WriteLine("类名： " + ClassName);
                            MyWriter.WriteLine("方法名： " + MethodName);
                            MyWriter.WriteLine("方法参数： " + MethodArguments);
                            MyWriter.WriteLine("源： " + ex.Source);
                            MyWriter.WriteLine("类型： " + ex.GetType().FullName);
                            MyWriter.WriteLine("消息： " + ex.Message);
                            MyWriter.WriteLine("目标站点： " + ex.TargetSite);
                            MyWriter.WriteLine("堆栈跟踪： " + ex.StackTrace);
                            if (ex.InnerException != null)
                            {
                                MyWriter.WriteLine("内部异常： " + ex.InnerException);
                            }
                            MyWriter.WriteLine("异常记录结束。");
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void CreateLog(Exception ex, string strExceptionMsg)
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = new FileLogTraceListener();
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " 异常记录开始。");
                        logInfo.WriteLine(strExceptionMsg);
                        logInfo.WriteLine("命名空间： " + NameSpace);
                        logInfo.WriteLine("类名： " + ClassName);
                        logInfo.WriteLine("方法名： " + MethodName);
                        logInfo.WriteLine("方法参数： " + MethodArguments);
                        logInfo.WriteLine("源： " + ex.Source);
                        logInfo.WriteLine("类型： " + ex.GetType().FullName);
                        logInfo.WriteLine("消息： " + ex.Message);
                        logInfo.WriteLine("目标站点： " + ex.TargetSite);
                        logInfo.WriteLine("堆栈跟踪： " + ex.StackTrace);
                        if (ex.InnerException != null)
                        {
                            logInfo.WriteLine("内部异常： " + ex.InnerException);
                        }
                        logInfo.WriteLine("异常记录结束。");
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " 异常记录开始。");
                            MyWriter.WriteLine(strExceptionMsg);
                            MyWriter.WriteLine("命名空间： " + NameSpace);
                            MyWriter.WriteLine("类名： " + ClassName);
                            MyWriter.WriteLine("方法名： " + MethodName);
                            MyWriter.WriteLine("方法参数： " + MethodArguments);
                            MyWriter.WriteLine("源： " + ex.Source);
                            MyWriter.WriteLine("类型： " + ex.GetType().FullName);
                            MyWriter.WriteLine("消息： " + ex.Message);
                            MyWriter.WriteLine("目标站点： " + ex.TargetSite);
                            MyWriter.WriteLine("堆栈跟踪： " + ex.StackTrace);
                            if (ex.InnerException != null)
                            {
                                MyWriter.WriteLine("内部异常： " + ex.InnerException);
                            }
                            MyWriter.WriteLine("异常记录结束。");
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void CreateExMsgLog(string strMsg)
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " " + strMsg);
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " " + strMsg);
                            MyWriter.Close();
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        public void EndLog()
        {
            if (LoggingOn)
            {
                if (LogType)
                {
                    FileLogTraceListener logInfo = new FileLogTraceListener();
                    try
                    {
                        logInfo = new FileLogTraceListener();
                        logInfo = (FileLogTraceListener)AssignProperty();
                        logInfo.WriteLine(DateTime.Now + " 记录结束。");
                        logInfo.Close();
                    }
                    finally
                    {
                        logInfo.Close();
                    }
                }
                else
                {
                    lock (this)
                    {
                        GetWriter();
                        try
                        {
                            MyWriter.WriteLine(DateTime.Now + " 记录结束。");
                        }
                        finally
                        {
                            MyWriter.Close();
                        }
                    }
                }
            }
        }

        private FileLogTraceListener AssignProperty()
        {
            try
            {
                FileLogTraceListener logInfo;
                logInfo = new FileLogTraceListener();
                logInfo.Append = FileAppend;
                logInfo.BaseFileName = FileName;
                logInfo.CustomLocation = FileLocation;
                logInfo.Location = LogFileLocation.Custom;
                logInfo.AutoFlush = true;
                return logInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetWriter()
        {
            lock (this)
            {
                CloseFile();
                MyWriter = new StreamWriter(FileLocation + "/" + FileName, FileAppend);
            }
        }

        private void CloseFile()
        {
            if (MyWriter != null)
            {
                try
                {
                    MyWriter.Close();
                }
                catch
                {

                }
            }
        }

        private void InitializeName()
        {
            string strParam = string.Empty;
            StackTrace objSTrace = new StackTrace(true);
            if (objSTrace.FrameCount >= 3)
            {
                StackFrame objSFrame = objSTrace.GetFrame(3);
                MethodBase objMethodBase = objSFrame.GetMethod();
                ParameterInfo[] objParamInfo = objMethodBase.GetParameters();
                foreach (ParameterInfo objParam in objParamInfo)
                {
                    if (strParam != string.Empty)
                    {
                        strParam += objParam.ParameterType.Name;
                    }
                    else
                    {
                        strParam += " , " + objParam.ParameterType.Name;
                    }
                    strParam += " , " + objParam.Name;
                }
                NameSpace = objMethodBase.ReflectedType.Namespace;
                ClassName = objMethodBase.ReflectedType.Name;
                MethodName = objMethodBase.Name;
                MethodArguments = strParam == string.Empty ? "无参数" : strParam;
            }
        }
    }
}
