using System;

    class Pupil
    {
        public virtual void Study() { }//методы
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class ExelentPupil : Pupil//производный класс
    {
        public override void Study()//переопределение метода
        {
            Console.WriteLine("study exelent");
        }
        public override void Read()
        {
            Console.WriteLine("read exelent");
        }
    public override void Write()
        {
            Console.WriteLine("write exelent");
        }
    public override void Relax()
        {
            Console.WriteLine("relax exelent");
        }

    }
    class GoodPupil : Pupil//производный класс
    {
    public override void Study()//переопределение метода
        {
            Console.WriteLine("study good");
        }
    public override void Read()
        {
            Console.WriteLine("read good");
        }
    public override void Write()
        {
            Console.WriteLine("write good");
        }
    public override void Relax()
        {
            Console.WriteLine("relax good");
        }
    }
    class BadPupil : Pupil//производный класс
    {
    public override void Study()//переопределение метода
        {
            Console.WriteLine("study bad");
        }
    public override void Read()
        {
            Console.WriteLine("read bad");
        }
    public override void Write()
        {
            Console.WriteLine("write bad");
        }
    public override void Relax()
        {
            Console.WriteLine("relax bad");
        }
    }
    class ClassRoom
    {
        Pupil[] pup = new Pupil[4];//массив
        public ClassRoom(params Pupil[] _pup)//конструктор
        {
            for (int i = 0; i < _pup.Length; i++)
            {
                if (_pup != null)
                {
                    pup[i] = _pup[i];
                }
            }
        }
        public void Info()
        {
            for (int i = 0; i < 4; i++)
            {
                if (pup[i] != null)
                {
                    Console.WriteLine("\n" + pup[i].GetType());
                    pup[i].Study();
                    pup[i].Read();
                    pup[i].Write();
                    pup[i].Relax();
                }
            }
        }
    }
    class ls2_1
    {
        static void Main(string[] args)
        {
        ClassRoom classRoom1 = new ClassRoom(new ExelentPupil(), new GoodPupil(), new BadPupil());
        classRoom1.Info();
        ClassRoom classRoom2 = new ClassRoom( new GoodPupil(), new BadPupil());
        classRoom2.Info();
    }
    }
