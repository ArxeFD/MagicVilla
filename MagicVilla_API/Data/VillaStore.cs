using MagicVilla_API.Models.DTO;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO{ID = 1, Name = "View to the pool"},
            new VillaDTO{ID = 2, Name = "View to the Beach"},
            new VillaDTO{ID = 3, Name = "View to the Trash"}
        };
    }
}
