
int somma = 0; 

for (int i = 0; i < 10; i++){
    Console.WriteLine("inserisci un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    somma += numero;
}

Console.WriteLine(somma);
