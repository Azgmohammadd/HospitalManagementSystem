using MongoDB.Bson.Serialization.Attributes;
using HospitalDataModel.BaseModel;

namespace HospitalDataModel.ViewModel
{
    public class PatientViewModel : IPatientModel
    {
        [BsonId]
        public long _id { get; set; }

        [BsonElement("firstName")]
        public string? firstName { get; set; }

        [BsonElement("lastName")]
        public string? lastName { get; set; }

        [BsonElement("email")]
        public string? email { get; set; }

        [BsonElement("password")]
        public string? password { get; set; }

        [BsonElement("age")]
        public int age { get; set; }

        [BsonElement("gender")]
        public string? gender { get; set; }

        [BsonElement("city")]
        public string? city { get; set; }

        [BsonElement("state")]
        public string? state { get; set; }

        [BsonElement("disease")]
        public string? disease { get; set; }

        [BsonElement("phoneNumber")]
        public string? phoneNumber { get; set; }

        [BsonElement("doctorID")]
        public string? doctorID { get; set; }
    }
}
