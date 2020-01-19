﻿using System;
using System.IO;
using System.Linq;
using System.Web;

namespace MifuminLib.WellKnownUriParser
{
    public partial class SearchQueryParser
    {
        /// <summary>
        /// URI 文字列から検索クエリの取得を試みます。
        /// </summary>
        /// <param name="uriString">URI 文字列。</param>
        /// <param name="query">検索クエリ。取得失敗した場合は、空文字列。</param>
        /// <returns>成功したら <c>true</c>。失敗したら <c>false</c>。</returns>
        public bool TryFromString(string uriString, out string query)
        {
            try
            {
                var parsed = FromString(uriString);
                query = parsed ?? "";
                return parsed != null;
            }
            catch (Exception)
            {
                query = "";
                return false;
            }
        }

        /// <summary>
        /// URI 文字列から検索クエリを取得します。
        /// </summary>
        /// <param name="uriString">URI 文字列。</param>
        /// <returns>検索クエリ。ない場合は <c>null</c>。</returns>
        public string? FromString(string uriString)
        {
            return FromUri(new Uri(uriString));
        }

        protected virtual string? GetSearchSimpleQuery(Uri uri, string key)
        {
            var queries = HttpUtility.ParseQueryString(uri.Query);
            var values = queries.GetValues(key);
            if (values != null && values.Length > 0) return values[0];
            return null;
        }
    }
}
