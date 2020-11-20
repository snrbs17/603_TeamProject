#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
RF24 radio(7, 8); // CE, CSN
const byte address[6] = "00001";
void setup() {
  Serial.begin(115200);
  radio.begin();
  radio.openWritingPipe(address);
  radio.setPALevel(RF24_PA_MIN);
  radio.stopListening();
}
void loop() {
  
  char csharpData;
  if(Serial.available()>0)
  {
    csharpData = (char)Serial.read();
    if(csharpData =='1')
    {
      const byte data[] = {1};
      radio.write(&data, sizeof(data));
    }

    if(csharpData == '0')
    {
      const byte data[] = {0};
      radio.write(&data, sizeof(data));
    }
  }
}
