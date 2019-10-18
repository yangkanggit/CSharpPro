/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：MvcModelApp.Models
*文件名：  User
*版本号：  V1.0.0.0
*唯一标识：78094944-8e1b-4855-8955-dc4695ed70b2
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/3 22:35:55

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/3 22:35:55
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModelApp
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        {
        }
    }
    [MetadataType(typeof(UserMetadata))]
    public partial class tb_User
    {
        public string RePwd { get; set; }
    }
    //1.为实体类添加特性DisplayName
    public class UserMetadata
    {
        [DisplayName("用户名")]
        [Remote("NotExitesUserName", "Home", ErrorMessage = "用户账号已存在")]
        public string UserName { get; set; }
        /// <summary>
        /// 1.在实体类中为Remark属性设置DataType特性，指定为多行文本框
        /// </summary>
        [DataType(DataType.MultilineText)]
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("年龄")]
        [Range(1, 120)]
        public int Age { get; set; }
        [PasswordPropertyText]
        [DisplayName("密码")]
        public string Pwd { get; set; }
        [PasswordPropertyText]
        [DisplayName("确认密码")]
        [System.Web.Mvc.Compare("Pwd")]
        public string RePwd { get; set; }
        [Email]
        public string Email { get; set; }
    }
}