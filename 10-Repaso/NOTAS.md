

------------------------------------------------------------
-La contraseña PIN para este programa es "1234" Cristian :)-
------------------------------------------------------------



Notas
Repaso Segundo Parcial

## Cuándo usar while
Se usa cuando no sé de antemano cuántas veces se va a repetir el ciclo,
y la condición se revisa ANTES de ejecutar el bloque. Si la condición
es falsa desde el inicio, el ciclo nunca se ejecuta.

Ejemplo:
```csharp
int contador = 0;
while (contador < 5)
{
    Console.WriteLine(contador);
    contador++;
}
```

## Cuándo usar do-while
Es parecido al while, pero la condición se revisa DESPUÉS de ejecutar
el bloque. Esto garantiza que el código dentro del ciclo se ejecute
al menos una vez, aunque la condición sea falsa desde el principio.
Lo uso mucho en menús, para que se muestren al menos una vez.

Ejemplo:
```csharp
string opcion;
do
{
    Console.WriteLine("Menú...");
    opcion = Console.ReadLine();
} while (opcion != "salir");
```

## Cuándo usar for
Se usa cuando SÍ sé de antemano cuántas veces se va a repetir el ciclo,
o cuando necesito un contador que suba o baje de forma controlada.
Es compacto porque la inicialización, la condición y el incremento
van juntos en una sola línea.

Ejemplo:
```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```



