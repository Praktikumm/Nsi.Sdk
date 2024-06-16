using PraktikumNsiSdk.Dto;

namespace PraktikumNsiSdk.Application.Models;

public class PostCategoryModel
{
    public string Title { get; set; }
    public string Content { get; set; }

    public PostCategoryModel()
    {
    }

    public PostCategoryModel(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public CreateCategoryRequestDto ToCreateCategoryRequestDto()
    {
        var title = Title + "-" + "Created by NSI SDK";
        return new CreateCategoryRequestDto(Title, Content);
    }
}