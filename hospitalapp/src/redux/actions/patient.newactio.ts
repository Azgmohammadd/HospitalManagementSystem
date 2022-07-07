import { createAction } from "@reduxjs/toolkit";
import IPatientService from "../../interfaces/IPatient.service";
import PatientService from "../../services/Patient.service";
import { AppDispatch } from "../store";


const patientService : IPatientService = new PatientService();

// export const  getAllPatientsAction = (skip:number, take: number): any => {
//     return async function (dispatch : AppDispatch){
//         const action = createAction<object | null, string>('getAllPatients');
//         const result = await patientService.GetAllPatients(skip, take);
//         action({result: result});
//         dispatch(action);
//         return action;
//     }   
// }
// export const patientAction = createAction<object | null, string>('patinetsAction');

export const getAllAction = (skip:number, take: number) =>
    async (dispatch:AppDispatch) => {
        const data = await patientService.GetAllPatients(skip, take);
        const action = createAction<object | null, string>('getAllPatients')(data);
        return dispatch(action);
    }

// export const aysncPatinetsAction = (skip:number, take: number): any => 
//     createAsyncThunk(patientAction().type , async () => {
//     const data = await patientService.GetAllPatients(skip, take);
//     patientAction({patients: data});
//     return patientAction().payload;
// }); 

// export const aysncPatinetsAction = (skip:number, take: number): any =>async () => {
//     const data = await patientService.GetAllPatients(skip, take);
//     const aysncThunk = createAsyncThunk(patientAction({patients: ).type, () => {
//     })
// };