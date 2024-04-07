
using System;

namespace ComplejidadTemporalTp1
{
	
	public class Cola<T>
	{
		private Cola <T> elem;
		
		public Cola()
		{
			elem = new Cola<T>();
		}
		
		 public int ContarElementos()
    {
        return elem.Count;
    }

    public void Encolar(T elemento)
    {
        elem.Enqueue(elemento);
    }

    public T Desencolar()
    {
        if (elem.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía.");
        }

        return elem.Dequeue();
    }
     public bool EstaVacia()
    {
        return elem.Count == 0;
    }

    public void Limpiar()
    {
        elem.Clear();
    }
    
	void Clear()
	{
		throw new NotImplementedException();
	}
	}
}
