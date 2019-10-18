/****************************************************************************
* Copyright (c) 2016Microsoft All Rights Reserved.
* CLR版本： 4.0.30319.18052
*机器名称：ZOUYUJIE-PC
*公司名称：Microsoft
*命名空间：MvcAppPager.Models
*文件名：  PageOfList
*版本号：  V1.0.0.0
*唯一标识：dcf81175-86e1-49c3-b842-6a29856879f8
*当前的用户域：ZOUYUJIE-PC
*创建人：  邹琼俊
*电子邮箱：zouqiongjun@kjy.com
*创建时间：2016/5/7 15:53:10

*描述：
*
*=====================================================================
*修改标记
*修改时间：2016/5/7 15:53:10
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
    public interface IPageOfList
    {
        long CurrentStart { get; }
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int PageTotal { get; }
        long RecordTotal { get; set; }
    }
    public interface IPageOfList<T> : IPageOfList, IList<T>
    {
    }
    public class PageOfList<T> : List<T>, IList<T>, IPageOfList, IPageOfList<T>
    {
        public PageOfList(IEnumerable<T> items, int pageIndex, int pageSize, long recordTotal)
        {
            if (items != null)
                AddRange(items);
            PageIndex = pageIndex;
            PageSize = pageSize;
            RecordTotal = recordTotal;
        }

        public PageOfList(int pageSize)
        {
            if (pageSize <= 0)
            {
                throw new ArgumentException("pageSize must gart 0", "pageSize");
            }
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int PageTotal
        {
            get
            {
                return (int)RecordTotal / PageSize + (RecordTotal % PageSize > 0 ? 1 : 0);
            }
        }

        public long RecordTotal { get; set; }

        public long CurrentStart
        {
            get
            {
                return PageIndex * PageSize + 1;
            }
        }

        public long CurrentEnd
        {
            get
            {
                return (PageIndex + 1) * PageSize > RecordTotal ? RecordTotal : (PageIndex + 1) * PageSize;
            }
        }
    }
}