using PraktikumNsiSdk.Dto;
using Refit;

namespace PraktikumNsiSdk;

public interface INsiApi
{
    [Post("/webhook/Vendor/CreateVendor")]
    public Task<string> CreateVendorAsync([Body] CreateVendorRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
    [Post("/webhook/Category/CreateCategory")]
    public Task<string> CreateCategoryAsync([Body] CreateCategoryRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
}