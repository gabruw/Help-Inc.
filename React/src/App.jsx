//#region Imports

import React from 'react';
import { Provider } from 'react-redux';

import store from './store';
import AppRoutes from './AppRoutes';

import 'semantic-ui-css/semantic.css';

//#endregion

function App() {
    return (
        <React.Fragment>
            <Provider store={store}>
                <AppRoutes />
            </Provider>
        </React.Fragment>
    );
}

export default App;
