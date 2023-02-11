int pinout;
bool pinAsign = false;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()) {
    String data = Serial.readStringUntil('\n');
    int ind = data.indexOf('p');
    if (ind != -1) {
      int dataLength = data.length();
      pinout = data.substring(0, ind).toInt();
      pinMode(pinout, OUTPUT);
      digitalWrite(pinout, HIGH);
      Serial.println(pinout);
    }

    if (data == "HIGH") {
      digitalWrite(pinout, HIGH);
    } else if (data == "LOW") {
      digitalWrite(pinout, LOW);
    }
  }
}
