float alphaVal = 127;
float baseStrokeSize = 20;
float alphaFade = 2;
float spread = 40;

void setup() {
  size(400, 400);
  background(0);
}

void draw() {
  fill(0, alphaFade);
  noStroke();
  rect(0, 0, width, height);
  
  if (mousePressed) {
    strokeWeight(baseStrokeSize);
    stroke(255, 0, 0, alphaVal);
    line(mouseX + random(-spread, spread), mouseY + random(-spread, spread), pmouseX, pmouseY);
    
    strokeWeight(baseStrokeSize/2);
    stroke(0, 255, 0, alphaVal);
    line(mouseX, mouseY, pmouseX, pmouseY);

    strokeWeight(baseStrokeSize/4);
    stroke(0, 255, 0);
    line(mouseX, mouseY, pmouseX, pmouseY);
  }
}
