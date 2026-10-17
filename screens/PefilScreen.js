import {View, Text, Button, StyleSheet} from 'react-native';

export default function PerfilScreen({navigation}) {
  return (
    <View style={styles.container}>
      <Text style={styles.titulo}>Pantalla perfil</Text>
      <Button title="Ir a Formulario" onPress={() => navigation.navigate('Formulario')} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: '#e0f0ff',
    },
  titulo: {
    fontSize: 24,
    marginTop: 20,
  },
});