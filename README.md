# JuegoCartaMayor
WPF

Carta Mayor

Carta Mayor corresponde a un simple juego de apuestas entre dos o más oponentes, los que sacarán una
carta de la baraja y la voltearán al mismo tiempo y el que haya sacado la carta más alta según su valor se
lleva el pozo que está en juego. La baraja está constituida por 52 cartas repartidas en cuatro palos y dos
cartas comodín, cada una contiene un valor numérico bien definido a excepción del Comodín, que vale 15, y
el As que vale 20.

Al comenzar el juego las 54 cartas son barajadas quedando desordenadas en el mazo central, luego los
jugadores lanzan sus apuestas sobre la mesa y reciben una carta, la cual volterán al mismo tiempo y quien
saque la carta mayor se lleva el pozo en juego. Las cartas ya utilizadas van quedando apiladas en un mazo
secundario, el que al terminarse todas las cartas será barajado nuevamente y el juego podrá recomenzar.
Los participantes por su parte tienen la oportunidad de retirase cuando así lo deseen, excepto si es que ya
se encuentran en un juego, ya que est´an obligados a hacer una apuesta en cada jugada.

Requisitos

Se le pide desarrollar una aplicación que simule el juego de Carta Mayor, considerando que el juego puede
llevarse a cabo en dos versiones una entre el PC v/s Usuario y otra entre Usuario v/s Usuario.
Algunas consideraciones importantes que se deben tener en cuenta:

– El diseño de la interfaz gráfica es libre por parte de los equipos
– Crear una clase carta
– Crear un método que Baraje las cartas
– Trabajar con ArrayList o List
– Al principio del juego se escoje si se jugará en Usu. v/s PC o Usu. v/s Usu.
– Si se juega Usu. v/s PC el pc siempre apostará 1/4 más de lo que apostó el Usuario, siendo este último
quien haga primero la apuesta.
– Si salen cartas numéricamente iguales se deberá discriminar por pintas, según el siguiente orden de
importancia : Corazón, Pica, Diamante, Trébol. Si salen dos Comodín el juego queda empatado.
– Las apuestas solo serán válidas si son mayores a cero.
– Los jugadores pueden ver las ganacias que han obtenido.
