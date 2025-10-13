Aluno: Gustavo Bezerra Assumção -- Rm553076

Instruções gerais:
Leia atentamente cada questão antes de responder.

Use exemplos em C# quando solicitado.

A prova deverá ser realizada individualmente

* ## Conceitos fundamentais 
Explique, com suas próprias palavras, os quatro princípios básicos da Orientação a Objetos: encapsulamento, herança, polimorfismo e abstração. Para cada princípio, cite um exemplo simples em C# que ilustre seu uso. (Referência aos princípios.)

* encapsulamento:
    Serve para proteger os dados dentro da classe, utilizando os metodos de acesso: public, private e protected. Protegendo os dados do resto do código, ou deixando todos acessarem a depender do acesso.

    namespace Polimorfismo
    {
        // abstract class - não pode criar coisas diretamente dela
        abstract class Veiculo
        {
            // Somente quem está dento da classe veiculo tem acesso as dados e as variaveis definidas como protected
            protected string placa;
            protected string chassi;
            protected string cor;
            protected string motor;

            bool motorLigado;
            protected int pessoas;
            protected int capacidadePessoa;
            protected float estadoTanque;

            // Qualquer um pode em qualquer parte do código pode chamar essa função, pois está publica
            public void LigarMotor()
            {
                motorLigado = true;
                //Console.WriteLine("O motor do veículo de placa " + placa + " está ligado.");
            }

            public void DesligarMotor()
            {
                motorLigado = false;
            }

            public int EstadoTanque()
            {
                return (int)(estadoTanque * 100);
            }

            public void AdicionarPessoas(int pessoas)
            {
                if (pessoas > capacidadePessoa)
                {
                    Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
                }

                this.pessoas += pessoas;
            }

            // método virtual - pode ser sobrescrito, mas não é obrigatório
            // método abstrato - deve ser sobrescrito em todas as classes filhas
            public virtual string VerificarPessoas()
            {
                return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
            }
        }
    }

    

* herança: 
    Todas as classes filhas tem acesso as variaveis criadas pela pai, exeto se as variaveis forem definidas com protected. Ela nomalmente é definida no inicio do código por: internal "class Nome : ClassePai"

    * Classe Pai: 
        // abstract class - não pode criar coisas diretamente dela
        abstract class Veiculo
        {
            protected string placa;
            protected string chassi;
            protected string cor;
            protected string motor;

            bool motorLigado;
            protected int pessoas;
            protected int capacidadePessoa;
            protected float estadoTanque;

            public void LigarMotor()
            {
                motorLigado = true;
                //Console.WriteLine("O motor do veículo de placa " + placa + " está ligado.");
            }

            public void DesligarMotor()
            {
                motorLigado = false;
            }

            public int EstadoTanque()
            {
                return (int)(estadoTanque * 100);
            }

            public void AdicionarPessoas(int pessoas)
            {
                if (pessoas > capacidadePessoa)
                {
                    Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
                }

                this.pessoas += pessoas;
            }

            // método virtual - pode ser sobrescrito, mas não é obrigatório
            // método abstrato - deve ser sobrescrito em todas as classes filhas
            public virtual string VerificarPessoas()
            {
                return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
            }
        }

    * Classe Filho:
        namespace Polimorfismo
        {
            internal class Carro : Veiculo
            {
                string modelo;

                public Carro(string placa, string modelo, string cor, string motor)
                {

                    capacidadePessoa = 4;
                    this.placa = placa;
                    this.modelo = modelo;
                    Random random = new Random();

                    chassi = random.Next().ToString("00000000000000000");
                }
            }
        }


* polimorfismo
    O polimorfismo permite existir diferentes versoes do mesmo metodo em diferentes classes, padronizando a resposta e economizando código, mas essas diferentes versões podem ser expecificas para se adequar para cada classe, podendo ser exatamete a mesma coisa ou não. 
    E para definir se será a mesma coisa usamos o parametro: virtual (pode ser sobrescrito, mas não é obrigatório) ou abstrato (deve ser sobrescrito em todas as classes filhas)

    * Classe pai:
        namespace Polimorfismo
        {
            // abstract class - não pode criar coisas diretamente dela
            abstract class Veiculo
            {
                protected string placa;
                protected string chassi;
                protected string cor;
                protected string motor;

                bool motorLigado;
                protected int pessoas;
                protected int capacidadePessoa;
                protected float estadoTanque;

                public void LigarMotor()
                {
                    motorLigado = true;
                    //Console.WriteLine("O motor do veículo de placa " + placa + " está ligado.");
                }

                public void DesligarMotor()
                {
                    motorLigado = false;
                }

                public int EstadoTanque()
                {
                    return (int)(estadoTanque * 100);
                }

                public void AdicionarPessoas(int pessoas)
                {
                    if (pessoas > capacidadePessoa)
                    {
                        Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
                    }

                    this.pessoas += pessoas;
                }

                // método virtual - pode ser sobrescrito, mas não é obrigatório
                // método abstrato - deve ser sobrescrito em todas as classes filhas
                public virtual string VerificarPessoas()
                {
                    return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
                }
            }
        }

    * Classe Filha (sem modificar):
        namespace Polimorfismo
        {
            internal class Carro : Veiculo
            {
                string modelo;

                public Carro(string placa, string modelo, string cor, string motor)
                {

                    capacidadePessoa = 4;
                    this.placa = placa;
                    this.modelo = modelo;
                    Random random = new Random();

                    chassi = random.Next().ToString("00000000000000000");
                }
            }
        }

    * Classe Filha (modificando):
        namespace Polimorfismo
        {
            internal class Moto : Veiculo
            {
                string modelo;

                public Moto(string placa, string modelo, string cor, string motor)
                {
                    capacidadePessoa = 2;
                    this.placa = placa;
                    this.modelo = modelo;
                    this.cor = cor;
                    Random random = new Random();
                    chassi = random.Next().ToString("00000000000000000");
                }

                // override - sobrescreve o método da classe mãe
                public override string VerificarPessoas()
                {
                    return "Existe " + this.pessoas + " pessoas na Moto contando com o piloto";
                }
            }
        }

* abstração:
A classe abstrata geralmente é usada como base para outras clases, colocando metodos que as classes filhas tem em comum, normalmente ela é usada como classe pai, usando a herança para ligar as filhas a ela. Fora que a classe abstrata não pode ser instanciada, ou seja, não cria memoria.

    * Classe pai:
        namespace Polimorfismo
        {

            // abstract class - não pode criar coisas diretamente dela
            abstract class Veiculo
            {
                protected string placa;
                protected string chassi;
                protected string cor;
                protected string motor;

                bool motorLigado;
                protected int pessoas;
                protected int capacidadePessoa;
                protected float estadoTanque;

                public void LigarMotor()
                {
                    motorLigado = true;
                    //Console.WriteLine("O motor do veículo de placa " + placa + " está ligado.");
                }

                public void DesligarMotor()
                {
                    motorLigado = false;
                }

                public int EstadoTanque()
                {
                    return (int)(estadoTanque * 100);
                }

                public void AdicionarPessoas(int pessoas)
                {
                    if (pessoas > capacidadePessoa)
                    {
                        Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
                    }

                    this.pessoas += pessoas;
                }

                // método virtual - pode ser sobrescrito, mas não é obrigatório
                // método abstrato - deve ser sobrescrito em todas as classes filhas
                public virtual string VerificarPessoas()
                {
                    return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
                }
            }
        }

    * Classe filha:
    namespace Polimorfismo
    {
        internal class Carro : Veiculo
        {
            string modelo;

            public Carro(string placa, string modelo, string cor, string motor)
            {

                capacidadePessoa = 4;
                this.placa = placa;
                this.modelo = modelo;
                Random random = new Random();

                chassi = random.Next().ToString("00000000000000000");
            }
        }
    }

--- 

* ## Classe vs. objeto
Descreva a diferença entre classe e objeto em C#. Em seguida, escreva um pequeno trecho de código que declara uma classe simples e cria uma instância (objeto) dessa classe.

* Classe:
    A classe vem antes do objeto, pois ela define a estrutura, atributos e os metodos primeiro antes de ser chamada.

    public class Carro
    {
        // Atributos da classe Carro
        public string Modelo;
        public string Cor;
        public int Ano;

        // Método para exibir informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}, Ano: {Ano}");
        }
    }


* Objeto:
        É o objeto que instancia a classe, seguindo a estrutura e metodos criada pela classe

        class Program
        {
            static void Main(string[] args)
            {
                // Criando um objeto da classe Carro
                Carro meuCarro = new Carro();

                // Definindo os valores dos atributos do carro
                meuCarro.Modelo = "Civic";
                meuCarro.Cor = "Prata";
                meuCarro.Ano = 2020;

                // Chamando o método para exibir informações do carro
                meuCarro.ExibirInformacoes();

                // Saída esperada: Modelo: Civic, Cor: Prata, Ano: 2020
            }
        }



---

* ## Modificadores de acesso
A apresentacao de slide menciona diferentes modificadores de acesso em C#: public, private e protected. Explique o significado de cada um e discuta em que situações eles devem ser utilizados ao projetar classes.

* public:
    A 'public' deve ser usada sempre que quiser criar uma variavel ou metodo que todo o código poder ver e acessar, mesmo quando não for da mesma classa ou hereança. Ela serve como um modificador global.
    Ela é muito boa para definir metodos que são usados em diversos contextos e classes diferentes.

* private
    O 'private' é o ideial para caso queira ser vista somente pelas classes filhas, protegendo os dados do resto do código, mas que ainda seja acessivel e visivel para as classes filhas. 

* protected
    Já o 'protected' deve ser usado para dados sensiveis, em que somente a classe atual poderar ver e acessar, nem mesmo as classes filhas terão acesso, sendo o mais protegido


---

* ## Sobrecarga e sobrescrita 
Defina sobrecarga (overloading) e sobrescrita (overriding) de métodos em C#. Explique as diferenças entre esses dois mecanismos de polimorfismo e forneça um exemplo de código para cada caso.

    * Sobrecarga (overloading):
        permite que existam vários métodos com o mesmo nome na mesma classe, desde que suas assinaturas (parâmetros) sejam diferentes. 
        
        Ela cria métodos com o mesmo nome, mas com uma quantidade, tipo ou ordem de parâmetros diferente, tudo dentro da mesma classe.

        abstract class Veiculo
        {
            protected int pessoas;
            protected int capacidadePessoa;

            // ...

            // MÉTODO ORIGINAL
            public void AdicionarPessoas(int quantidade)
            {
                if ((this.pessoas + quantidade) > capacidadePessoa)
                {
                    Console.WriteLine("Não é possível adicionar " + quantidade + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
                }
                else
                {
                    this.pessoas += quantidade;
                }
            }

            // SOBRECARGA DO MÉTODO
            // Adiciona apenas uma pessoa, sem a necessidade de passar a quantidade.
            public void AdicionarPessoas()
            {
                // Chama a versão original do método com o valor 1
                this.AdicionarPessoas(1);
            }
        }

    * Sobrescrita (overriding):
        acontece quando uma classe filha fornece uma implementação nova e específica para um método que foi herdado de sua classe pai.
        
        Consiste em reimplementar um método da classe pai na classe filha. O método na classe pai deve ser `virtual` ou `abstract`, e a assinatura na classe filha deve ser idêntica, usando a palavra-chave `override`.

        * Classe Pai:
        abstract class Veiculo
        {
            // método virtual - pode ser sobrescrito, mas não é obrigatório
            public virtual string VerificarPessoas()
            {
                return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
            }
        }

        * Classe Filha (modificando):
            namespace Polimorfismo
            {
                internal class Moto : Veiculo
                {
                    // override - sobrescreve o método da classe mãe
                    public override string VerificarPessoas()
                    {
                        return "Existe " + this.pessoas + " pessoas na Moto contando com o piloto";
                    }
                }
            }

---

* ## Classe Livro 
Implemente em C# uma classe Livro com as seguintes características:

Propriedades: Titulo (string), Autor (string) e AnoPublicacao (int).

Um construtor que receba e inicialize essas propriedades.

Um método ExibirInformacoes() que imprima no console as informações do livro no formato “Título – Autor (Ano)”.

Escreva o código completo da classe e um pequeno método Main que crie um objeto Livro, chame o método ExibirInformacoes() e mostre a saída esperada.

    * Main:
        using System;

        namespace Livro
        {
            class Program
            {
                static void Main(string[] args)
                {
                    // 1. Cria um objeto (instância) da classe Livro
                    Livro meuLivro = new Livro("O Guia do Mochileiro das Galáxias", "Douglas Adams", 1979);

                    // 2. Chama o método para exibir as informações no console
                    meuLivro.ExibirInformacoes();
                }
            }
        }

    * Classe Livro: 
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Livro
        {
            class Livro
            {
                // Propriedades da classe
                public string Titulo { get; set; }
                public string Autor { get; set; }
                public int AnoPublicacao { get; set; }

                // Construtor que inicializa as propriedades
                public Livro(string titulo, string autor, int anoPublicacao)
                {
                    this.Titulo = titulo;
                    this.Autor = autor;
                    this.AnoPublicacao = anoPublicacao;
                }

                // Método para exibir as informações formatadas
                public void ExibirInformacoes()
                {
                    Console.WriteLine($"{this.Titulo} – {this.Autor} ({this.AnoPublicacao})");
                }
            }
        }


---

* ## Hierarquia de veículos e polimorfismo 
Com base no exercício proposto no material, construa uma hierarquia de classes que represente veículos:

Uma classe base Veiculo com um método virtual Acelerar(), que imprima uma mensagem genérica (por exemplo, “Veículo acelerando…”).

Três classes derivadas (Carro, Caminhao e Moto) que herdam de Veiculo e sobrescrevem o método Acelerar(), exibindo mensagens específicas (por exemplo, “Carro acelerando rapidamente…”).

No método Main, crie uma lista ou coleção de objetos do tipo Veiculo contendo instâncias de Carro, Caminhao e Moto. Use um laço for ou while para percorrer a coleção e chame o método Acelerar() em cada elemento, demonstrando o polimorfismo.

    * Program:
        using Veiculos;
        using System;
        using System.Collections.Generic; // Habilita o uso de List<T>

        namespace Veiculos
        {
            internal class Program
            {
                // Ponto de entrada da aplicação.
                static void Main(string[] args)
                {
                    // 1. Cria uma coleção (Lista) do tipo da classe base (Veiculo).
                    List<Veiculo> veiculos = new List<Veiculo>();

                    // 2. Adiciona objetos de diferentes classes derivadas na mesma lista.
                    veiculos.Add(new Carro("ABC1234", "Gol", "Prata", "1.0"));
                    veiculos.Add(new Caminhao("DEF5678", "Volvo FH", "Branco", "13L"));
                    veiculos.Add(new Moto("GHI9876", "Hornet", "Dourada", "600cc"));

                    // 3. Percorre a lista e chama o mesmo método (Acelerar) para cada objeto.
                    // O polimorfismo garante que a versão correta do método seja executada
                    // para cada tipo de objeto.
                    foreach (Veiculo v in veiculos)
                    {
                        v.Acelerar();
                    }
                }
            }
        }

    * Veiculo:
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Veiculos
        {
            // Classe base abstrata que serve como modelo para outros veículos.
            abstract class Veiculo
            {
                protected string placa;
                protected string chassi;
                protected string cor;
                protected string motor;
                protected int pessoas;
                protected int capacidadePessoa;

                // Método virtual que pode ser sobrescrito pelas classes filhas.
                // Fornece um comportamento padrão.
                public virtual void Acelerar()
                {
                    Console.WriteLine("Veículo acelerando...");
                }
            }
        }



    * Moto:
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Veiculos
        {
            // Classe derivada que herda de Veiculo.
            internal class Moto : Veiculo
            {
                string modelo;

                public Moto(string placa, string modelo, string cor, string motor)
                {
                    capacidadePessoa = 2;
                    this.placa = placa;
                    this.modelo = modelo;
                    this.cor = cor;
                    this.motor = motor;
                    Random random = new Random();
                    chassi = random.Next().ToString("00000000000000000");
                }

                // Sobrescreve o método Acelerar com um comportamento específico para Moto.
                public override void Acelerar()
                {
                    Console.WriteLine("Moto acelerando e empinando...");
                }
            }
        }

    * Carro:
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Veiculos
        {
            // Classe derivada que herda de Veiculo.
            internal class Carro : Veiculo
            {
                string modelo;

                public Carro(string placa, string modelo, string cor, string motor)
                {
                    capacidadePessoa = 4;
                    this.placa = placa;
                    this.modelo = modelo;
                    this.cor = cor;
                    this.motor = motor;
                    Random random = new Random();
                    chassi = random.Next().ToString("00000000000000000");
                }

                // Sobrescreve o método Acelerar com um comportamento específico para Carro.
                public override void Acelerar()
                {
                    Console.WriteLine("Carro acelerando rapidamente...");
                }
            }
        }

    * Caminhao:
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace Veiculos
        {
            // Classe derivada que herda de Veiculo.
            internal class Caminhao : Veiculo
            {
                string modelo;
                public Caminhao(string placa, string modelo, string cor, string motor)
                {
                    capacidadePessoa = 3;
                    this.placa = placa;
                    this.modelo = modelo;
                    this.cor = cor;
                    this.motor = motor;
                    Random random = new Random();
                    chassi = random.Next().ToString("00000000000000000");
                }

                // Sobrescreve o método Acelerar com um comportamento específico para Caminhao.
                public override void Acelerar()
                {
                    Console.WriteLine("Caminhão acelerando lentamente com carga pesada...");
                }
            }
        }

