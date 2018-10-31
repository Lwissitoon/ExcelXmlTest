// Example program
#include <iostream>
#include <string>
#include <math.h>
using namespace std;

 
int
main () 
{
  
double deuda;
  
double tasa;
  
double tiempo;
  
double renta;
  
double interes;
  
double amortizacion;
  
double deudaPorAmortizar;
  
double deudaAmortizada;
  
cout << "cual es la deuda ";
  
cin >> deuda;
  
cout << "cual es la tasa? ";
  
cin >> tasa;
  
 
cout << "cual es la tiempo? ";
  
cin >> tiempo;
  
 
    //renta =deuda/((1-(pow((1+tasa),-tiempo))/tasa));
    cout << "Cual es la renta? ";
  
cin >> renta;
  
 
cout << "renta" << " | " << "interes" << " | " << "amortizacion" << " | "
    << "deudaPorAmortizar" << " | " << "deudaAmortizada" << endl;
  
for (int i = 0; i <= tiempo; i++)
    
    {
      
interes = (deuda * tasa);
      
amortizacion = (renta - (deuda * tasa));
      
deudaPorAmortizar = deuda - amortizacion;
      
deudaAmortizada += amortizacion;
      
deuda -= (renta - amortizacion);
      
cout << renta << " | " << interes << " | " << amortizacion << " | " <<
	deudaPorAmortizar << " | " << deudaAmortizada << endl;

 
} 
}
