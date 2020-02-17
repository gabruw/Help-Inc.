const routes = [
    {
        path: '/',
        exact: true,
        component: require('../views/home').default
    },
    {
        path: '/home',
        exact: true,
        component: require('../views/home').default
    },
    {
        path: '/login',
        exact: true,
        component: require('../views/login').default
    },
    {
        path: '/register',
        exact: true,
        component: require('../views/register').default
    },
    {
        path: '*',
        exact: true,
        component: require('../views/error').default
    }
];

export default routes;
