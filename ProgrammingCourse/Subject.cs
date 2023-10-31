using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingCourse
{
    public class Subject
    {
        private string subjectName;
        private sbyte studyDuration;
        private int price;

        public Subject (string subjectName, sbyte studyDuration, int price)
        {
            this.subjectName = subjectName;
            this.studyDuration = studyDuration;
            this.price = price;
        }

        public string getSubjectName()
        {
            return subjectName;
        }

        public sbyte getStudyDuration()
        {
            return studyDuration;
        }

        public int getPrice()
        {
            return price;
        }

        public string getStudyType()
        {
            if(studyDuration > 0 && studyDuration <= 6)
            {
                return "Експрес-курс";
            }

            if(studyDuration > 6 && studyDuration <= 12)
            {
                return "Загальний курс";
            }

            if(studyDuration > 12)
            {
                return "Поглиблений курс";
            }

            return "Неможливо визначити...";
        }
    }
}
