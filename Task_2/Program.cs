using System;
using System.Collections.Generic;
//2. Создать класс, представляющий учебный класс ClassRoom

//Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void Write(), 
//void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil
//и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupil = new Pupil[4];
            pupil[0] = new GoodPupil();
            pupil[1] = new BadPupil();
            pupil[2] = new ExcelentPupil();
            pupil[3] = new BadPupil();

            ClassRoom classRoom = new ClassRoom(pupil[1], pupil[0]);
            classRoom.OutInfo();
        }
    }
    class ClassRoom
    {
        static List<Pupil> pupil = new List<Pupil>();
        static ClassRoom()
        {
            pupil.Add(new GoodPupil());
            pupil.Add(new GoodPupil());
            pupil.Add(new BadPupil());
            pupil.Add(new ExcelentPupil());
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            pupil.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {

            pupil.Add(pupil1);
            pupil.Add(pupil2);
        }
        public void OutInfo()
        {
            foreach (var p in pupil)
            {
                Console.WriteLine(p.GetType().Name + ":");
                p.Read();
                p.Study();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }
        }
    }
}
