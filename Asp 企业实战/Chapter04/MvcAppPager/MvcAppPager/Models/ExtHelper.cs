/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：MvcAppPager.Models
*文件名：  ExtHelper
*版本号：  V1.0.0.0
*唯一标识：7c6ad105-4b24-4879-b282-f1d4a3a470fd
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/7 17:22:02

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/7 17:22:02
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MvcAppPager.Models
{
    public static class ExtHelper
    {
        public static MvcHtmlString UlPaging(this HtmlHelper helper, IPageOfList list)
        {
            StringBuilder sb = new StringBuilder();

            if (list == null)
            {
                return new MvcHtmlString(sb.ToString());
            }
            sb.AppendLine("<div class=\"fenye\">" + string.Format("<span>共 {0} 条 记录，每页 {1} 条 &nbsp;</span>", list.RecordTotal, list.PageSize));
            System.Web.Routing.RouteValueDictionary route = new System.Web.Routing.RouteValueDictionary();
            foreach (var key in helper.ViewContext.RouteData.Values.Keys)
            {
                route[key] = helper.ViewContext.RouteData.Values[key];
            }

            foreach (string key in helper.ViewContext.RequestContext.HttpContext.Request.QueryString)
            {
                route[key] = helper.ViewContext.RequestContext.HttpContext.Request.QueryString[key];
            }

            if (list.PageIndex <= 0)
            {
                sb.AppendLine("<a class=\"backpage\" href=\"javascript:void(0);\">上一页</a>");
            }
            else
            {
                route["pageIndex"] = list.PageIndex - 1;
           
                sb.AppendLine(helper.ActionLink("上一页", route["action"].ToString(), route).ToHtmlString());
            }

            if (list.PageIndex > 3)
            {
                route["pageIndex"] = 0;
                sb.AppendLine(helper.ActionLink(@"<b>1</b>", route["action"].ToString(), route).ToHtmlString().Replace("&lt;", "<").Replace("&gt;", ">"));
                if (list.PageIndex >= 5)
                {
                    sb.AppendLine("<a href='#'>..</a>");
                }
            }

            for (int i = list.PageIndex - 2; i <= list.PageIndex; i++)
            {
                if (i < 1)
                    continue;
                route["pageIndex"] = i - 1;

                sb.AppendLine(helper.ActionLink(@"<b>" + i.ToString() + @"</b>", route["action"].ToString(), route).ToHtmlString().Replace("&lt;", "<").Replace("&gt;", ">"));
            }

            sb.AppendLine(@"<a class='active' href='#'><b>" + (list.PageIndex + 1) + @"</b></a>");
            for (var i = list.PageIndex + 2; i <= list.PageIndex + 4; i++)
            {
                if (i > list.PageTotal)
                    continue;
                route["pageIndex"] = i - 1;
                sb.AppendLine(helper.ActionLink(@"<b>" + i.ToString() + @"</b>", route["action"].ToString(), route).ToHtmlString().Replace("&lt;", "<").Replace("&gt;", ">"));
            }

            if (list.PageIndex < list.PageTotal - 4)
            {
                if (list.PageIndex <= list.PageTotal - 6)
                {
                    sb.AppendLine("<a href='#'>..</a>");
                }
                route["pageIndex"] = list.PageTotal - 1;

                sb.AppendLine(helper.ActionLink(@"<b>" + list.PageTotal.ToString() + "</b>", route["action"].ToString(), route).ToHtmlString().Replace("&lt;", "<").Replace("&gt;", ">"));
            }
            if (list.PageIndex < list.PageTotal - 1)
            {
                route["pageIndex"] = list.PageIndex + 1;
                sb.AppendLine(helper.ActionLink("下一页", route["action"].ToString(), route).ToHtmlString());
            }
            else
            {
                sb.AppendLine("<a class=\"nextpage\" href=\"javascript:void(0);\">下一页</a>");
            }
            sb.AppendLine("</div>");
            return new MvcHtmlString(sb.ToString());
        }
    }
}