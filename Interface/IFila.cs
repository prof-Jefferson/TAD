public interface IFila<T>
{
    void Enqueue(T item); // Adiciona um item ao final da fila
    T Dequeue(); // Remove e retorna o item do início da fila
    T Peek(); // Retorna o item do início sem remover
    bool IsEmpty(); // Verifica se a fila está vazia
}
