using System;
using System.IO;
using System.Linq;
using System.Web;

namespace MifuminLib.WellKnownUriParser
{
    public class SearchQueryParser
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

        /// <summary>
        /// URI から検索クエリを取得します。
        /// </summary>
        /// <param name="uri">URI。</param>
        /// <returns>検索クエリ。ない場合は <c>null</c>。</returns>
        public virtual string? FromUri(Uri uri)
        {
            switch (uri.Host)
            {
                case "cgi.search.biglobe.ne.jp":
                case "cn.bing.com":
                case "cse.google.co.jp":
                case "decomailer.awalker.jp":
                case "encrypted.google.com":
                case "eonet.jp":
                case "gensun.org":
                case "images.google.co.jp":
                case "images.search.biglobe.ne.jp":
                case "insertmedia.bing.office.net":
                case "isearch.babylon.com":
                case "jwsearch.jword.jp":
                case "mobss.jword.jp":
                case "netlavis.azione.jp":
                case "nortonsafe.search.ask.com":
                case "s.cube-soft.jp":
                case "search.auone.jp":
                case "search.crav-ing.com":
                case "search.dolphin-browser.jp":
                case "search.fenrir-inc.com":
                case "search.fooooo.com":
                case "search.freespot.com":
                case "search.jiqoo.jp":
                case "search.kensakuplus.com":
                case "search.kinza.jp":
                case "search.livedoor.com":
                case "search.myjcom.jp":
                case "search.searchnewsplus.com":
                case "sp-web.search.auone.jp":
                case "v-buster.jword.jp":
                case "websearch.excite.co.jp":
                case "www.bing.com":
                case "www.ecosia.org":
                case "www.google.co.kr":
                case "www.google.com":
                case "www.google.com.br":
                case "www.google.es":
                case "www.google.it":
                case "www.info.com":
                case "www.msn.com":
                case "www.search.ask.com":
                case "www.so.com":
                case "www.searchmobileonline.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.google.co.jp":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "as_q");
                case "cache.yahoofs.jp":
                case "cgi2.nintendo.co.jp":
                case "hk.images.search.yahoo.com":
                case "image.search.yahoo.co.jp":
                case "images.search.yahoo.com":
                case "realtime.search.yahoo.co.jp":
                case "search.yahoo.co.jp":
                case "search.yahoo.com":
                case "th.search.yahoo.com":
                    return GetSearchSimpleQuery(uri, "p");
                case "search.goo.ne.jp":
                case "search.smt.docomo.ne.jp":
                    return GetSearchSimpleQuery(uri, "MT");
                case "app.websearch.rakuten.co.jp":
                case "websearch.rakuten.co.jp":
                    return GetSearchSimpleQuery(uri, "qt");
                case "gtech.starthome.jp":
                case "home.kingsoft.jp":
                case "pex.jp":
                case "wakwakpc.starthome.jp":
                case "www.unisearch.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                case "int.search.myway.com":
                case "int.search.tb.ask.com":
                    return GetSearchSimpleQuery(uri, "searchfor");
                case "docomo.ne.jp":
                case "i.fileseek.jp":
                    return GetSearchSimpleQuery(uri, "key");
                case "ecnavi.jp":
                case "gws.cybozu.net":
                case "search.kawaii.aswidget.com":
                case "search.plushome.aswidget.com":
                case "www.benri.com":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "jp.hao123.com":
                case "www.so-net.ne.jp":
                    return GetSearchSimpleQuery(uri, "query");
                case "search.azby.fmworld.net":
                case "search.nifty.com":
                    return GetSearchSimpleQuery(uri, "Text") ?? GetSearchSimpleQuery(uri, "q");
                case "imagesearch.excite.co.jp":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "search");
                case "japaneseclass.jp":
                    return HttpUtility.UrlDecode(uri.AbsolutePath.Split('/').Last());
                case "guzome.com":
                case "kabegami10.com":
                case "kabukabu.me":
                case "menimeni.com":
                    return HttpUtility.UrlDecode(Path.GetFileNameWithoutExtension(uri.AbsolutePath));
                default:
                    break;
            }
            return null;
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
