# TEST UNITARIOS

Son pruebas automatizadas que comprueban componetes y métodos de software individuales.

Las pruebas unitarias no se usan para comprobar problemas de infrastructura.(BBDD, sistemas de archivos, recursos de red, comunicación entre objetos).

## Procedimientos recomendados para la escritura de las pruebas
**Test driven development (TDD)**

1. Test antes del código
2. Diseñado para ayudar a desarrollar código simple, legible y eficaz
3. No incluir dependencias de bloques o componentes externos a lo que realmente queremos probar

Los test aportan otros beneficios como ayudar a los test de regresión, proporcionar documentación y facilitan un buen diseño.

## Porque usar los test

* Duran milisegundos, presionando un solo boton y no exigen necesariamente ningun conocimiento del negocio.
* Menos tiempo paa realizar las pruebas funcionales
* Protección frente a test de regresión
* Documentación ejecutable
* Código menos acoplado

Las pruebas unitarias deben de tener un nombre adecuado capaz de explicar el resultado esperado de una acción determinada. (*Documentación ejecutable*)

Se desacopla naturalmente el código, por lo difícil que sería porbar el código de otra forma.

## Caracteristicas de una buena prueba unitaria

* **Rápida** : tarda muy poco en ejeceutarse, del orden de milisegundos.
* **Aislada** : Independiente, ejecutables de forma aislada sin dependencias externas.
* **Reiterativa** : La prueba unitaria debe de ser coherente con sus resultados, y devolver los mismos resultados sino cambia nada entre ejecutables
* **Autocomprobada** : Detectar automáticamente si el resultado ha sido el correcto o incorrecto sin necesidad de intervencion humana.
* **Oportuna (Proporcionada)** : Escribir la prueba unitaria no debe de llevar mas tiempo que el desarrollo de la misma.


# Practicas Recomendadas
## 1. Asignar buenos nombres a las pruenas

    Consta de 3 partes
    * Nombre del método que vamos a testear
    * Escenario en el que es probado
    * Comportamiento esperado al invocar el escenario

Los estándares en las pruebas son importantes  porque expresan de forma explicita la intención de la prueba.

RECORDAR : vamos mas haya de garantizar que funciona el código, los test unitarios son también documentación ejecutable.

    BUSCAMOS: Ser capaces de leer que hace el código leyendo solo con el conjunto de pruebas

## 2. Organizar las pruebas (patrón AAA)
    Para organizar cada prueba y sigiendo el patrón triple A, haremos que consten de tres partes:
    * Arrange (Organizar):  crear objetos y configurarlos
    * Act (Actuar): LLamar al método a probar con los parámetros preparados
    * Assert (Confirmar): Comprobamos que el comportamiento del método es el esperado

Este patrón se considera una buena práctica. Más adelante hablaremos un poco mas sobre el.

Con este patrón separamos por una parte lo que estamos probando de las declaraciones. En segundo lugar separamos también el método que estamos probando y el comportamiento que esperamos, reduciendo la posibilidad de mezclar partes de lo que queremos probar con lo que esperaoms.

    BUSCAMOS: tener una mayor LEGIBILIDAD como objetivo principal


## 3. Escribir pruebas correctas lo mas sencillas posibles

## 4. Evitar cadenas mágicas

## 5. Evitar lógica en las pruebas

## 6. Todo el código visible en las pruebas

## 7. Evitar varias aserciones (hay una excepción)

## 8. Validar métodos privados mediante la prueba unitaria de métodos públicos

## 9: Referencias estáticas de STUB
