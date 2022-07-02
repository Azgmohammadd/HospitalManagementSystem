import IPatientModel from "../models/IPatient.model";


interface IPatientService {
    GetAllPatients(skip:number ,take: number): Promise<IPatientModel[] | null>;

    GetPatientById(id: number): Promise<IPatientModel>;

    CreatePatient(model: IPatientModel): Promise<void>;

    UpdatePatient(model: IPatientModel): Promise<void>;

    DeletePatient(id: number): Promise<void>;
}

export default IPatientService;