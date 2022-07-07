import IPatientService from "../../interfaces/IPatient.service";
import PatientService from "../../services/Patient.service";
import IPatientModel from './../../models/IPatient.model'
// import { AppDispatch } from "../store";
import {  createAsyncThunk } from "@reduxjs/toolkit";

const patientService : IPatientService = new PatientService();

export const UPDATE_TYPE = 'UPDATEPATIENT';

// export function updateAction(models: IPatientModel) {
//     return async function (dispatch:AppDispatch ) {
//         const data = await patientService.UpdatePatient(models);
//         dispatch({
//             type: UPDATE_TYPE,
//             payload: data
//         });
//     }    
// }


export const updateAction = createAsyncThunk(UPDATE_TYPE, async (models: IPatientModel) => {
    const data = await patientService.UpdatePatient(models);
    return data;
    }
);

