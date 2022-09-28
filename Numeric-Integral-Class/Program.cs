var number = 111111111111111111;
castInt(-1);

void castInt(int num)
{
    if(num >= System.SByte.MinValue && num <= System.SByte.MaxValue)
    {
        sbyte newNum = (sbyte)num;
        Console.WriteLine(newNum.GetType());
    } else
    if(num >= System.Byte.MinValue && num <= System.Byte.MaxValue)
    {
        byte newNum = (byte)num;
        Console.WriteLine(newNum.GetType());
    } else
    if(num >= System.Int16.MinValue && num <= System.Int16.MaxValue)
    {
        short newNum = (short)num;
        Console.WriteLine(newNum.GetType());
    } else
    if (num >= System.UInt16.MinValue && num <= System.UInt16.MaxValue)
    {
        ushort newNum = (ushort)num;
        Console.WriteLine(newNum.GetType());
    } else
    if (num >= System.UInt32.MinValue && num <= System.UInt32.MaxValue)
    {
        uint newNum = (UInt32)num;
        Console.WriteLine(newNum.GetType());
    }
}