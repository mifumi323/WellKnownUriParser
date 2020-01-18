using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace MifuminLib.WellKnownUriParser.UnitTests
{
    public class SearchQueryParserTests
    {
        private readonly SearchQueryParser searchQueryParser = new SearchQueryParser();

        [TestCaseSource(nameof(SearchQueries))]
#pragma warning disable IDE0060 // 未使用のパラメーターを削除します
        public void FromStringTest(string uri, string key, string query)
#pragma warning restore IDE0060 // 未使用のパラメーターを削除します
        {
            Assert.AreEqual(query, searchQueryParser.FromString(uri));
        }

        public static IEnumerable<string[]> SearchQueries => File.ReadAllLines("SearchQueries.csv").Skip(1).Select(line => line.Split(","));
    }
}
