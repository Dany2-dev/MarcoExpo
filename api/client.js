import axios  from 'axios';

const client = axios.create({
    baseURL: 'http://localhost:5156',
    timeout: 1000,
    headers:{
        'Content-Type': 'application/json'
    }
    
});

export default client;
