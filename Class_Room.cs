using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming281_Project
{
    class Class_Room
    {
        private string roomNo;
        private string roomType;
        private string dailyRate;
        private string status;

        public string RoomNo
        {
            get
            {
                return roomNo;
            }

            set
            {
                roomNo = value;
            }
        }

        public string RoomType
        {
            get
            {
                return roomType;
            }

            set
            {
                roomType = value;
            }
        }

        public string DailyRate
        {
            get
            {
                return dailyRate;
            }

            set
            {
                dailyRate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        public Class_Room()
        {

        }
        public Class_Room(string rNumber,string rType, string rate)
        {
            roomNo = rNumber;
            roomType = rType;
            dailyRate = rate;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", roomNo, roomType, dailyRate);
        }
    }
}
