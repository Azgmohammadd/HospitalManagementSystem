
using MongoDB.Bson.Serialization.Attributes;

namespace HospitalDataModel.Model
{
    public class DoctorModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("firstName")]
        public string? firstName { get; set; }

        [BsonElement("lastName")]
        public string? lastName { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("password")]
        public string? Password { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("gender")]
        public string? Gender { get; set; }

        [BsonElement("department")]
        public string? Department { get; set; }

        [BsonElement("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [BsonElement("salary")]
        public long? Salary { get; set; }
    }
}
