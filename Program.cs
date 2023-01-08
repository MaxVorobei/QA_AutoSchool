using System;

namespace typeMinMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            byte maxByteValue = byte.MaxValue;
            byte minByteValue = byte.MinValue;
            Console.WriteLine("max Byte value: " + maxByteValue + ", min Byte value: " + minByteValue);

            short maxShortValue = short.MaxValue;
            short minShortValue = short.MinValue;
            Console.WriteLine("max Short value: " + maxShortValue + ", min Short value: " + minShortValue);

            ushort maxUshortValue = ushort.MaxValue;
            ushort minUshortValue = ushort.MinValue;
            Console.WriteLine("max Ushort value: " + maxUshortValue + ", min Ushort value: " + minUshortValue);

            int maxIntValue = int.MaxValue;
            int minIntValue = int.MinValue;
            Console.WriteLine("max Int value: " + maxIntValue + ", min Int value: " + minIntValue);

            uint maxUintValue = uint.MaxValue;
            uint minUintValue = uint.MinValue;
            Console.WriteLine("max Uint value: " + maxUintValue + ", min Uint value: " + minUintValue);

            long maxLongValue = long.MaxValue;
            long minLongValue = long.MinValue;
            Console.WriteLine("max Long value: " + maxLongValue + ", min Long value: " + minLongValue);

            ulong maxUlongValue = ulong.MaxValue;
            ulong minUlongValue = ulong.MinValue;
            Console.WriteLine("max Ulong value: " + maxUlongValue + ", min Ulong value: " + minUlongValue);

            float maxFloatValue = float.MaxValue;
            float minFloatValue = float.MinValue;
            Console.WriteLine("max Float value: " + maxFloatValue + ", min Float value: " + minFloatValue);

            double maxDoubleValue = double.MaxValue;
            double minDoubleValue = double.MinValue;
            Console.WriteLine("max Double value: " + maxDoubleValue + ", min Double value: " + minDoubleValue);

            char maxCharValue = char.MaxValue;
            char minCharValue = char.MinValue;
            Console.WriteLine("max Char value: " + maxCharValue + ", min Char value: " + minCharValue);
        }
    }
}
