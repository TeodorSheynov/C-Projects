using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Solution_3
{
    class Chat
    {
        public string Name { get; set; }
        public int Sent { get; set; }
        public int Recived { get; set; }
        public int Sum { get; set; }

        
        public Chat(string name,int sent,int recived)
        {
            Name = name;
            Sent = sent;
            Recived = recived;
            Sum = Sent + Recived;
        }

        public void Message(int num)
        {
            Sum += num;
        }
        
    }
}
