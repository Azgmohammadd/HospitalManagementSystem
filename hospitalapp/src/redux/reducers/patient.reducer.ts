// import { createReducer, createSlice, PayloadAction } from "@reduxjs/toolkit";
// import { aysncPatinetsAction, patientAction } from "../actions/patient.newactio";
// import { AppDispatch } from "../store";

import { createSlice, PayloadAction } from "@reduxjs/toolkit";
// import { getAllAction } from "../actions/patient.newactio";
import { updateAction } from "../actions/update.patient";



type initalType = {
    Patients: Array<any> | undefined;
    Patient: object;
    IS_UPDATED: any;
    IS_CREATED: object;
    IS_DELETED: object;
}

const initalState : initalType = {
    Patients: [],
    Patient: {},
    IS_UPDATED: {},
    IS_CREATED: {},
    IS_DELETED: {}
};

// export function patientReducer(){
//     return async function (dispatch: AppDispatch) {
//         const reducer = createReducer(initalState, (builder) => {
//             builder.addCase(getAllPatientsAction, (state, action) => {});
//         })
//     }
// }

export const patientSlice = createSlice({
    name: 'getPatientSlice',
    initialState: initalState,
    reducers : {},
    extraReducers: (builder) => {
        builder.addCase(updateAction.fulfilled, (state, action : PayloadAction) => {
            state.IS_UPDATED = action.payload;
            console.log('ok i am in reducer');
            
        });
    }
        // [updateAction.fulfilled]: (state: any, action: PayloadAction<any>) => {
        //     state.IS_UPDATED = action.payload;
    }
);







