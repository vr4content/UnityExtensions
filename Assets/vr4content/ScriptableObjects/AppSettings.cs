using System;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "ScriptableObjects/AppSettings", order = 1)]
public class AppSettings : ScriptableObject
{
    public string appName;
    public string version;
    public string AppSettingsURL;
    public string DatetimeAppUpdated;
    public string DateTimeAppInstalled;
    public string DateTimeAppOpened;

    private const string dateFormat = "yyyyMMddHHmmss";

    public string GetStringFromDate(DateTime date)
    {
        return date.ToString(dateFormat);
    }
    public DateTime GetDateFromString(string date)
    {
        return DateTime.ParseExact(date, dateFormat, CultureInfo.InvariantCulture);
    }

    public void SetAppUpdated(string date)
    {
        DatetimeAppUpdated = date;
    }
    public void SetAppUpdated(DateTime date)
    {
        SetAppUpdated(GetStringFromDate(date));
    }
    public void SetAppUpdatedNow()
    {
        SetAppUpdated(DateTime.UtcNow);
    }
    public void SetAppInstalled(string date)
    {
        DateTimeAppInstalled = date;
    }
    public void SetAppInstalled(DateTime date)
    {
        SetAppInstalled(GetStringFromDate(date));
    }
    public void SetAppInstalledNow()
    {
        SetAppInstalled(DateTime.UtcNow);
    }
    public void SetDateTimeAppOpened(string date)
    {
        DatetimeAppUpdated = date;
    }
    public void SetDateTimeAppOpened(DateTime date)
    {
        SetDateTimeAppOpened(GetStringFromDate(date));
    }
    public void SetDateTimeAppOpenedNow()
    {
        SetDateTimeAppOpened(DateTime.UtcNow);
    }


    private void OnValidate()
    {

    }

}
