import React from 'react'
import PatientService from '../services/Patient.service';

class PatientComponent extends React.Component<any, any> {

    patservice! : PatientService;

    constructor(props: any) {
        super(props);
        this.state = {
            id: 0,
            skip:0,
            take:3,
            patientService : new PatientService()
        };
        this.patservice = new PatientService();

        // this.getAllPatients = this.getAllPatients.bind(this);
    }


    render() {
        // const data = this.getAllPatients(this.state.skip, this.state.take);
        const data = this.patservice.GetAllPatients(this.state.skip, this.state.take);

        const d= this.patservice.GetPatientById(1);
        console.log(data);
        
        return (
            <div>
                patient.component
            </div>
        )
    }
}

export default PatientComponent;