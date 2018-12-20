import numpy as np
import matplotlib.pyplot as plt

def couchy(f, x0, x20, T, h): 
    x = [x0] 
    x2 = [x20] 

    for i in range( h): 
     k11 = f( x[-1], x2[-1]) 
     k21 = f( x[-1] + T/h/2*k11, x2[-1] + T/h/2*k11) 
     k31 = f( x[-1] + T/h/2*k21, x2[-1] + T/h/2*k21)  
     k41 = f( x[-1] + T/h*k31,   x2[-1] + T/h*k31) 
     x.append(x[-1] + T/h) 
     x2.append(x2[-1] + T/h/6*(k11 + 2*k21 + 2*k31 + k41)) 
    return x, x2 
def f( x, x2): 
    return  (x+x2) 
 

def true_x2(x):
    return (2*np.exp(x)-x-1)

x0 = 0 
x20 = 1 
T = 0.4 
h = 4 

x, x2 = couchy(f, x0, x20, T, h) 
x = np.linspace(0, T, h+1) 

plt.xlabel('x') 
plt.ylabel('x2') 
plt.plot(x, true_x2(x), "blue", label="true_x2") 
plt.plot(x, x2, "red", label="approximation_x2") 
plt.show() 
