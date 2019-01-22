using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class JsonRetrieve
{
    public class JsonInfo
    {
        public int page;
        public int per_page;
        public int total;
        public int total_pages;

        public struct JsonObj
        {
            public string date;
            public float open;
            public float close;
            public float high;
            public float low;
        }

        public JsonObj[] data;
    }
    /*
     * Complete the function below.
     */
    static void openAndClosePrices(string firstDate, string lastDate, string weekDay)
    {
        DateTime dt1 = DateTime.Parse(firstDate);
        DateTime dt2 = DateTime.Parse(lastDate);

        List<DateTime> weekdayDay = new List<DateTime>();

        for (DateTime dt = dt1; dt <= dt2;)
        {
            if (dt.DayOfWeek.ToString() == weekDay)
            {
                weekdayDay.Add(dt);
            }
            dt = dt.AddDays(1);
        }
        string url;

        using (WebClient webClient = new WebClient())
        {
            string jsonData = string.Empty;
            string searchValue = weekdayDay[0].Day + "-" + weekdayDay[0].ToString("MMMM") + "-" + weekdayDay[0].Year;
            url = "https://jsonmock.hackerrank.com/api/stocks/?key=" + searchValue;

            try
            {
                jsonData = webClient.DownloadString(url);
            }
            catch (Exception) { }

            if (!string.IsNullOrEmpty(jsonData))
            {
                JsonInfo jsonInfo = JsonConvert.DeserializeObject<JsonInfo>(jsonData);
                int counter = 0;
                for (int a = 0; a < jsonInfo.data.Length; a++)
                {
                    for (int b = 0; b < weekdayDay.Count; b++)
                    {
                        if (DateTime.Parse(jsonInfo.data[a].date.ToString()) == weekdayDay[b])
                        {
                            Console.WriteLine(jsonInfo.data[a].date + " " + jsonInfo.data[a].open + " " + jsonInfo.data[a].close);
                            counter++;
                        }
                    }
                    if (DateTime.Parse(jsonInfo.data[a].date) > dt2)
                    {
                        break;
                    }
                }
            }
        }
    }

    static void Main(String[] args)
    {
        string _firstDate;
        _firstDate = Console.ReadLine();

        string _lastDate;
        _lastDate = Console.ReadLine();

        string _weekDay;
        _weekDay = Console.ReadLine();

        openAndClosePrices(_firstDate, _lastDate, _weekDay);

    }
}
