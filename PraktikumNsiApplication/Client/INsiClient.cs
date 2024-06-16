using PraktikumNsiSdk.Application.Models;

namespace PraktikumNsiSdk.Application.Client;

public interface INsiClient
{
    public Task<string> CreateProductAsync(PostVendorModel request,
        IDictionary<string, string> headers);
}