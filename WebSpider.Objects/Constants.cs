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

        public static String OPEN_TEXT = "Open";
        public static String PENDING_TEXT = "Pending";
        public static String PROCESSING_TEXT = "Processing";
        public static String PAUSED_TEXT = "Paused";
        public static String COMPLETED_TEXT = "Completed";
        public static String CANCELLED_TEXT = "Cancelled";
        public static String COMPLETED_ERROR_TEXT = "Completed with errors";

        public static String EmailErrorFile = "errmail.tmp";
        public static String ApplicationLogFile = "WebSpider_Errors.log";

        public static String ADICatagory = "Category";
        public static String ADIBrand = "Brand";
        public static String ADIProduct = "Product";

        public class SiteName
        {
            public static String ADIGLOBAL = "ADI";
        }

        public class ExportType
        {
            public static String ADI_PRODUCT_CRAWL = "ADI_PRODUCT_CRAWL";
            public static String ADI_PRODUCT_UPDATE = "ADI_PRODUCT_UPDATE";
            public static String ADI_CATEGORY = "ADI_CATEGORY";
            public static String ADI_BRAND = "ADI_BRAND";
        }
    }
}
