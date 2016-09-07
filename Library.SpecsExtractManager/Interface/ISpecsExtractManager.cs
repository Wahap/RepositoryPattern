
namespace Library.SpecsExtractManager.Interface
{
  public interface ISpecsExtractManager<out T1,in T2>
  {
    T1 Manage(T2 value);
  }
}
