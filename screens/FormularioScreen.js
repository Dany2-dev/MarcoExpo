import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, Button, TextInput, ScrollView, Image } from 'react-native';
import { useState } from 'react';

export default function FormularioScreen({ navigation }) {
  return (
    <ScrollView
      style={{ flex: 1, backgroundColor: '#F527E0' }}
      contentContainerStyle={{ alignItems: 'center', justifyContent: 'center', padding: 20, }}
    >
      <View style={{ alignItems: 'center', justifyContent: 'center', backgroundColor: '#A327F5' }}>
        <Image
          source={require('../assets/icon.png')}
          style={{ width: 200, height: 200 }}
        />
        <Text>los femboys</Text>
        <Text>cual es tu favorito</Text>
        <View style={{ width: 100, borderBlockColor: '#000000' }}>
          <Text>correo:</Text>
          <TextInput style={{
            backgroundColor: '#ffffff', alignSelf: 'stretch',
            borderWidth: 1,
            borderColor: '#ccc',
            padding: 10,
            borderRadius: 5,
            marginTop: 5,
            marginBottom: 10
          }} />
          <Text>tel:</Text>
          <TextInput style={{
            backgroundColor: '#ffffff',
            borderWidth: 1,
            borderColor: '#ccc',
            padding: 10,
            borderRadius: 5,
            marginTop: 5,
            marginBottom: 10
          }} />
        </View>
        <Button title="enviar" />
      </View>
    </ScrollView>
  );
}