/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：HtmlHelperApp.Models
*文件名：  User
*版本号：  V1.0.0.0
*唯一标识：1be7af87-6075-46aa-b585-aeddf93adabb
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/7 13:06:35

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/7 13:06:35
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HtmlHelperApp.Models
{
    public class User
    {
        [DisplayName("用户名")]
        public string UserName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }
    }
    public static class UserHelper
    {
        public static string UserShow(this HtmlHelper<User> helper)
        {
            var user = helper.ViewData.Model;
            if (user.UserName == "郭靖")
            {
                return string.Format("<div>我是{0}</div>", user.UserName);
            }
            else
            {
                return "<div>找不到</div>";
            }
        }
    }
}