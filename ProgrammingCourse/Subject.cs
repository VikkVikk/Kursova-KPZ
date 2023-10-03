using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingCourse
{
    public class Subject
    {
        private string subjectName;
        private byte studyDuration;
        private int price;

        public Subject (string subjectName, byte studyDuration, int price)
        {
            this.subjectName = subjectName;
            this.studyDuration = studyDuration;
            this.price = price;
        }

        public string getSubjectName()
        {
            return subjectName;
        }

        public byte getStudyDuration()
        {
            return studyDuration;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
