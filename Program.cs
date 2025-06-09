using System;
using ZodiacData;
using ZodiacModels;
using ZodiacUI;

namespace ZodiacSing;

class Program
{
    static void Main(string[] args)
    {
        DateTime nacimiento = ZodiacUI.ZodiacUI.PedirFechaNacimiento();
        ZodiacSign signo = ZodiacData.ZodiacData.GetSignByDate(nacimiento);
        ZodiacUI.ZodiacUI.MostrarSigno(signo);
    }
}
