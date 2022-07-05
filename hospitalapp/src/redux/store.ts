import { combineReducers, configureStore } from "@reduxjs/toolkit";
import { patientSlice } from "./reducers/patient.reducer";


export const store = configureStore({
    reducer: patientSlice.reducer
})

export type AppDispatch = typeof store.dispatch;
