namespace Huillin.Paginacion.net.interfaces
{
  public interface IPaginacion<T>
    {
        Paginacion<T> Paginacion(int NumeroPagina, int TamanioPagina);
        Paginacion<T> Paginacion(int NumeroPagina, int TamanioPagina, object filtro);
    }
}
