using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn.Commons
{
    public static class Constants
    {
        public enum PROJECT_PERMISSION
        {
            OWNER = 502,
            MEMBER = 402
        }

        public enum AUTO_MESSAGING_SENDER
        {
            GOOGLE = 101
        }

        public enum PROJECT_FILTER
        {
            ALL = 0,
            LIST = 1,
            SHARE = 2,
            ARCHIVED = 3
        }

        public enum TRANSACTION_FILTER
        {
            TODAY = 1,
            THIS_WEEK = 2,
            THIS_MONTH = 3,
            THIS_YEAR = 4,
            CUSTOM_DATE = 5,
            CUSTOM_WEEK = 6,
            CUSTOM_MONTH = 7,
            CUSTOM_YEAR = 8,
        }

        public enum TIME_FREQUENCY
        {
            ONCE = 1,
            DAILY = 2,
            WEEKLY = 3,
            MONTHLY = 4,
            YEARLY = 5,
            PERIODICALLY = 6,
        }

        public enum SUBSCIPTION_TYPE
        {
            MONTH = 119,
            THREE_MONTHS = 129,
            SIX_MONTHS = 139,
            YEAR = 169
        }

        public enum TARGET_MARKET
        {
            VN = 39,
            GLOBAL = 79
        }

        public static string IDENTITY_GROUP_ADMINS = "Admins";
        public static string IDENTITY_GROUP_MANAGERS = "Managers";
        public static string IDENTITY_GROUP_USERS = "Users";

        public static string IDENTITY_USER_ADMIN = "Admin";
        public static string IDENTITY_USER_MANAGER = "Manager";
        public static string IDENTITY_USER_USER = "User";

        public static string SYS_TABLE_NAME_PROJECTS = "projects";
        public static string SYS_TABLE_NAME_PROJECT_MEMBERS = "projectmembers";
        public static string SYS_TABLE_NAME_PROJECT_TRANSACTIONS = "transactions";
        public static string SYS_TABLE_NAME_PROJECT_ACCOUNTS = "accounts";
        public static string SYS_TABLE_NAME_PROJECT_CATEGORIES = "categories";

        public static int APP_OBJECT_TYPE_ID_GLOBAL_LOGS = 100;
        public static int APP_OBJECT_TYPE_ID_PROJECT_LOGS = 600;
        public static int APP_OBJECT_TYPE_ID_TRANSACTION_LOGS = 620;
        public static int APP_OBJECT_TYPE_ID_BUDGET_LOGS = 650;
        public static int APP_OBJECT_TYPE_ID_ACCOUNT_LOGS = 670;
        public static int APP_OBJECT_TYPE_ID_CATEGORY_LOGS = 690;

        public static string AUDIT_LOG_TEXT_PROJECT_CREATE = "created project";
        public static string AUDIT_LOG_TEXT_PROJECT_UPDATE = "updated project";
        public static string AUDIT_LOG_TEXT_PROJECT_DELETE = "deleted project";

        public static string AUDIT_LOG_TEXT_PROJECT_ACCOUNT_CREATE = "created account";
        public static string AUDIT_LOG_TEXT_PROJECT_ACCOUNT_UPDATE = "updated account";
        public static string AUDIT_LOG_TEXT_PROJECT_ACCOUNT_DELETE = "deleted account";

        public static string AUDIT_LOG_TEXT_PROJECT_CATEGORY_CREATE = "created category";
        public static string AUDIT_LOG_TEXT_PROJECT_CATEGORY_UPDATE = "updated category";
        public static string AUDIT_LOG_TEXT_PROJECT_CATEGORY_DELETE = "deleted category";

        public static string APP_SETTING_CURRENCY_SYMBOL_DEFAULT = "DefaultCurencySymbol";

        public static string SYS_SETTING_DEFAULT_PROJECT_ACCOUNT_KEY = "default_accounts";
        public static string SYS_SETTING_DEFAULT_PROJECT_INCOME_CATEGORY_KEY = "default_income_categories";
        public static string SYS_SETTING_DEFAULT_PROJECT_EXPENSE_CATEGORY_KEY = "default_expense_categories";

        private static string APP_SETTING_AUDIT_LOG_QUERY_TOP = "AuditLogDisplayItemCount";
        public static int APP_SETTING_AUDIT_LOG_QUERY_TOP_VALUE = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings[Constants.APP_SETTING_AUDIT_LOG_QUERY_TOP]);

        public static string AUTO_EMAIL_TEMPLATE_SYSTEM_ERROR = "972325A5-0621-49C2-B4D8-46A39E734CDD";

        public static string AUDIT_LOG_EVENT_TYPE_ADD = "A";
        public static string AUDIT_LOG_EVENT_TYPE_MODIFY = "M";
        public static string AUDIT_LOG_EVENT_TYPE_DELETE = "D";

        public static byte PROJECT_DEFAULT_FINANCE_YEAR_START_MONTH = 1;
        public static byte PROJECT_DEFAULT_FINANCE_YEAR_MONTHS = 12;

        public static string EXCEPTION_MESSAGE_NOT_FOUND = "Not found";
    }
}
