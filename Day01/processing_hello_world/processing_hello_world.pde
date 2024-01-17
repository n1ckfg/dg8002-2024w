float posX = 100;
float speed = 2;

void setup() {
  size(400, 400);
}

void draw() {
  background(220);
  
  stroke(255, 0, 0);
  fill(0, 255, 0);
  ellipse(posX, 200, 10, 10);
  
  posX += speed;
  
  if (posX < 0 || posX > width) {
    speed *= -1;
  }
}
