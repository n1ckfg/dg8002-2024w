float bob = 100;
float speed = 2;

void setup() {
  size(400, 400);
}

void draw() {
  background(220);
  
  stroke(255, 0, 0);
  fill(0, 255, 0);
  ellipse(bob, 200, 10, 10);
  
  bob += speed;
  
  if (bob < 0 || bob > width) {
    speed *= -1;
  }
}
