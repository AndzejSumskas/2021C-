using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.Enum
{
    class EducationLevel
    {
       EnumLvl LevelofEducation { get; set; }

        public EducationLevel(EnumLvl levelofEducation)
        {
            LevelofEducation = levelofEducation;
        }

        public static void WriteEducationLevel(EducationLevel leveOfEducation)
        {
            
            switch (leveOfEducation.LevelofEducation)
            {
                case EnumLvl.Elementary:
                    Console.WriteLine("Education level: " + leveOfEducation.LevelofEducation);
                    break;
                case EnumLvl.Midle:
                    Console.WriteLine("Education level: " + leveOfEducation.LevelofEducation);
                    break;
                case EnumLvl.High:
                    Console.WriteLine("Education level: " + leveOfEducation.LevelofEducation);
                    break;
            }
        }
    }
}