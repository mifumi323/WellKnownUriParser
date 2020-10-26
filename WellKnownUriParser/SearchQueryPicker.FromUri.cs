﻿#nullable enable
// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY T4. DO NOT CHANGE IT. CHANGE THE .tt FILE INSTEAD.
// </auto-generated>
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace MifuminLib.WellKnownUriParser
{
    public partial class SearchQueryPicker
    {
        /// <summary>
        /// URI から検索クエリを取得します。
        /// </summary>
        /// <param name="uri">URI。</param>
        /// <returns>検索クエリ。ない場合は <c>null</c>。</returns>
        public virtual string? FromUri(Uri uri)
        {
            switch (uri.Host)
            {
                case "app.websearch.rakuten.co.jp":
                    return GetSearchSimpleQuery(uri, "qt");
                case "cache.yahoofs.jp":
                    return GetSearchSimpleQuery(uri, "p");
                case "cgi.search.biglobe.ne.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "cgi2.nintendo.co.jp":
                    return GetSearchSimpleQuery(uri, "p");
                case "cn.bing.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "cse.google.co.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "decomailer.awalker.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "docomo.ne.jp":
                    return GetSearchSimpleQuery(uri, "key");
                case "ecnavi.jp":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "encrypted.google.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "eonet.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "gensun.org":
                    return GetSearchSimpleQuery(uri, "q");
                case "gtech.starthome.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                case "guzome.com":
                    return HttpUtility.UrlDecode(Path.GetFileNameWithoutExtension(uri.AbsolutePath));
                case "gws.cybozu.net":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "hk.images.search.yahoo.com":
                    return GetSearchSimpleQuery(uri, "p");
                case "home.kingsoft.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                case "i.fileseek.jp":
                    return GetSearchSimpleQuery(uri, "key");
                case "image.search.yahoo.co.jp":
                    return GetSearchSimpleQuery(uri, "p");
                case "images.google.co.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "images.search.biglobe.ne.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "images.search.yahoo.com":
                    return GetSearchSimpleQuery(uri, "p");
                case "imagesearch.excite.co.jp":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "search");
                case "insertmedia.bing.office.net":
                    return GetSearchSimpleQuery(uri, "q");
                case "int.search.myway.com":
                    return GetSearchSimpleQuery(uri, "searchfor");
                case "int.search.tb.ask.com":
                    return GetSearchSimpleQuery(uri, "searchfor");
                case "isearch.babylon.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "japaneseclass.jp":
                    return HttpUtility.UrlDecode(uri.AbsolutePath.Split('/').Last());
                case "jp.hao123.com":
                    return GetSearchSimpleQuery(uri, "query");
                case "jwsearch.jword.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "kabegami10.com":
                    return HttpUtility.UrlDecode(Path.GetFileNameWithoutExtension(uri.AbsolutePath));
                case "kabukabu.me":
                    return HttpUtility.UrlDecode(Path.GetFileNameWithoutExtension(uri.AbsolutePath));
                case "kaikatsu.jword.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "menimeni.com":
                    return HttpUtility.UrlDecode(Path.GetFileNameWithoutExtension(uri.AbsolutePath));
                case "mobss.jword.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "netlavis.azione.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "nortonsafe.search.ask.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "pex.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                case "realtime.search.yahoo.co.jp":
                    return GetSearchSimpleQuery(uri, "p");
                case "s.cube-soft.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.auone.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.azby.fmworld.net":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "Text");
                case "search.crav-ing.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.dolphin-browser.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.fenrir-inc.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.fooooo.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.freespot.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.goo.ne.jp":
                    return GetSearchSimpleQuery(uri, "MT");
                case "search.jiqoo.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.kawaii.aswidget.com":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "search.kensakuplus.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.kinza.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.livedoor.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.myjcom.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.nifty.com":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "Text");
                case "search.plushome.aswidget.com":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "search.searchnewsplus.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "search.smt.docomo.ne.jp":
                    return GetSearchSimpleQuery(uri, "MT");
                case "search.yahoo.co.jp":
                    return GetSearchSimpleQuery(uri, "p");
                case "search.yahoo.com":
                    return GetSearchSimpleQuery(uri, "p");
                case "sp-web.search.auone.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "th.search.yahoo.com":
                    return GetSearchSimpleQuery(uri, "p");
                case "v-buster.jword.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "wakwakpc.starthome.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                case "websearch.excite.co.jp":
                    return GetSearchSimpleQuery(uri, "q");
                case "websearch.rakuten.co.jp":
                    return GetSearchSimpleQuery(uri, "qt");
                case "www.benri.com":
                    return GetSearchSimpleQuery(uri, "Keywords");
                case "www.bing.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.ecosia.org":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.google.co.jp":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "as_q");
                case "www.google.co.kr":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.google.com":
                    return GetSearchSimpleQuery(uri, "q") ?? GetSearchSimpleQuery(uri, "as_q");
                case "www.google.com.br":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.google.es":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.google.it":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.info.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.msn.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.search.ask.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.searchmobileonline.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.so.com":
                    return GetSearchSimpleQuery(uri, "q");
                case "www.so-net.ne.jp":
                    return GetSearchSimpleQuery(uri, "query");
                case "www.unisearch.jp":
                    return GetSearchSimpleQuery(uri, "keyword");
                default:
                    break;
            }
            return null;
        }
    }
}
