using PraktikumNsiSdk.Dto;

namespace PraktikumNsiSdk.Application.Models;

public class PostVendorModel
{
    public string Name { get; set; }
    private string ShortName { get; set; }

    public PostVendorModel(string name, string shortName)
    {
        this.Name = name;
        this.ShortName = shortName;
    }

    public CreateVendorRequestDto ToCreateVendorRequestDto()
    {
        return new CreateVendorRequestDto(this.Name + "-" + ShortName);
    }
}