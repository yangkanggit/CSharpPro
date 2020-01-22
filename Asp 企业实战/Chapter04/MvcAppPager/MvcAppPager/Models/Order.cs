/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：MvcAppPager.Models
*文件名：  Order
*版本号：  V1.0.0.0
*唯一标识：92831f09-fd7f-485f-8968-6342861e12a1
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/7 15:57:54

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/7 15:57:54
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppPager.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public decimal WayFee { get; set; }
        public string EMS { get; set; }
    }
}