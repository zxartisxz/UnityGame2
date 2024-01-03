##https://www.pinterest.com/pin/ATZmqvsWMLDazqb-gjpoWuFgagQUHVBsdslh_qA90DjB3euoTeXViOQ/
theta = 0:0.02*pi:500*pi;

##r=0.3 -2*sin(theta);
r=7*sin(7*theta);

##r=cos(theta);
##figure(1)
##plot(theta,r),xlabel("theta"),ylabel("r"),grid minor,
##figure(2)
##polar(theta,r),xlabel("theta"),ylabel("r"),grid minor,

##figure(3)

x =r.*cos(theta)*360;
y =r.*sin(theta)*360/4;
##plot(x,y),xlabel("x"),ylabel("y"),grid minor,

figure(4)

##xx = cos(theta) .* rand(1,201)*720;
##yy = sin(theta) .* rand(1,201)*360;
b= sqrt(pi);
a = 1.618;
a/b
xx = (a* cos(theta) + b* cos((a-b)/b* theta))*3.6;
yy = (a* sin(theta) - b* sin((a-b)/b* theta))*1.8;
plot(xx,yy),