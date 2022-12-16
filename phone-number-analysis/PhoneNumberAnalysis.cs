using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var parts =  phoneNumber.Split('-');
        var t = (isNewYork: parts[0] == "212",isFake: parts[1] =="555", localNumber: parts[2]);
        return t;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
