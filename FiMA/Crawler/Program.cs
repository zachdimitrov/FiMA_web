namespace Crawler
{
    using AngleSharp;
    using Fima.Data.DbModels;
    using Fima.Services.Data;
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var db = new KpEntitiesContext();
            var cities = new CitiesService(new FimaRepository<TOWNS>(db));
            var municipalities = new MunicipalitiesService(new FimaRepository<MUNICIPALITY>(db));

            var configuration = Configuration.Default.WithDefaultLoader();
            var browserContext = BrowsingContext.New(configuration);

            // изтегляне на всички градове в България
            var url = $"http://www.nsi.bg/bg/content/2975/%D0%BD%D0%B0%D1%81%D0%B5%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5-%D0%BF%D0%BE-%D0%BE%D0%B1%D0%BB%D0%B0%D1%81%D1%82%D0%B8-%D0%BE%D0%B1%D1%89%D0%B8%D0%BD%D0%B8-%D0%BC%D0%B5%D1%81%D1%82%D0%BE%D0%B6%D0%B8%D0%B2%D0%B5%D0%B5%D0%BD%D0%B5-%D0%B8-%D0%BF%D0%BE%D0%BB";

            var document = browserContext.OpenAsync(url).Result;

            Console.WriteLine("Общински градове в Република България");
            Console.WriteLine("-------------------------------------");

            var townContent = document
                .QuerySelectorAll(".left_top, .boldt")
                .GroupBy(x => x.TextContent.Trim())
                .Select(grp => grp.First())
                .ToArray();

            int addedCities = 0;

            for(int i = 1; i < townContent.Length; ++i)
            {
                var e = townContent[i].TextContent.Trim();
                if (e.Contains("(") || e.Contains("-"))
                {
                    continue;
                }

                int result = cities.Add(e);
                addedCities += result;
                string text = result > 0 ? "- добавен в БД!" : "- съществува";

                Console.WriteLine($"{i}. {e} {text}");
            }
            Console.WriteLine($"\nДобавени са {addedCities} общини в БД!\n");

            Console.WriteLine("Областни градове в Република България");
            Console.WriteLine("-------------------------------------");

            var munContent = document.QuerySelectorAll(".boldt")
                .GroupBy(x => x.TextContent.Trim())
                .Select(grp => grp.First())
                .ToArray();
            
            int addedMuns = 0;

            for (int i = 1; i < munContent.Length; ++i)
            {
                var m = munContent[i].TextContent.Trim();
                if (m.Contains("(") || m.Contains("-"))
                {
                    continue;
                }

                int result = municipalities.Add(m);
                addedMuns += result;
                string text = result > 0 ? "- добавенa в БД!" : "- съществува";

                Console.WriteLine($"{i}. {m} {text}");
            }

            Console.WriteLine($"\nДобавени са {addedMuns} общини в БД!\n");
        }
    }
}
