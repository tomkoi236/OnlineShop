using System;

namespace ShopOnline.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}