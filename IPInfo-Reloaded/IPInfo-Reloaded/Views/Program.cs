using System;

namespace IPInfoReloaded
{
    class MainClass
    {
        static void Main(string[] args)
        {

          var vm = new MainViewModel();


            Console.WriteLine($"ZipCode is: { vm.ZipCode}");
        }
    }
}
