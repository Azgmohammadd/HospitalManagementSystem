import { createAction, createAsyncThunk } from "@reduxjs/toolkit";
import IPatientService from "../../interfaces/IPatient.service";
import PatientService from "../../services/Patient.service";

const patientService: IPatientService = new PatientService();

export const GET_ALL_TYPE = 'GETALLPATIENTS';

// export function GetAllPatients (skip: number, take: number) {
//     return async function (dispatch: any) {
//         const result = await patientService.GetAllPatients(skip, take);
//         const action :any = createAction("GET_ALL_PATIENTS");
//         action().payload = result;
//         dispatch(action);
//     }
// }



// export const getAllPatientType= (payload: any) => {
//     return {
//         type: 'GetAllPatientType',
//         payload
//     }
// }


// export const GetAllPatients = (skip: number, take: number) =>{
//     createAsyncThunk("GET_ALL_PATIENTS",async () => {
//         const result = await patientService.GetAllPatients(skip, take);
//         return result;
//     });
// }

export function getAllPatients(skip: number, take: number)  {
    return async function (dispatch: any){
        var result = await patientService.GetAllPatients(skip, take);
        dispatch({
            type: 'GETALLPATIENTS',
            payload: result
        })
    }
}