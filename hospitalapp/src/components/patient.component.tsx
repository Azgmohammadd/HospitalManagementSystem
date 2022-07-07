import { connect } from 'react-redux';
import React from 'react'
import IPatientService from '../interfaces/IPatient.service';
import { AppDispatch } from '../redux/store';
import PatientService from '../services/Patient.service';
import { getAllPatients } from '../redux/actions/patient.actions';
// import { getAllAction } from '../redux/actions/patient.newactio';
import { getAction } from '../redux/actions/getAction';
import { updateAction } from '../redux/actions/update.patient';
import IPatientModel from '../models/IPatient.model';

class PatientComponent extends React.Component<any, any> {

    patservice! : IPatientService;

    constructor(props: any) {
        super(props);
        this.state = {
            id: 1,
            skip:0,
            take:3,
            data: {
                "_id": 1,
                "firstName": "mohammad",
                "lastName": "azg",
                "email": "email2",
                "password": "you can!",
                "age": 2,
                "gender": "gender2",
                "city": "city2",
                "state": "state2",
                "disease": "disease2",
                "phoneNumber": "0123456789",
                "doctorID": "1"
              },
        };
        this.patservice = new PatientService();
        this.getdata = this.getdata.bind(this);
    }

    async getdata(){
        const data = await this.patservice.GetAllPatients(this.state.skip, this.state.take);

        console.log(data);
    }

    render() {
        return (
            <div>
                patient.component
                <button onClick={() => console.log(this.props.state)}> show map state</button>
                <button onClick={this.getdata}> show data</button>
                <button onClick={() => this.props.getAllPatients(this.state.skip, this.state.take)}> disptach get all action</button>
                <button onClick={() => this.props.getPatient(this.state.id)}> disptach get  action</button>
                <button onClick={() => this.props.updatePatient(this.state.data)}> disptach update  action</button>
            </div>
        )
    }
}


function mapStateToProps(state: any){
    return {
        state
    }
}


function mapDispatchToProps(dispatch: AppDispatch){
    return {
        getAllPatients: function(skip: number, take: number){
            dispatch(getAllPatients(skip, take))
        },getPatient: function(id: number){
            dispatch(getAction(id))
        },updatePatient: function(model : IPatientModel){
            dispatch(updateAction(model))
        }
    }
}
export default connect(mapStateToProps, mapDispatchToProps)(PatientComponent);