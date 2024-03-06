public interface IPilha<T>
{
	/*
	O <T> na definição da interface IPilha<T> é um exemplo de Generics em C#. 
	Generics permitem a criação de classes, interfaces e métodos com um "placeholder" para tipos de 
	dados. Esse "placeholder", representado por <T> neste caso, pode ser substituído por qualquer 
	tipo de dados quando a classe é instanciada ou o método é chamado. Isso torna o código mais 
	reutilizável e seguro em termos de tipo, pois permite que você escreva uma estrutura de dados ou 
	algoritmo sem se comprometer com um tipo de dados específico. 
	(Robert C. Martin. Princípios, Padrões e Práticas Ágeis em C#, 2011).
	*/
	
	void Push(T item); // Insere um item no topo da pilha
	T Pop(); // Remove e retorna o item do topo da pilha
	T Peek(); // Retorna o item do topo sem remover
	bool IsEmpty(); // Verifica se a pilha está vazia
}