using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace MifuminLib.WellKnownUriParser.UnitTests
{
    public class SearchQueryPickerTests
    {
        private readonly SearchQueryPicker searchQueryParser = new();

        [TestCaseSource(nameof(SearchQueries))]
        public void FromStringTest(string uri, string query)
        {
            Assert.AreEqual(query, searchQueryParser.FromString(uri));
        }

        public static IEnumerable<string[]> SearchQueries => File.ReadAllLines("SearchQueries.csv").Skip(1).Select(line => { var p = line.Split(","); return new string[] { p[0], p[2] }; });
    }
}
