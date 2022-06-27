

//SNACK 4, somma e media dei numeri da 2 a 10
int[] listaNumeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sommaNumeri = 0;
int mediaNumeri = 0;

for(int i = 0; i < listaNumeri.Length; i++){
    sommaNumeri += listaNumeri[i];
    mediaNumeri = sommaNumeri / listaNumeri.Length;
    
}

Console.WriteLine($"La somma dei numeri da 2 a 10 è {sommaNumeri} mentre la media è {mediaNumeri}");



return;

//SNACK 3, somma di 10 numeri chiesti dall'utente
int somma = 0; 

for (int i = 0; i < 10; i++){
    Console.WriteLine("inserisci un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    somma += numero;
}

Console.WriteLine(somma);
