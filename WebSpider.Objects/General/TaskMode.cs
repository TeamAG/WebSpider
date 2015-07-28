using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSpider.Objects.General
{
    public static class TaskMode
    {
        public static String ADI_CRAWL = "CRAWL";
        public static String ADI_UPDATE = "UPDATE";
        public static String ADI_CLEARANCE_ZONE = "CLEARANCE_ZONE";
        public static String ADI_HOT_DEALS = "HOT_DEALS";
        public static String ADI_ONLINE_SPECIALS = "ONLINE_SPECIALS";
        public static String ADI_SALE_CENTER = "SALE_CENTER";
        public static String ADI_IN_STOCK = "IN_STOCK";
    }

    public static class TaskType
    {
        public static string ADI_CATEGORY = "Category";
        public static string ADI_BRAND = "Brand";
        public static string ADI_UPDATE = "Update";
    }
}
