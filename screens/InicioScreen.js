import {View,Text,Button,StyleSheet} from 'react-native';

export default function InicioScreen({ navigation }) {
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Pantalla de inicio</Text>
      <Button 
        title="Ir a otra pantalla" 
        onPress={() => { navigation.navigate('Formulario'); }}
      />
    </View>
  );

}

const styles = StyleSheet.create({
    container : {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
        backgroundColor: 'blue',
    },
    titulo : {
        fontSize: 24,
        marginBottom: 20,
    },
});