
using System;
using System.Collections.Generic;

namespace ComplejidadTemporalTp1
{
	
	public class ArbolBinario<T>
	{
		private T dato;
private ArbolBinario<T> hijoIzquierdo;
private ArbolBinario<T> hijoDerecho;
	

public ArbolBinario(T dato) {
	this.dato = dato;
}
	
public T getDatoRaiz() {
	return this.dato;
}
	
public ArbolBinario<T> getHijoIzquierdo() {
	return this.hijoIzquierdo;
}
	
public ArbolBinario<T> getHijoDerecho() {
	return this.hijoDerecho;
}
	
public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
	this.hijoIzquierdo=hijo;
}
	
public void agregarHijoDerecho(ArbolBinario<T> hijo) {
	this.hijoDerecho=hijo;
}
	
public void eliminarHijoIzquierdo() {
	this.hijoIzquierdo=null;
}
	
public void eliminarHijoDerecho() {
	this.hijoDerecho=null;
}
	
public bool esHoja() {
	return this.hijoIzquierdo==null && this.hijoDerecho==null;
}

public void inorden() {
	
	
		//recorro hijo izquierdo
		if (this.getHijoIzquierdo() != null)
		{
			this.hijoIzquierdo.inorden();
		}
		//Recorro la raiz
		Console.Write(this.getDatoRaiz() + " ");
		{
			//Recorro el hijo derecho
			if (this.getHijoDerecho() != null)
			{
				this.hijoDerecho.inorden();
			}
		}
	
}
public void preorden() {

	//Recorro la raiz
	Console.Write(getDatoRaiz() + " ");
	
	//recorro hijo izquierdo
	
	if(this.getHijoIzquierdo() != null)
	{
		this.hijoIzquierdo.preorden();
	}
	
	//recorro hijo derecho
	if(this.getHijoDerecho() != null){
		
		this.hijoDerecho.preorden();
	}
}

public void postorden(){
	
			//recorro hijo izquierdo
	
	if(this.getHijoIzquierdo() != null)
	{
		this.hijoIzquierdo.preorden();
	}
	
	//recorro hijo derecho
	if(this.getHijoDerecho() != null){
		
		this.hijoDerecho.preorden();
	}
	
	//Recorro la raiz
	Console.Write(getDatoRaiz() + " ");
	
	
}


	public void recorridoPorNiveles() {
	
	Cola<ArbolBinario<T>> cola = new Cola<ArbolBinario<T>>();
	ArbolBinario<T> arbolAux;
	
	cola.Encolar(this);
	while(!cola.EstaVacia()){
		
		arbolAux= cola.Desencolar();
		
		Console.Write(arbolAux.dato + " ");
		
		if(arbolAux.getHijoIzquierdo() != null){
			cola.Encolar(arbolAux.getHijoIzquierdo());
		}
		if(arbolAux.getHijoDerecho() != null){
			cola.Encolar(arbolAux.getHijoDerecho());
		}
		
		
		
	}
		}


    public List<T> Resolver(ArbolBinario<T> arbol, int longitud)
    {
    	//Creamos una lista llamada camino, que almacenará los nodos.
        List<T> camino = new List<T>();
        ResolverAux(arbol, longitud, camino);
        return camino;
    }

    private bool ResolverAux(ArbolBinario<T> nodo, int longitudRestante, List<T> camino)
    {
    	//Si el nodo está vacio, es el final de la rama y no se encontró el camino.
        if (nodo == null)
            return false;

        camino.Add(nodo.getDatoRaiz());

        if (nodo.esHoja() && longitudRestante == 1)
            return true;
	
        //Recorro las ramas
        if (ResolverAux(nodo.getHijoIzquierdo(), longitudRestante - 1, camino) ||
            ResolverAux(nodo.getHijoDerecho(), longitudRestante - 1, camino))
        {
            return true;
        }

        camino.RemoveAt(camino.Count - 1);
        return false;
    }
}



	}

	
