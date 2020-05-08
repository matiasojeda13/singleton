# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Código de ejemplo del patrón [Singleton](https://en.wikipedia.org/wiki/Singleton_pattern)

En este ejemplo la clase `Greeter` es un singleton: solo existe una instancia de esa clase a la cual se accede mediante
una propiedad de clase `Instance` de tipo `Greeter`.

Además la clase `Greeter` implementa un método de instancia `void SayHiToTheWorld()` que es el verdadero propósito de esta
clase.

### Desafío

Usando tipos genéricos implementen un tipo `Singleton<T>` genérico cuyo tipo parámetro pueda ser cualquier clase; en
particular `Greeter`, es decir, el tipo construido quedaría `Singleton<Greeter>`.

El programa una vez modificado debería lucir así:

```cssharp
static void Main(string[] args)
{
    Singleton<Greeter>.Instance.SayHiToTheWorld();
}
```

Como la implementación del singleton les va a quedar en `Singleton<T>`, dejen en `Greeter` sólo el método
`void SayHiToTheWorld()`.

El tipo genérico `Singleton<T>` crea una instancia de `T`; para que eso sea posible es necesario agregar una restricción
en la declaración del tipo genérico para forzar que T tenga un constuctor sin parámetros; eso se logra con la
declaración `Singleton<T> where T : new()`.
