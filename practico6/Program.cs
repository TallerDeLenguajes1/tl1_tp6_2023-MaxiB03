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

//EJERCICIO 1

/*
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
*/

//EJERCICIO 2

int op, num1, num2, resul, resp;

do
{
    Console.WriteLine("Operaciones:");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("Selecionar Operacion: ");
    op=int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese un numero: ");
    bool control1=int.TryParse(Console.ReadLine(), out num1);

    Console.WriteLine("Ingrese otro numero: ");
    bool control2=int.TryParse(Console.ReadLine(), out num2);

    if(control1 && control2){

        if(op==1){
            resul=num1+num2;
            Console.WriteLine("El resultado de la Suma es:"+resul);

        }else if(op==2){
            resul=num1-num2;
            Console.WriteLine("El resultado de la Resta es:"+resul);

        }else if(op==3){
            resul=num1*num2;
            Console.WriteLine("El resultado de la Multiplicacion es:"+resul);

        }else if(op==4){
            resul=num1/num2;
            Console.WriteLine("El resultado de la Division es:"+resul);

        }else{
            Console.WriteLine("La operacion ingresada no existe, Ingrese nuevamente");
        }

    }else{
        Console.WriteLine("Algun dato Ingresado no es un numero, Ingrese nuevamente");
    }

    Console.WriteLine("Desea Realizar otra Operacion?(Si=1)(No=0)");
    resp=int.Parse(Console.ReadLine());


} while (resp!=0);
