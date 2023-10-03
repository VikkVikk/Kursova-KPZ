using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    public class SubjectList
    {
        private List<Subject> subjectList = new List<Subject>();
        private Subject subject;

        public bool isSubject(string data)
        {
            for (int i = 0; i < subjectList.Count(); ++i)
            {
                if (Object.Equals(subjectList[i].getSubjectName(), data))
                {
                    subject = subjectList[i];
                    return true;
                }
            }

            return false;
        }

        public void AddSubject(Subject subject)
        {
            subjectList.Add(subject);
        }

        public string getSubjectName()
        {
            if (subject != null)
            {
                return subject.getSubjectName();
            }

            return null;
        }

        public byte getStudyDuration()
        {
            if (subject != null)
            {
                return subject.getStudyDuration();
            }

            return 0;
        }

        public int getPrice()
        {
            if (subject != null)
            {
                return subject.getPrice();
            }

            return 0;
        }
    }
}
