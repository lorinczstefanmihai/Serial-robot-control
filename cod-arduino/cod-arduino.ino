//we define each servomotor with the pin where is connected
#define height_arm 5
#define left_arm 6
#define right_arm 7

int k = 0;  

void setup() {

  PORTD = 0; //to be sure that every pin is in 0 state
  DDRD = 0XE0; // we initialize the direction register of PORTD with output value (1)

  Serial.begin(9600); //we initialize the uart communication
}

void loop() {

  while (Serial.available()) {  //we check if there are some data in buffer
    int poz = Serial.parseInt();  //we empty the buffer by taking whats inside 
    k = 0;

    while (k <= 10) {
      if (poz % 10 == 1) {  //to determine which servomotor to activate, we examine the last value that we have read.
        PORTD &= ~(1 << height_arm);
        delayMicroseconds(20000 - (poz / 10)); //pwm modulation for control
      }

      if (poz % 10 == 2) {
        PORTD |= (1 << left_arm); 
        delayMicroseconds(poz / 10);
        PORTD &= ~(1 << left_arm);
        delayMicroseconds(20000 - (poz / 10));
      }

      if (poz % 10 == 3) {
        PORTD |= (1 << right_arm); 
        delayMicroseconds(poz / 10);
        PORTD &= ~(1 << right_arm);
        delayMicroseconds(20000 - (poz / 10));
      }
      k++;
    }
  }
}
