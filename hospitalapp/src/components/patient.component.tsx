import { connect } from 'react-redux';
import React from 'react'
import IPatientService from '../interfaces/IPatient.service';
import { AppDispatch } from '../redux/store';
import PatientService from '../services/Patient.service';
import { getPatients } from '../redux/actions/patient.actions';
import { getAllAction } from '../redux/actions/patient.newactio';

class PatientComponent extends React.Component<any, any> {

    patservice! : IPatientService;

    constructor(props: any) {
        super(props);
        this.state = {
            id: 1,
            skip:1,
            take:3,
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
                <button onClick={() => this.props.getAllPatients(this.state.skip, this.state.take)}> disptach action</button>
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
            dispatch(getAllAction(skip, take))
        }
    }
}
export default connect(mapStateToProps, mapDispatchToProps)(PatientComponent);