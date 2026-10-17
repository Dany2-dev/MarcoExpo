import { NavigationContainer } from '@react-navigation/native';
//import { createNativeTabNavigator } from '@react-navigation/native-tab';
import {createBottomTabNavigator} from '@react-navigation/bottom-tabs';
import { Ionicons } from '@expo/vector-icons';
import InicioScreen from './screens/InicioScreen';
import DetalleScreen from './screens/DetalleScreen';
import FormularioScreen from './screens/FormularioScreen';
import PerfilScreen from './screens/PefilScreen';
import LicenciaScreen from './screens/LicenciaScreen';
import TareasScreen from './screens/TareasScreen';


//const Stack = createNativeTabNavigator();
const Tab = createBottomTabNavigator();

export default function APP(){
  return (
    <NavigationContainer>
      <Tab.Navigator 
        screenOptions={({ route }) => ({
          tabBarIcon: ({color,size}) => {
            let iconName;
            if(route.name === 'Inicio')
              iconName = 'home';
            else if (route.name === 'Detalle')
              iconName = 'information-circle';
            else if (route.name === 'Formulario')
              iconName = 'create';
            else if (route.name === 'Perfil')
              iconName = 'person';
            else if (route.name === 'Licencia')
              iconName = 'document';
            else if (route.name === 'Tareas')
              iconName = 'list';
            return <Ionicons name={iconName} size={size} color={color} />;
        },
        tabBarActiveTintColor: '#007AFF',
        tabBarInactiveTintColor: 'gray',
       }
       )}>
        <Tab.Screen name = 'Inicio' component = {InicioScreen } />
        <Tab.Screen name = 'Detalle' component = {DetalleScreen } />
        <Tab.Screen name = 'Formulario' component = {FormularioScreen } />
        <Tab.Screen name = 'Perfil' component = {PerfilScreen } />
        <Tab.Screen name = 'Licencia' component = {LicenciaScreen } />
        <Tab.Screen name = 'Tareas' component = {TareasScreen } />
      </Tab.Navigator>
    </NavigationContainer>
  );
}