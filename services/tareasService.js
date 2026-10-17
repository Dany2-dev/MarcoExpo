import client from '../api/client';

export async function getTask(id) {
  const res = await client.get(`/tareas/${id}`);
  return res.data;
}

export async function getAllTasks() {
  const res = await client.get('/tareas');
  return res.data;
}

export async function createTask(tarea) {
    const res = await client.post('/tareas', tarea);
    return res.data;
}

export async function deleteTask(id) {
    const res = await client.delete(`/tareas/${id}`);
    return res.data;
}
export async function updateTask(id, tarea) {
    const res = await client.put(`/tareas/${id}`, tarea);
    return res.data;
}