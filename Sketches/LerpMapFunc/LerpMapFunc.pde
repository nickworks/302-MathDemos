
void setup(){
  size(500, 500);  
}

void draw(){
  background(0);
  
  float d = doMap(mouseX, 0, width, 10, 400); 
  
  ellipse(width/2, height/2, d, d);
  
}

float doLerp(float min, float max, float p){
  return (max - min) * p + min;
}
float doMap(float val, float inMin, float inMax, float outMin, float outMax){
  
  // 1. figure out the p
  float p = (val - inMin) / (inMax - inMin);
  
  // 2. lerp using the p
  return doLerp(outMin, outMax, p);
}
