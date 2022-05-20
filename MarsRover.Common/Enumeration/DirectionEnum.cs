
using System;

namespace MarsRover.Common.Enumeration
{
    public enum DirectionEnum
    {
        N,//North
        E,//East
        S,//South
        W,//West
    }

    public static class EnumExtensions
    {
        public static DirectionEnum GetEnumValue(string value)
        {
            try
            {
                return (DirectionEnum)Enum.Parse(typeof(DirectionEnum), value);
            }
            catch
            {
                return default;
            }
        }
    }
}
