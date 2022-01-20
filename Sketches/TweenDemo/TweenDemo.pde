

float xStart = 20;
float xEnd = 780;

float timeCurrent = 0;
float timeTotal = 1;

float timeStampPrev = 0;

void setup(){
  size(800, 500);
}

void draw(){
  background(64);
  
  float timeStamp = millis()/1000.0;
  float dt = timeStamp - timeStampPrev;
  timeStampPrev = timeStamp;
  
  // increase time
  timeCurrent += dt;
  
  float p = timeCurrent / timeTotal;
  p = constrain(p, 0, 1); // clamp
  
  // bending the percent curve
  // to add easing
  p = p * p * (3 - 2 * p);
  
  float x = lerp(xStart, xEnd, p);
  
  ellipse(x, height/2, 30, 30);
}

void mousePressed(){
  timeCurrent = 0;
}
