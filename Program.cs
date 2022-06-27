
//SNACK GIOCO SASSO CARTA FORBICI
string[] listaOpzioni = { "sasso", "carta", "forbici" };
string sceltaUtente = "";

Console.WriteLine("Giochiamo a sasso-carta-forbici :)");

//chiedo all'utente quante partite fare
Console.WriteLine("quante partite vuoi fare?");
int numeroPartite = int.Parse(Console.ReadLine());

int contatore = 0; //contatore che tiene traccia della partita corrente

int punteggioUtente = 0, punteggioComputer = 0;

//i 2 array conterranno le rispettive mosse fatte dall'utente e dal PC
string[] listaMosseUtente = new string[numeroPartite];
string[] listaMossePC = new string[numeroPartite];


//Proseguirò nel programma solo quando viene scritto un valore corretto
while (!listaOpzioni.Contains(sceltaUtente)){

    Console.WriteLine("Inserisci la tua scelta: sasso, carta o forbici?");
    sceltaUtente = Console.ReadLine();
}


while(contatore < numeroPartite){

    //estraggo un indice casuale, per randomizzare la scelta del computer
    int sceltaComputer = new Random().Next(0, listaOpzioni.Length);

    listaMossePC[contatore] = listaOpzioni[sceltaComputer];
    listaMosseUtente[contatore] = sceltaUtente;
    
    contatore++;

    Console.WriteLine(listaOpzioni[sceltaComputer]);

    //bool di logica per il calcolo della vittoria o sconfitta
    bool vittoriaCarta = sceltaUtente == "carta" && listaOpzioni[sceltaComputer] == "sasso";
    bool vittoriaSasso = sceltaUtente == "sasso" && listaOpzioni[sceltaComputer] == "forbici";
    bool vittoriaForbici = sceltaUtente == "forbici" && listaOpzioni[sceltaComputer] == "carta";

    if (sceltaUtente == listaOpzioni[sceltaComputer]){
        Console.WriteLine("Abbiamo scelto la stessa cosa, parità");
        
        if(contatore != numeroPartite){
            Console.WriteLine("Ora cosa scegli: sasso, carta o forbici?");
            sceltaUtente = Console.ReadLine();
        }
    }
    else{
        if(vittoriaCarta || vittoriaSasso || vittoriaForbici){
            Console.WriteLine("Hai vinto!!");
            punteggioUtente++;

            if (contatore != numeroPartite){
                Console.WriteLine("Ora cosa scegli: sasso, carta o forbici?");
                sceltaUtente = Console.ReadLine();
            }
        }
        else{
            Console.WriteLine("Ha vinto il computer");
            punteggioComputer++;

            if (contatore != numeroPartite){
                Console.WriteLine("Ora cosa scegli: sasso, carta o forbici?");
                sceltaUtente = Console.ReadLine();
            }
        }
    }
}

//alla fine di tutti i match vediamo chi ha vinto in base al punteggio
if (punteggioUtente > punteggioComputer)
{
    Console.WriteLine("\nComplimenti, mi hai battuto");
}
else if (punteggioUtente < punteggioComputer){
    Console.WriteLine("\nHAHAHAHA ti ho battuto");
}
else{
    Console.WriteLine("\nabbiamo pareggiato");
}

//resoconto finale dove mostro anche tutte le mosse fatte
for(int i = 0; i < listaMosseUtente.Length; i++){
    Console.WriteLine($"Partita {i}: \t la tua mossa: {listaMosseUtente[i]} \t la mossa del PC: {listaMossePC[i]} ");
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
