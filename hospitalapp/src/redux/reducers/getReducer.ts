import { getAction, GET_TYPE} from "../actions/getAction";
import { GET_ALL_TYPE } from "../actions/patient.actions";
import { UPDATE_TYPE } from "../actions/update.patient";


type initalType = {
    Patients: Array<any> | undefined;
    Patient: object;
    IS_UPDATED: object;
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

export function getReducer(state = initalState, action: any) {
    switch (action.type) {
        case GET_TYPE:
            return {
                ...state,
                Patient: action.payload
            }
        case GET_ALL_TYPE:
            return{
                ...state,
                Patients: action.payload
            }
        case UPDATE_TYPE:
            return {
                ...state,
                IS_DELETED: action.payload
            }
        default:
            return state;
    }
}







