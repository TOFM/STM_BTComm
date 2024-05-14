#include <MouseMaster.h>
#include <STMMemEmul.h>
// #include <Mouse.h>
// #include <Keyboard.h>
#include <string>
#include <cmath>
#include <bitset>

uint16_t EEPROMsize = 512;
bool debug = true;

void setup() {
  bool is_set14, is_set15 = 0;
  typedef std::bitset<sizeof(int)> IntBits;
  float coords[EEPROMsize / 4];
  uint16_t readData;
  uint16_t coordCount = 0;

  Serial.begin(9600);
  Mouse.begin();
  Keyboard.begin();
  delay(400);

  pinMode(C13, OUTPUT);
  digitalWrite(C13, LOW);

  // MM init
  MM.setScreenResolution(1280, 800);  // Resolution not forced properly // 100px 2cm Corr-1
  MM.setCorrectionFactor(1);
  MM.setJumpDistance(10);

  //Read from Emulated EEPROM
  //Serial.println("___read___");
  for (int i = 0; i < 3; i++) {
    coordCount++;

    readData = EEPROM.read(i * 2);
    readData <<= 8;
    readData += EEPROM.read((i * 2) + 1);

    if (coordCount % 3 == 0) {
      is_set14 = IntBits(readData).test(14);
      is_set15 = IntBits(readData).test(15);

      if (is_set15 == 0 && is_set14 == 0) {
        coords[i] = float(readData) * 0.01;
      } else if (is_set15 == 0 && is_set14 == 1) {
        coords[i] = float(readData) * 10;
      } else if (is_set15 == 1 && is_set14 == 0) {
        coords[i] = float(readData) * 600;
      } else if (is_set15 == 1 && is_set14 == 1) {
        coords[i] = float(readData) * 36000;
      }
    } else {
      coords[i] = float(readData) / 100;
    }

    //Serial.println(readData, DEC);
    //Serial.println(coords[i]);
  }

  MM.home();  // Always home in setup()!

  for (int i = 0; i < 255 / 3; i++) {
    MM.moveClick(coords[i * 3], coords[(i * 3) + 1], true);
    delay(coords[(i * 3) + 2]);
  }
}

void loop() {
  blink(500);

  byte recievedData[EEPROMsize];
  int transformedData[EEPROMsize / 2];

  int counter = 0;
  int value = 0;

  if (Serial.available()) {
    int rdLen = Serial.readBytesUntil('f', recievedData, EEPROMsize);
    Serial.println(F("Recieved message"));

    //if(debug) Serial.println("TanslS");
    for (int i = 0; i < rdLen; i++) {
      switch (recievedData[i]) {
        case 49:
          recievedData[i] = 1;
          counter++;
          break;
        case 48:
          recievedData[i] = 0;
          counter++;
          break;
        default:
          break;
      }
      //if(debug) Serial.print(recievedData[i]);
    }
    //if(debug) Serial.println("TanslE");
    //if(debug) Serial.println(counter);

    //int iter = (counter+1)/8;

    for (int i = 0; i < counter / 16; i++) {  // Maybe counter can be replaced by rdLen
      for (int j = 0 + (16 * i); j < 16 + (16 * i); j++) {
        if (recievedData[j] == '\x1') {
          value += pow(2, 15 - (j - (16 * i)));
        }
        // if(debug){
        //   Serial.print(i);
        //   Serial.print(j);
        //   Serial.print("/");
        //   Serial.print(value);
        //   Serial.print("/");
        // }
      }
      transformedData[i] = value;
      //if(debug) Serial.println(value);
      value = 0;
    }
    // Use stoi(var, nullptr, 2) to convert binary string to dec // Do not use I guess

    // if(debug){
    //   Serial.println("\n_________________");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(recievedData[i]);
    //   Serial.print("/");
    //   }
    //   Serial.println("\n_________________\n");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(recievedData[i], HEX);
    //   Serial.print("/");
    //   }
    //   Serial.println("\n_________________\n");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(recievedData[i], BIN);
    //   Serial.print("/");
    //   }
    //   Serial.println("\n_________________\n");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(recievedData[i], DEC);
    //   Serial.print("/");
    //   }

    //   Serial.println("____Transformed_____");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(transformedData[i]);
    //   Serial.print("/");
    //   }
    //   Serial.println("____Transformed_____");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(transformedData[i], HEX);
    //   Serial.print("/");
    //   }
    //   Serial.println("____Transformed_____");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(transformedData[i], BIN);
    //   Serial.print("/");
    //   }
    //   Serial.println("____Transformed_____");
    //   for(int i = 0; i < iter; i++){
    //   Serial.print(transformedData[i], DEC);
    //   Serial.print("/");
    //   }
    //   Serial.println("__rdlen__");
    //   Serial.println(rdLen);
    //   Serial.println(rdLen, HEX);
    //   Serial.println(rdLen, BIN);
    // }

    for (int i = 0; i < rdLen / 16; i++) {
      byte tmp[1];

      tmp[0] = highByte(transformedData[i]);
      tmp[1] = lowByte(transformedData[i]);

      eeprom_write_bytes(i * 2, tmp, 2);

      // if(debug){
      //   String msg = "Adress: ";
      //   Serial.println("\n____write_____");
      //   Serial.println(msg.concat(i));
      //   Serial.println(tmp[0]);
      //   Serial.println(tmp[1]);
      // }
    }
  }
  // Make constants file for buttons [define RINSE x, y]
}

void blink(int del) {
  digitalWrite(PC13, HIGH);
  delay(del);
  digitalWrite(PC13, LOW);
  delay(del);
}
