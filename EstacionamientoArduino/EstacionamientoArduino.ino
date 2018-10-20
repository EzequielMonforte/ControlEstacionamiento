#include <NewPing.h>
#include <Servo.h>

int distancia;
int distancia2;
bool puerta1Abierta = false;
bool puerta2Abierta = false;

long duracion = 0;
NewPing sensor1(7, 6, 40);
NewPing sensor2(13, 12, 40);
Servo puerta1;
Servo puerta2;


void setup() {
  puerta1.attach(9);
  puerta2.attach(2);// attaches the servo on pin 9 to the servo object
  puerta1.write(-180);
  puerta2.write(-180);
  Serial.begin(9600);

}
void loop()
{

  distancia = sensor1.ping_cm();
  distancia2 = sensor2.ping_cm();


  if (distancia < 6 && distancia > 0) {
    puerta1.write(180);
    puerta1Abierta = true;

  }



  if (distancia2 < 6 && distancia2 > 0 && puerta1Abierta != true) {
    puerta2.write(180);
    puerta2Abierta = true;

  }
  if (distancia > 6 && puerta1Abierta == true) {
    delay(5000);
    puerta1.write(-180);
    puerta1Abierta = false;

    Serial.println('0');

  }


  if (distancia2 > 6 && puerta2Abierta == true && distancia2 != 0) {
    delay(5000);
    puerta2.write(-180);
    puerta2Abierta = false;

    Serial.println('1');

  }



}
