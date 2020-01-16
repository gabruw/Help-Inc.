//#region Imports

import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';

import routes from './routes';

//#endregion

const AppRoutes = () => (
    <BrowserRouter>
        <Switch>
            {routes.map((element) => (
                <Route key={element.path} path={element.path} exact={element.exact} component={element.component} />
            ))}
        </Switch>
    </BrowserRouter>
);

export default AppRoutes;
