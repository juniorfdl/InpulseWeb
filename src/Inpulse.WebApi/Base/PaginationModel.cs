using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Inpulse.WebApi.Base
{
    [DataContract]
    public class PaginationViewModel
    {
        [DataMember] public int PageSize { get; set; }
        [DataMember] public int CurrentPage { get; set; }
        [DataMember] public string PreviousPageLink { get; set; }
        [DataMember] public string NextPageLink { get; set; }
    }
    
    public interface IPagedParams
    {
        int PageSize { get; set; }
        int PageNumber { get; set; }
    }
    
    [DataContract]
    public class PagedParams : IPagedParams
    {
        [FromQuery(Name = "page_size")] 
        public int PageSize { get; set; } = 10;

        [FromQuery(Name = "page_number")] 
        public int PageNumber { get; set; } = 1;
    }
    
    public interface IPageInfo
    {
        int CurrentPage { get; set; }
        int PageSize { get; set; }
        bool HasPrevious { get; set; }
        bool HasNext { get; set; }
    }
    public interface IPagedInfo
    {
        IPageInfo PageInfo { get; set; }
    }
}
