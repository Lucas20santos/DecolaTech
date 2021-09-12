# Orientação a Objetos

## Classes e Objetos

Classes são os tipos mais fundamentais de Csharp

estado = campos da classes
ações = métodos da classes

Objetos são instâncias de uma classes

As classes suportam heranca e polimorfismo

```.
public class Ponto
{
    public int x, y;
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
```

## Membros

- estático pertence a classe
- dinâmico pertence ao objeto

## Acessibilidade

- public
- protected
- internal
- private

## Herança

uma classe pode herdar as características de outra classe
