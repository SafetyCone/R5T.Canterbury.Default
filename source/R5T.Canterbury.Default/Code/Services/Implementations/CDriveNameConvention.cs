using System;using R5T.T0064;


namespace R5T.Canterbury.Default
{[ServiceImplementationMarker]
    public class CDriveNameConvention : ICDriveNameConvention,IServiceImplementation
    {
        public const string CDriveName = "C:";


        public string GetCDriveName()
        {
            return CDriveNameConvention.CDriveName;
        }
    }
}
