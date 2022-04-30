using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TO_DO_LLIST
{
    [DataContract]
    public class Goal
    {
        public ImageList ImageList { get; set; }
   
        [DataMember]
        public string Aim{ get; set; }
        public Goal(string aim, ImageList imaginelist)
        {
            Aim = aim;
            ImageList = imaginelist;
        }
    }
}
