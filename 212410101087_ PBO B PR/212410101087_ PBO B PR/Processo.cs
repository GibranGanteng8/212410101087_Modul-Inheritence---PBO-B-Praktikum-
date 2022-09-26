namespace Processorr
{
    class Processor
    {
        public string merk;
        public string tipe;
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "CoreI3";
        }
    }
    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "CoreI7";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "CoreI5";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RYZEN";
        }
    }
}