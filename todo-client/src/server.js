import axios from 'axios';

export function todo_getAll() {
    return axios.get('/api/todos').then(resp => resp.data);
}

export async function todo_getAll() {
    const resp = await axios.get('/api/todos');

    return resp.data;
}