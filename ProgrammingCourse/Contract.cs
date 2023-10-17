using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    public class Contract
    {
        private string studentInfo;
        private int number;
        private DateTime date;
        private string subjectName;
        private byte studyDuration;
        private int price;
        private bool isPayed = false;

        public Contract(string studentInfo, int number, DateTime date, string subjectName, byte studyDuration, int price, bool isPayed)
        {
            this.studentInfo = studentInfo;
            this.number = number;
            this.date = date;
            this.subjectName = subjectName;
            this.studyDuration = studyDuration;
            this.price = price;
            this.isPayed = isPayed;
        }

        public string getСontractStudentInfo()
        {
            return studentInfo;
        }

        public int getContractNumber()
        {
            return number;
        }

        public DateTime getContractDate()
        {
            return date;
        }

        public string getContractSubjectName()
        {
            return subjectName;
        }

        public byte getContractStudyDuration()
        {
            return studyDuration;
        }

        public int getContractPrice()
        {
            return price;
        }

        public bool getContractIsPayed()
        {
            return isPayed;
        }

        public void setIsPayed(bool isPayed)
        {
            this.isPayed = isPayed;
        }
    }
}
