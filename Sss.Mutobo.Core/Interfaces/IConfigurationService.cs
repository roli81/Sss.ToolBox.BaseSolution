namespace Sss.Mutobo.Core.Interfaces
{
    public interface IConfigurationService
    {
        string GetAppSettingValue(string key, bool essential = true);
        int? GetAppSettingIntValue(string key, bool essential = true);
        bool? GetAppSettingBoolValue(string key, bool essential = true);
    }
}
