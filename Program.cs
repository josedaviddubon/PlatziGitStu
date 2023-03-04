int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
System.Random r = new System.Random();

string switchContro = "menu";

//BlackJack, 21 cartas o en caso de tener menos tener mayor puntaje que el dealer
/*
if (totalJugador > totalDealer)
{
    message = "Venciste al Dealer"; 
}
else if (totalJugador <= totalDealer)
{
    message = "Perdiste VS Dealer";
}
else
{
    message = "Condicion no valida";
}

Console.WriteLine(message);

*/
while (true)
{
    Console.WriteLine("Welcome al P L A T Z I N O");

    Console.WriteLine("¿Cuántos PlaztiCoins deseas? \n" +
        "Ingresa un número entero \n" +
        "Necesitas una por ronda de Juego"
        );
    ///
    ////.Parse convierte un entero al tipo de dato string
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        totalDealer = 0;
        totalJugador = 0;
        switch (switchContro)
        {
           
            case "menu":

                //Console.Clear();

                Console.WriteLine("WELCOME AL CASINO");
                Console.WriteLine("Escriba 21 para jugar el 21");
  
                switchContro = Console.ReadLine();

                i = i - 1;

                break;

            case "21":

                do
                {

                    num = r.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, Jugador");
                    Console.WriteLine($"Carta tomada: {num}");
                    Console.WriteLine("Deseas otra carta?");

                    controlOtraCarta = Console.ReadLine();
                }
                while (controlOtraCarta == "Si"
                        || controlOtraCarta == "si"
                        || controlOtraCarta == "yes"
                );

                totalDealer = r.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al Dealer, Tienes una vida mas";
      
                    platziCoins++;
                   

                    switchContro = "menu";
                    Console.Clear();
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste VS Dealer, Te pasaste de 21";
                    Console.Clear();
                    switchContro = "menu";
                }
                else if (totalJugador <= 22)
                {
                    message = "Perdiste VS Dealer";
                    Console.Clear();
                    switchContro = "menu";
                }
                else
                {
                    message = "Condicion no valida";
                    
                }
                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor no valido");
                break;
        }
    }
}

