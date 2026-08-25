Notas  
Repaso Primer Parcial

Diferencia entre int y double
int guarda números enteros, sin parte decimal (ejemplo: 5, -3, 100).
double guarda números con decimales, con más precisión (ejemplo: 5.75, -3.2).
Uso int cuando cuento cosas completas (personas, productos), y double
cuando necesito precisión decimal (precios, distancias, promedios).

Qué es el casting
El casting es convertir un valor de un tipo de dato a otro. Por ejemplo,
convertir un int a double para poder dividir con decimales, o un
double a int para descartar la parte decimal. Se hace escribiendo
el tipo entre paréntesis antes del valor, como (double)a.

Cuándo se usa %
El operador % (módulo) da el residuo de una división. Se usa cuando
necesito saber si un número es divisible entre otro (por ejemplo, para
saber si es par con numero % 2 == 0), o para separar unidades, como
convertir segundos en horas, minutos y segundos.