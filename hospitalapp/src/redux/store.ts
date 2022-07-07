import { combineReducers, configureStore } from "@reduxjs/toolkit";
// import { patientReducer } from "./reducers/patient.reducer";
import {getReducer} from './reducers/getReducer'
import { patientSlice } from './reducers/patient.reducer'

export const store = configureStore({
    reducer: combineReducers({getReducer, patientSlice})
})

export type AppDispatch = typeof store.dispatch;
