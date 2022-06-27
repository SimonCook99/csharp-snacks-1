string[] listaOpzioni = { "sasso", "carta", "forbici" };
string sceltaUtente = "";

Console.WriteLine("Giochiamo a sasso-carta-forbici :)");

while (!listaOpzioni.Contains(sceltaUtente)){

    Console.WriteLine("Inserisci la tua scelta: sasso, carta o forbici?");
    sceltaUtente = Console.ReadLine();
}

int sceltaComputer = new Random().Next(0, listaOpzioni.Length);
Console.WriteLine(listaOpzioni[sceltaComputer]);

bool vittoriaCarta = sceltaUtente == "carta" && listaOpzioni[sceltaComputer] == "sasso";
bool vittoriaSasso = sceltaUtente == "sasso" && listaOpzioni[sceltaComputer] == "forbici";
bool vittoriaForbici = sceltaUtente == "forbici" && listaOpzioni[sceltaComputer] == "carta";

if (sceltaUtente == listaOpzioni[sceltaComputer]){
    Console.WriteLine("Abbiamo scelto la stessa cosa, parità");
}
else{
    if(vittoriaCarta || vittoriaSasso || vittoriaForbici){
        Console.WriteLine("Hai vinto!!");
    }
    else{
        Console.WriteLine("Ha vinto il computer");
    }
}





return;
//SNACK 10, generare N array con numeri casuali, dove N è chiesto dall'utente
Console.Write("Quanti array vuoi generare? ");
int numeroArray = int.Parse(Console.ReadLine());

int[] arrayNumeri;

for(int i = 0; i < numeroArray; i++){
    arrayNumeri = new int[10];
    for(int j = 0; j < arrayNumeri.Length; j++){
        arrayNumeri[j] = new Random().Next(1, 101);

        Console.WriteLine(arrayNumeri[j] + "\t");
    }

    Console.WriteLine();
}

return;
//SNACK 5, chiediamo un numero all'utente: se è pari lo stampo altrimenti stampo il successivo
Console.Write("Inserisci un numero");
int numeroUtente = int.Parse(Console.ReadLine());

if(numeroUtente % 2 == 0){
    Console.WriteLine("Hai inserito " + numeroUtente);
}
else{
    Console.WriteLine($"Il numero successivo a quello inserito è: {numeroUtente + 1}");
}


return;
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
