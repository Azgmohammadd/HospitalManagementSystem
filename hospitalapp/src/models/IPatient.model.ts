interface IPatientModel {
    _id: number,
    firstName: string,
    lastName: string,
    email: string,
    password:string,
    age: number,
    gender: string,
    state: string,
    city: string,
    disease: string,
    phoneNumber: string,
    doctorID: number,
};

export default IPatientModel;