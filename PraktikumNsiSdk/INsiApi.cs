using PraktikumNsiSdk.Dto;
using Refit;

namespace PraktikumNsiSdk;

public interface INsiApi
{
    [Post("/webhook/Vendor/CreateVendor")]
    public Task<string> CreateProductAsync([Body] CreateVendorRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
}