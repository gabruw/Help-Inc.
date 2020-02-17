import axios from 'axios';
import ENDPOINTS from '../library/endpoints';

const api = axios.create({
    baseURL: ENDPOINTS.BASE_URL
});

// api.interceptors.request.use(async (config) => {
//     if (env.token) {
//         config.headers.Authorization = env.token;
//     }

//     return config;
// });

export default api;
