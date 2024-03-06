namespace TAD;

class Program
{
	static void Main(string[] args)
	{
		/* *** PILHA ***
		
		IPilha<string> pilha = new Pilha<string>();

		pilha.Push("Primeiro");
		pilha.Push("Segundo");
		pilha.Push("Terceiro");

		Console.WriteLine(pilha.Peek()); // Deve exibir "Terceiro"
		
		// *** colocar essa parte na segunda fase de explicação do código	***
		while (!pilha.IsEmpty())
		{
			Console.WriteLine(pilha.Pop());
		}

		// A saída será:
		// Terceiro
		// Segundo
		// Primeiro
		*/
		
		IFila<string> fila = new Fila<string>();

        fila.Enqueue("Primeiro");
        fila.Enqueue("Segundo");
        fila.Enqueue("Terceiro");

        Console.WriteLine(fila.Peek()); // Deve exibir "Primeiro"

        while (!fila.IsEmpty())
        {
            Console.WriteLine(fila.Dequeue());
        }

        // A saída será:
        // Primeiro
        // Segundo
        // Terceiro
	}
}