import client from '../api/client';

export async function getLicencia() {
  const res = await client.get('/licencia');
  return res.data;
}

export async function updateLicencia(licencia) {
  const res = await client.put('/licencia', licencia);
  return res.data;
}