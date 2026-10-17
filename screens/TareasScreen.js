import {useState, useEffect} from 'react';
import {View, Text, Button, StyleSheet, FlatList} from 'react-native';  
import {getAllTasks} from '../services/tareasService';
import { ScrollView } from 'react-native';

export default function TareasScreen({navigation}) {
  const [tareas, setTareas] = useState([]);

async function llamarTareas() {
  try {
    const datos = await getAllTasks();
    console.log("Datos recibidos:", datos);
    setTareas(datos);
  } catch (error) {
    console.error(error);
  }
}

// obtner los datos del api con cada redecion 
  useEffect(() => {
    llamarTareas();
  },[navigation]);

  return (
  <View>
    <ScrollView>
      {tareas.map((tarea) => (
        <View key={tarea.id}>
          <Text>{tarea.titulo}</Text>  
          <Text>{tarea.descripcion}</Text>
          <Text>{tarea.completada ? "✔ Completada" : "Pendiente"}</Text>
        </View>
      ))}
    </ScrollView>
  </View>
);
}


