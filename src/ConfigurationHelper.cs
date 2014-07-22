using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace ConfigurationHelper
{
    public static class ConfigurationHelper
    {
        public static NameValueCollection AppSettings
        {
            get
            {
                return ConfigurationManager.AppSettings;
            }
        }

        public static ExtendedNameValueCollection<int> AppIntSettings
        {
            get
            {
                return (ExtendedNameValueCollection<int>)ConfigurationManager.AppSettings;
            }
        }

        public static ConnectionStringSettingsCollection ConnectionStrings
        {
            get
            {
                return ConfigurationManager.ConnectionStrings;
            }
        }

        public static object GetSection(string sectionName)
        {
            return ConfigurationHelper.GetSection(sectionName);
        }

        public static Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel)
        {
            return ConfigurationHelper.OpenExeConfiguration(userLevel);
        }

        public static Configuration OpenExeConfiguration(string exePath)
        {
            return ConfigurationHelper.OpenExeConfiguration(exePath);
        }

        public static Configuration OpenMachineConfiguration()
        {
            return ConfigurationHelper.OpenMachineConfiguration();
        }

        public static Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel)
        {
            return ConfigurationHelper.OpenMappedExeConfiguration(fileMap, userLevel);
        }

        public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap)
        {
            return ConfigurationHelper.OpenMappedMachineConfiguration(fileMap);
        }

        public static void RefreshSection(string sectionName)
        {
            ConfigurationHelper.RefreshSection(sectionName);
        }
    }
}
