using System.Net.Http.Headers;
using System.Xml.Schema;

namespace TypingGame.Models
{
    public class Stats
    {
        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Total
        {
            get
            {
                return Correct+ Missed;
            }

            set { Correct = value; }    
        }
        public int Accuracy { get; set; }

        public void CountAccuracy()
        {
            Accuracy = Correct*100 / (Correct + Missed);
        }
    }

}
