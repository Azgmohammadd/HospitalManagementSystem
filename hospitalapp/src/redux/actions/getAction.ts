import IPatientService from "../../interfaces/IPatient.service";
import PatientService from "../../services/Patient.service";
import { AppDispatch } from "../store";

const patientService : IPatientService = new PatientService();

export const GET_TYPE = 'GETPAIENT';

export function getAction(id: number) {
    return async function (dispatch:AppDispatch ) {
        const data = await patientService.GetPatientById(id);
        dispatch({
            type: GET_TYPE,
            payload: data
        });
    }    
}
