namespace TAD;

class Program
{
	static void Main(string[] args)
	{
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
	}
}