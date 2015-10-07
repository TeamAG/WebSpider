using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSpider.Objects
{
    public class Constants
    {
        public static String ConnectionString = String.Format("Data Source={0};Persist Security Info=False;", Application.StartupPath + "\\App_Code\\WebSpiderDB.sdf");

        public const String OPEN_TEXT = "Open";
        public const String PENDING_TEXT = "Pending";
        public const String PROCESSING_TEXT = "Processing";
        public const String PAUSED_TEXT = "Paused";
        public const String COMPLETED_TEXT = "Completed";
        public const String CANCELLED_TEXT = "Cancelled";
        public const String COMPLETED_ERROR_TEXT = "Completed with errors";

        public const String EmailErrorFile = "errmail.tmp";
        public const String ApplicationLogFile = "WebSpider_Errors.log";

        public const String ADICatagory = "Category";
        public const String ADIBrand = "Brand";
        public const String ADIProduct = "Product";

        //public const String SecLockManufacurer = "SecLock Manufacturer";
        //public const String SecLockCategory = "SecLock Category";

        public class SiteName
        {
            public const String ADIGLOBAL = "ADI";
            public const String SECLOCK = "SECLOCK";
        }

        public class ExportType
        {
            public const String ADI_PRODUCT_CRAWL = "ADI_PRODUCT_CRAWL";
            public const String ADI_PRODUCT_UPDATE = "ADI_PRODUCT_UPDATE";
            public const String ADI_CATEGORY = "ADI_CATEGORY";
            public const String ADI_BRAND = "ADI_BRAND";

            public const string SECLOCK_MANUFACTURER = "SECLOCK_MANUFACTURER";
            public const string SECLOCK_CATEGORY = "SECLOCK_CATEGORY";
            public const string SECLOCK_CRAWL = "SECLOCK_CRAWL";
            public const string SECLOCK_UPDATE = "SECLOCK_UPDATE";
            public const string SECLOCK_MANUFACTURER_SERIES = "SECLOCK_MANUFACTURER_SERIES";
        }

        public static class TaskMode
        {
            public const String ADI_CRAWL = "CRAWL";
            public const String ADI_UPDATE = "UPDATE";
            public const String ADI_CLEARANCE_ZONE = "CLEARANCE_ZONE";
            public const String ADI_HOT_DEALS = "HOT_DEALS";
            public const String ADI_ONLINE_SPECIALS = "ONLINE_SPECIALS";
            public const String ADI_SALE_CENTER = "SALE_CENTER";
            public const String ADI_IN_STOCK = "IN_STOCK";

            public const string SECLOCK_MANUFACTURER_CRAWL = "SECLOCK_MANUFACTURER_CRAWL";
            public const string SECLOCK_CATEGORY_CRAWL = "SECLOCK_CATEGORY_CRAWL";
            public const string SECLOCK_PRODUCT_UPDATE = "SECLOCK_PRODUCT_UPDATE";
        }

        public static class TaskType
        {
            public const string ADI_CATEGORY = "Category";
            public const string ADI_BRAND = "Brand";
            public const string ADI_UPDATE = "Update";

            public const string SECLOCK_CRAWL = "SecLock Crawl";
            public const string SECLOCK_UPDATE = "SecLock Update";
        }
    }
}
