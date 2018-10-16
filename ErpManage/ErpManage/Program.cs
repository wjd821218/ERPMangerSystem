using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace ErpManage
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //增加访问网络文件，需要用户名与密码的功能2011-3-1
            //try
            //{
            //    string localpath = "X:";
            //    int status = NetWork.Connect(@"\\192.168.1.134\ERPManageServer$", localpath, "administrator", "omivac!QAZ@WSX");
            //}
            //catch { }


            //自动更新是否开启
            string strIsStartAutoUpdate = System.Configuration.ConfigurationSettings.AppSettings["IsStartAutoUpdate"].ToString();
            if (strIsStartAutoUpdate.ToUpper() == "TRUE")
            {
                try
                {
                    //本机程序版本--客户机版本
                    string strClientVer = System.Configuration.ConfigurationSettings.AppSettings["Ver"].ToString();

                    //读取服务器上程序版本
                    string strServerPath = System.Configuration.ConfigurationSettings.AppSettings["ServerPath"].ToString();
                    string fileName = strServerPath + "ErpManage.exe.config";
                    XmlDocument myXmlDocument = new XmlDocument();
                    myXmlDocument.Load(fileName);
                    XmlNode rootNode = myXmlDocument.DocumentElement;
                    XmlNode XmlNode_Ver = rootNode.SelectSingleNode("/configuration/appSettings/add[@key='Ver']");
                   
                    //服务器版本
                    string strServerVer = XmlNode_Ver.Attributes["value"].InnerText; ; //版本在指定位置
                    //服务器版本与客户端版本不同则更新客户端版本为服务器的版本
                    if (strClientVer.Trim() != strServerVer.Trim())
                    {
                        Application.Exit();
                        string arguments = strServerPath;
                        Process.Start(Application.StartupPath + @"\update.exe", arguments);
                    }
                    else
                    {
                        Application.Run(new frmLogin());
                    }
                }
                catch
                {
                    Application.Run(new frmLogin());
                }

            }
            else
            {
                Application.Run(new frmLogin());
            }
        }


    }
        
}