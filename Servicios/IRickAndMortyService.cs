using ConsumirAPI3716370.Modelo;

namespace ConsumirAPI3716370.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();
    }
}
