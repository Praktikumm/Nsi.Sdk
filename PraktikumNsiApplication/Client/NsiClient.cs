using PraktikumNsiSdk.Application.Models;
using PraktikumNsiSdk.Dto;

namespace PraktikumNsiSdk.Application.Client;

public class NsiClient(INsiApi api) : INsiClient
{
    public Task<string> CreateProductAsync(PostVendorModel request, IDictionary<string, string> headers)
    {
        return api.CreateProductAsync(new CreateVendorRequestDto(request.Name), headers);
    }
}