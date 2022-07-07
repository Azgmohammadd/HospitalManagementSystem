import React, { Component } from 'react'
import PatientComponent from "./components/patient.component";
import { Provider } from 'react-redux';
import { store } from './redux/store';
import TableCompoent from './components/table.component';

class App extends Component {
  render() {
    return (
      <Provider store={store} >
        <div>
          {/* <PatientComponent /> */}
          <TableCompoent />
        </div>
      </Provider>
    )
  }
}

export default App;
