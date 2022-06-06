using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataModel.BaseModel
{
    public interface IPatientModel
    {
        public long _id { get; set; }
        
        public string firstName { get; set; }
        
        public string lastName { get; set; }
        
        public string? email { get; set; }
        
        public string? password { get; set; }

        public int age { get; set; }

        public string? gender { get; set; }

        public string? city { get; set; }

        public string? state { get; set; }

        public string? disease { get; set; }

        public string? phoneNumber { get; set; }

        public string? doctorID { get; set; }
    }
}
