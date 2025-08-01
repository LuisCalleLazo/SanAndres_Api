namespace SanAndres_Api.Helpers
{

  public class DriveSettings
  {
    public string FolderName { get; set; }
    public string ServiceAccountEmail { get; set; }
    public string EmailToShare { get; set; }

  }


  public class DriveFileSummaryDto
  {
    public string Id { get; set; }
    public string MimeType { get; set; }
    public DateTime? CreatedTime { get; set; }
    public string CreatedTimeRaw { get; set; }
    public DateTimeOffset? CreatedTimeDateTimeOffset { get; set; }
  }

}