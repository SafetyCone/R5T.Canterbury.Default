using System;


namespace R5T.Canterbury.Default
{
    public class CDriveNameConvention : ICDriveNameConvention
    {
        public const string CDriveName = "C:";


        public string GetCDriveName()
        {
            return CDriveNameConvention.CDriveName;
        }
    }
}
