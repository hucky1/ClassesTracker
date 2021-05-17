using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerModel.Interfaces
{
    public interface ITestModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string RightAnswer { get; set; }
    }
}
