
public class Estudiante : Comparador
{

    //public int numMat;
    public string nombre;

    public bool igualQue(object q)
    {
        return true;
    }

    public bool mayorIgualQue(object q)
    {
        Estudiante orden = (Estudiante)q;
        return nombre.CompareTo(orden.nombre) >= 0; //parametro orden.nombre nuevo nombre con el que se va comparar por medio del metodo aflb
    }

    public bool mayorQue(object q)
    {
        Estudiante orden = (Estudiante)q;
        return nombre.CompareTo(orden.nombre) > 0;
    }

    public bool menorIgualQue(object q)
    {
        Estudiante orden = (Estudiante)q;
        return nombre.CompareTo(orden.nombre) <= 0;
    }

    public bool menorQue(object q)
    {
        Estudiante orden = (Estudiante)q;
        return nombre.CompareTo(orden.nombre) < 0;
    }

}

