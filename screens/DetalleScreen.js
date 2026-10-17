import {View,Text,Button,StyleSheet} from 'react-native';

export default function DetalleScreen({ navigation }) {
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Pantalla de detalle</Text>
      <Button 
        title="Regresar ainicio" 
        onPress={() => { navigation.goBack(); }}
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