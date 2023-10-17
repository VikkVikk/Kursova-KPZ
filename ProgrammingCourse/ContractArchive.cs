using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammingCourse
{
    public class ContractArchive
    {
        private List<Contract> contracts = new List<Contract>();
        private Contract contract;

        public bool isContract(int number)
        {
            for(int i = 0; i < contracts.Count(); ++i)
            {
                if (Object.Equals(contracts[i].getContractNumber(), number))
                {
                    contract = contracts[i];
                    return true;
                }
            }

            return false;
        }

        public void AddContract(Contract contract)
        {
            contracts.Add(contract);
        }

        public string getContractStudentInfo()
        {
            if (contract != null)
            {
                return contract.getСontractStudentInfo();
            }

            return null;
        }

        public int getContractNumber()
        {
            if (contract != null)
            {
                return contract.getContractNumber();
            }

            return 0;
        }

        public DateTime getContractDate()
        {
            if (contract != null)
            {
                return contract.getContractDate();
            }

            return DateTime.MinValue;
        }

        public string getContractSubjectName()
        {
            if (contract != null)
            {
                return contract.getContractSubjectName();
            }

            return null;
        }

        public byte getContractStudyDuration()
        {
            if (contract != null)
            {
                return contract.getContractStudyDuration();
            }

            return 0;
        }

        public int getContractPrice()
        {
            if (contract != null)
            {
                return contract.getContractPrice();
            }

            return 0;
        }

        public bool getContractIsPayed()
        {
            if (contract != null)
            {
                return contract.getContractIsPayed();
            }

            return false;
        }

        public void setIsPayed(bool isPayed)
        {
            if(contract != null)
            {
                contract.setIsPayed(isPayed);
            }
        }
    }
}
