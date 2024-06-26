﻿using PraktikumNsiSdk.Application.Models;
using PraktikumNsiSdk.Dto;

namespace PraktikumNsiSdk.Application.Client;

public class NsiClient(INsiApi api) : INsiClient
{
    public Task<string> CreateProductAsync(PostVendorModel request, IDictionary<string, string> headers)
    {
        return api.CreateVendorAsync(new CreateVendorRequestDto(request.Name), headers);
    }

    public Task<string> CreateCategoryAsync(PostCategoryModel request, IDictionary<string, string> headers)
    {
        return api.CreateCategoryAsync(new CreateCategoryRequestDto(request.Title, request.Content), headers);
    }
}