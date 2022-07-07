import React from 'react'
import { Button, FormControl, Grid, Input, InputLabel } from '@mui/material';
import { connect } from 'react-redux';
import IPatientModel from '../models/IPatient.model';
import { updateAction } from '../redux/actions/update.patient';
import { getAllPatients } from '../redux/actions/patient.actions';
import { AppDispatch } from '../redux/store';

class TableCompoent extends React.Component<any, any>{
  constructor(props: any) {
    super(props);
    this.state = {
        _id: 0,
        firstName: '',
        lastName: '',
        email: '',
        password: '',
        age: 0,
        gender: '',
        city: '',
        state: '',
        disease: '',
        phoneNumber: '',
        doctorID: '',   
    }
  }

  private set _id(v: number) {
    if (v > 0) {
        this.setState({_id: v});
    }else{
        this.setState({_id: 0});
    }
  }
  
  private set firstName(v : string) {
    this.setState({firstName: v});
  }
  
  private set lastName(v : string) {
    this.setState({lastName: v});
  }

  private set email(v : string) {
    this.setState({email: v});
  }
  
  private set password(v : string) {
    this.setState({password: v});
  }

  private set age(v : number) {
    if (v > 0) {
        this.setState({age: v});
    }else{
        this.setState({age: 0});
    }
  }
  
  private set gender(v : string) {
    this.setState({gender: v});
  }
  private set city(v : string) {
    this.setState({city: v});
  }
  
  private set _state(v : string) {
    this.setState({state: v});
  }
  
  private set disease(v : string) {
    this.setState({disease: v});
  }
  private set phoneNumber(v : string) {
    this.setState({phoneNumber: v});
  }
  
  private set doctorID(v : string) {
    this.setState({doctorID: v});
  }

    render() {
        return (
            <div style={{backgroundColor: '#f2f2f2', width: '100%', height: '100%'}}>
                <Grid width={'40%'} container margin={2} spacing={1} direction="column" justifyContent= {'center'}>
                    <FormControl>
                        <InputLabel htmlFor='_id' >enter your ID</InputLabel>
                        <Input sx={{m:2}} type='number' id='_id' value={this.state._id} onChange={(e) => {this._id = parseInt(e.target.value)}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='firstName' >enter your first Name</InputLabel>
                        <Input sx={{m:2}} type='text' id='firstName' value={this.state.firstName} onChange={(e) => {this.firstName = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='lastName' >enter your last Name</InputLabel>
                        <Input sx={{m:2}} type='text' id='lastName' value={this.state.lastName} onChange={(e) => {this.lastName = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='email' >enter your email</InputLabel>
                        <Input sx={{m:2}} type='text' id='email' value={this.state.email} onChange={(e) => {this.email = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='password' >enter your password</InputLabel>
                        <Input sx={{m:2}} type='text' id='password' value={this.state.password} onChange={(e) => {this.password = e.target.value}} />                        
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='age' >enter your age</InputLabel>
                        <Input sx={{m:2}} type='number' id='age' value={this.state.age} onChange={(e) => {this.age = parseInt(e.target.value)}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='gender' >enter your gender</InputLabel>
                        <Input sx={{m:2}} type='text' id='gender' value={this.state.gender} onChange={(e) => {this.gender = e.target.value}} />                    
                    </FormControl>
                    <br />
                    <FormControl>
                        <InputLabel htmlFor='city' >enter your city</InputLabel>
                        <Input sx={{m:2}} type='text' id='city' value={this.state.city} onChange={(e) => {this.city = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>    
                        <InputLabel htmlFor='state' >enter your state</InputLabel>
                        <Input sx={{m:2}} type='text' id='state' value={this.state.state} onChange={(e) => {this._state = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='disease' >enter your disaes</InputLabel>
                        <Input sx={{m:2}} type='text' id='disease' value={this.state.disease} onChange={(e) => {this.disease = e.target.value}} />                                        
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='phoneNumber' >enter your phone number</InputLabel>
                        <Input sx={{m:2}} type='text' id='phoneNumber' value={this.state.phoneNumber} onChange={(e) => {this.phoneNumber = e.target.value}} />                    
                    </FormControl>
                    <br/ >
                    <FormControl>
                        <InputLabel htmlFor='doctorID' >enter your doctor ID</InputLabel>
                        <Input sx={{m:2}} type='text' id='doctorID' value={this.state.doctorID} onChange={(e) => {this.doctorID = e.target.value}} />                        
                    </FormControl>
                    <br/ >
                    <Button onClick={() => this.props.updatePatient(this.state as IPatientModel)} > update user</Button>
                    <Button onClick={() => console.log(this.props.state)} > log user</Button>
                    <Button onClick={() => this.props.getAllPatient(0, 7)} > get all user</Button>
                </Grid  >
            </div>
        )
    }
}


function mapStateToProps(state: any) {
    return {
        state
    }
}

function mapDispatchToProps(dispatch: AppDispatch){
    return {
        getAllPatient : function(skip: number, take: number){
          dispatch(getAllPatients(skip, take));
        },
        updatePatient : function(patinet: IPatientModel){
            dispatch(updateAction(patinet));
        }
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(TableCompoent);