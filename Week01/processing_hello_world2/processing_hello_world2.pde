float posX = 100;
float speed = 2;
boolean isMoving = false;

void setup() {
  size(400, 400);
}

void draw() {
  // You can also use this to write notes
  //background(220);
  
  stroke(255, 0, 0);
  fill(0, 255, 0);
  ellipse(posX, 200, 10, 10);
  
  if (isMoving) {
    posX += speed;
  }
  
  if (posX < 0 || posX > width) {
    speed *= -1;
  }
}

void keyPressed() {
  isMoving = !isMoving;
}
