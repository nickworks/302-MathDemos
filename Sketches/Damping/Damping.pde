
// exponential slide
// asymptotic easing
// damping

// 3 circles' x positions:
float x1, x2, x3;

// circle #2's velocity:
float v2;

void setup(){
  size(500, 500, P2D);
}

void draw(){
  background(0);
  
  // linear movement:
  
  if(x1 < mouseX) {
    x1 += 5;
    if(x1 > mouseX) x1 = mouseX;
  }
  else {
    x1 -= 5;
    if(x1 < mouseX) x1 = mouseX;
  }
  
  // use physics on circle 2:
  
  if(x2 < mouseX) v2 ++;
  else v2 --;
  v2 *= .95; // apply friction
  x2 += v2; // euler integration
  
  // use damping:
  
  // each tick move 50% to target
  //x3 += (mouseX - x3) * .1; // move 10% towards target
  x3 = lerp(x3, mouseX, .1);
  
  // draw circles:
  
  ellipse(x1, height*1/4, 25, 25);
  ellipse(x2, height*2/4, 25, 25);
  ellipse(x3, height*3/4, 25, 25);
}
