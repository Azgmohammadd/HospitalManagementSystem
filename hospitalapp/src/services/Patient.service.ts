import axios from "axios";
import { api_url, patient_url } from "../configs/api.config";
import IPatientService from "../interfaces/IPatient.service";
import IPatientModel from "../models/IPatient.model";


class PatientSerivce implements IPatientService{
    
    async GetAllPatients(skip: number, take: number): Promise<IPatientModel[]| null> {
        return await fetch(`${patient_url}/${skip}/${take}`, {method: 'GET'})
        .then(res => res.json())
        .then(response => response)
        .catch(error => console.log(error));
    }
    async GetPatientById(id: number): Promise<IPatientModel> {
        return await axios.get(`${patient_url}/${id}`).then(res => res.data).catch(error => console.log(error));
    }
    CreatePatient(model: IPatientModel): Promise<void> {
        throw new Error("Method not implemented.");
    }
    UpdatePatient(model: IPatientModel): Promise<void> {
        throw new Error("Method not implemented.");
    }
    DeletePatient(id: number): Promise<void> {
        throw new Error("Method not implemented.");
    }
}

export default PatientSerivce;