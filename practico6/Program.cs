// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);
*/

//Ejercicio 1

int num, dec, cen, uni, nuevoNum;

Console.WriteLine("Ingrese un numero de tres cifras: ");
bool control=int.TryParse(Console.ReadLine(), out num);

if(control){

    dec=num/10;
    dec=dec%10;
    cen=num/100;
    uni=num%10;

    nuevoNum=(uni*100)+(dec*10)+cen;

    Console.WriteLine("Numero Invertido: "+nuevoNum);

}else{
    Console.WriteLine("No es un numero, Ingrese de nuevo");
}
