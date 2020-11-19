#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>

#define LED 13
RF24 radio(7, 8); // CE, CSN
const byte address[6] = "00001";
void setup() {
  Serial.begin(9600);
  radio.begin();
  radio.openReadingPipe(1, address);
  radio.setPALevel(RF24_PA_MIN);
  radio.startListening();
  pinMode(LED,OUTPUT);
//  pinMode(LED, LOW);
//  pinMode(5,OUTPUT);
//  digitalWrite(4,LOW);
//  digitalWrite(5,LOW);
}

void loop() {
//  digitalWrite(LED,HIGH);
  if (radio.available()>0) {
    byte data[1] = {0, };
    radio.read(&data,sizeof(data));
    
    if (data[0] == 0)
      digitalWrite(13,LOW);
    if (data[0] == 1)
      digitalWrite(13,HIGH);
  }
//  else
//    Serial.println("radio unavailable");
}
