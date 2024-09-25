// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

/*double radie=2.4;
Console.WriteLine("Cirklens omkrets"+ CirkelOmkrets(radie));
Console.WriteLine("Cirkelns area: "+ CirkelArea(radie));

double CirkelArea(double r){
    return (r * r * Math.PI);
}
double CirkelOmkrets(double r){
    return (r * 2 * Math.PI);
}*/

void Main(){
    Console.WriteLine("skriv tre tal");
    float a = Convert.ToInt32(Console.ReadLine());
    float b = Convert.ToInt32(Console.ReadLine());
    float c = Convert.ToInt32(Console.ReadLine());
    
}
float Mv(float a, float b, float c){
    return(a + b + c / 2);
}
Main()