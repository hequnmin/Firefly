using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace FireflyUI
{
    public class Global
    {
        public string G_ApplicationName;                        //系统名称
        public string G_ApplicationTitle;                       //系统标题
        public string G_ApplicationVersion;

        public Global()
        {
            //系统标题及版本
            G_ApplicationName = "Blueway Firefly";
            G_ApplicationTitle = AssemblyTitle;
            G_ApplicationVersion = AssemblyVersion;

        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

    }
}
