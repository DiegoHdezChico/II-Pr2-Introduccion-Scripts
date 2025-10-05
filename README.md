# Inerfaces Inteligentes. Pr2. IntroducciónC#. Scripts

A continuación se desglosa cada una de las actividades realizadas para llevar a cabo esta práctica.

## Actividades realizadas.

### Ejercicio 1
Para esta actividad, hemos creado el un [script](scripts/Ejercicio1.cs) en el que se inicializa un vector con valores aleatorios en un primer momento para aplicar al objeto enlazado como su color actual, para ello, usamos `Random.value`, generando así **números aleatorios del 0 al 1**. Además, utilizamos un contador que incializamos a cero para más adelante. De este modo, ya está todo preparado para que cada vez que se llame a `Update` se incremente el contador y, en caso de tener un valor de 120, se vuelva a poner a 0 y se tome valor aleatorio de entre 0 y 2 mediante `Random.Range(0,3)` y se cambie el valor de ese índice aleatorio del vector de colores del `GameObject`.

---

### Ejercicios 2 y 3.
Esta parte la hemos abordado mediante un [script](scripts/Ejercicio2Y3.cs) en el que se ha hecho especial uso de los diferentes métodos de la clase `Vector3`, como `Distance()` para calcular la distancia o `Angle()` para calcular el ángulo entre los vectores.

Por otra parte, para imprmir el vector de distancia del objeto enlazado, no ha sido necesario más que utilizar el método `GetComponent<Transform>()`, para obtener el `Transform` del mismo y poder imprimir por consola su `transform.position`.

---

### Ejercicio 4.
El [script](scripts/Ejercicio4.cs) que hemos creado para resolver este ejercicio es en realidad bastante sencillo, puesto que gracias a `GameObject.FindObjectWithTag` hemos sido capaces de conseguir rápidamente las referencias al cubo y al cilindro, los cuales habíamos etiquetado previamente, de manera que hemos podido calcular de nuevo las distancias con `Vector3.Distance()`.

---

### Ejercicio 5.
Para este ejercicio, hemos generado un [script](scripts/Ejercicio5Y11.cs) en el cual, se han especificado una serie de vectores (públicos para poder ser modificados desde el inspector) y luego se han obtenido las referencias de los objetos que queremos desplazar. A continuación, hemos utilizado `Input.GetKey(KeyCode.Space)` para especificar que en el momento en el que se pulse el espacio, se sume (dado que es un **desplazamiento**) el vector de direcciones que hemos especificado a la posición de cada una de las referencias de los objetos.

---

### Ejercicio 6.
Como se puede apreciar en el siguiente [script](scripts/Ejercicio6Y12.cs), para lograr nuestro objetivo, en este caso hemos utilizado los `GetKey()` pertinentes para que cada vez que se pulse una de las flechas se realice una acción, que no es otra que la de sumar la velocidad a la coordenada pertinente. En este caso, es muy importante remarcar que hemos agregado también como factor de multiplicación a `Time.deltaTime`, el cual mide el tiempo transcurrido entre un frame y otro para que el movimiento no dependa de la potencia del ordenador.

--- 

### Ejercicio 7.
Para poder realizar este ejercicio, hemos tenido que seguir la siguiente ruta:

`Edit` -> `Project Settings` -> `Input Manager` -> `Fire1` -> `Possitive Button`.

Una vez alcanzado este campo, sólo hemos tenido que cambiar su valor a la tecla **H**.

---

### Ejercicio 8.
Una vez más, para llevar a cabo este ejericicio, ha sido necesario crear un [script](scripts/Ejercicio8.cs) en el cual se definen una serie de propiedades públicas (el vector de desplazamiento y la velocidad), una vez más para poder ser modificadas desde el inspector. Además, se llevan a cabo la aplicación de las restricciones iniciales en el `Start()`. Luego hemos utilizado el método `Translate()` para desplazar el cubo en la dirección indicada por el vector a la velocidad especificada.

---

### Ejercicio 9.
Para este ejericio, hemos creado un [script](scripts/Ejercicio9_1.cs) para asignar al cubo y permitir su movimiento con las **flechas del teclado**. Y [otro](scripts/Ejercicio9_2.cs) diferente para la esfera, esta vez para que su movimiento fuera mediante las teclas **wasd**. En esta ocasión, hemos utilizado métodos y propiedades mencionadas anteriormente, por lo que no hay nada especialmente importante a destacar.

---

### Ejercicio 10.
En este caso, lo único que hemos tenido que hacer es adaptar el los scripts del ejericio 9 para agregar como factor a la multiplicación que determinará el movimiento el campo `time.deltaTime`

---

### Ejercicio 11.
En este caso, hemos añadido al [script del ejercicio 5](scripts/Ejercicio5Y11.cs) que en cada `Update()` el cubo se traslade en la dirección de la esfera (gracias a la distancia que los separa a ambos). Para que esta distancia no afectara al movimiento, hemos tenido que normalizar el vector vector con la propiedad `normalize`.

---

### Ejercicio 12.
En este caso, ha sido necesario modificar el [script del ejericio 6](scripts/Ejercicio6Y12.cs) y utilizar el método `LookAt()` pasándole el **transform de la esfera**. De esta manera, hemos logrado que el cubo rotase en su eje para mirarla siempre directamente.

---

### Ejercicio 13.
Finalmente, el [script](scripts/Ejercicio13.cs) para el último ejercicio se ha basado en utilizar la propiedad `eulerAngles` para obtener un `Vector3` con la rotación del cubo, para luego hacerlo girar en el valor indicado por `Input.GetAxis("Horizontal")`.