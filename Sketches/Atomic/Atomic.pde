// Animate 3 electrons orbiting around a nucleus.
// Each electron should follow a path and match
// colors with its respective path.

// Don't use rotate()
// Use vectors and trigonometry

void setup(){
  size(400, 400);
}
void draw(){
  
  drawBackground();
  
  ///////////////// START YOUR CODE HERE:
  
  
  
  ///////////////// END YOUR CODE HERE
  
}
void drawBackground(){
  background(0);
  noStroke();
  fill(255);
  ellipse(200,200,50,50);
  noFill();
  strokeWeight(5);
  
  pushMatrix();
  translate(200,200);
  stroke(255,100,100);
  ellipse(0,0,300,100);
  popMatrix();
  
  pushMatrix();
  translate(200,200);
  rotate(PI/1.5);
  stroke(100,255,100);
  ellipse(0,0,300,100);
  popMatrix();
  
  pushMatrix();
  translate(200,200);
  rotate(2*PI/1.5);
  stroke(100,100,255);
  ellipse(0,0,300,100);
  popMatrix();
}
